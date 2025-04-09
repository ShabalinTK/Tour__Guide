namespace Tour_Guide_Api.Abstractions;

public interface IEmailService
{
    Task SendAsync(string to, string subject, string body);
}