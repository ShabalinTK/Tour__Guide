using Tour_Guide_Api.Models;

namespace Tour_Guide_Api.DataSeeds;

public class CommentSeed
{
    public static List<Comment> Comments = new List<Comment>
    {
        new Comment {
            Id = 1,
            TourId = 1,
            UserName = "Килиан Мбаппе",
            AvatarUrl = "https://avatars.mds.yandex.net/i?id=64aac64a2f3937851d96ad58f5435dcd_l-4599655-images-thumbs&n=13",
            CommentDate = "2 Октября 2012",
            Text = "Отличный тур! Гиды очень профессиональные.",
            Rating = 5
        },
        new Comment {
            Id = 2,
            TourId = 2,
            UserName = "Messi",
            AvatarUrl = "https://avatars.mds.yandex.net/i?id=176752da29827c4c7deea32b166f8bae_l-5227706-images-thumbs&n=13",
            CommentDate = "8 Октября 2012",
            Text = "Лучший тур!",
            Rating = 4
        },
        new Comment {
            Id = 3,
            TourId = 13,
            UserName = "Иван Сидоров",
            AvatarUrl = "https://avatars.mds.yandex.net/i?id=55ad501200fca7610f2c3bc022b759bd_l-5208099-images-thumbs&n=13",
            CommentDate = "8 Октября 2012",
            Text = "Немного устали, но впечатления незабываемые!",
            Rating = 4
        },
    };
}
