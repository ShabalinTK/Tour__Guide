using Microsoft.AspNetCore.Mvc;
using Tour_Guide_Api.Models;
using Tour_Guide_Api.DataSeeds;

namespace Tour_Guide_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourController : ControllerBase
{

    public TourController()
    {

    }

    [HttpGet]
    public IEnumerable<Tour> GetAllTours()
    {
        return TourSeed.Tours;
    }

    [HttpGet("{id}")]
    public Tour GetTourById(int id)
    {
        var tour = TourSeed.Tours.FirstOrDefault(c => c.Id == id);

        return tour ?? throw new Exception($"Тур с ID {id} не найден");
    }

    [HttpGet("filtered")]
    public IActionResult GetFilteredTours(
    [FromQuery] List<string>? themes,
    [FromQuery] List<string>? destinations,
    [FromQuery] List<string>? durations,
    [FromQuery] string? sortBy) // "popularity", "price_low_to_high", "price_high_to_low"
    {
        var filtered = TourSeed.Tours.AsQueryable();

        // Фильтрация (остается без изменений)
        if (themes != null && themes.Any())
        {
            filtered = filtered.Where(t =>
                t.Activities != null &&
                t.Activities.Any(a => themes.Any(th => a.Contains(th))));
        }

        if (destinations != null && destinations.Any())
        {
            filtered = filtered.Where(t =>
                destinations.Contains(t.City) ||
                (t.Details.ContainsKey("Destination") &&
                 destinations.Any(d => t.Details["Destination"].ToString().Contains(d))));
        }

        if (durations != null && durations.Any())
        {
            filtered = filtered.Where(t =>
                t.Details.ContainsKey("Duration") &&
                durations.Any(dur => t.Details["Duration"].ToString().Contains(dur)));
        }

        // Сортировка
        filtered = sortBy switch
        {
            "popularity" => filtered.OrderByDescending(t => t.Reviews),
            "price_low_to_high" => filtered.OrderBy(t => t.Price),
            "price_high_to_low" => filtered.OrderByDescending(t => t.Price),
            _ => filtered
        };

        return Ok(filtered.ToList());
    }

    [HttpGet("{tourId}/comments")]
    public IActionResult GetTourComments(int tourId)
    {
        var comments = CommentSeed.Comments
            .Where(c => c.TourId == tourId)
            .ToList();

        return Ok(comments);
    }
}
