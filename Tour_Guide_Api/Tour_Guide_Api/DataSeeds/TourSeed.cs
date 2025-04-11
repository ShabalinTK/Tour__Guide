//using Tour_Guide_Api.Models;


//namespace Tour_Guide_Api.DataSeeds;

//public class TourSeed
//{
//    public static List<Tour> Tours = [
//        /*Египет*/
//        new Tour {
//            Id = 1,
//            Name = "Каир и пирамиды Гизы",
//            City = "Каир",
//            Theme = "History",
//            Reviews = 1284,
//            Price = 75,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=f8b24e2023a4b0902f465d0d9e7f9d53_l-4032982-images-thumbs&n=13",
//            Description = "Экскурсия к великим пирамидам и Сфинксу с профессиональным гидом",
//            Activities = new List<string> {
//                "Посещение плато Гиза",
//                "Осмотр Великого Сфинкса",
//                "Вход в пирамиду Хеопса",
//                "Обед в ресторане с видом на пирамиды"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт", "Гид", "Входные билеты", "Обед" },
//                ["NotIncludes"] = new List<string> { "Чаевые", "Сувениры", "Дополнительные активности" }
//            },
//            Safety = new List<string> {
//                "Гиды проходят регулярные медосмотры",
//                "Дезинфекция транспорта после каждого тура"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский", "Арабский" },
//                ["Duration"] = "8 часов",
//                ["GroupSize"] = "До 15 человек"
//            },
//            Address = "Плато Гиза, Аль-Харам, Гизa, Египет"
//        },

//        new Tour {
//            Id = 2,
//            Name = "Луксор: Долина Царей",
//            City = "Луксор",
//            Theme = "Adventure",
//            Reviews = 956,
//            Price = 89,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=e8944ab23c48700c2de8a8c62346d6c109310f594d4755ff-5205187-images-thumbs&n=13",
//            Description = "Путешествие по древней столице фараонов с посещением гробниц",
//            Activities = new List<string> {
//                "Долина Царей",
//                "Храм царицы Хатшепсут",
//                "Колоссы Мемнона",
//                "Прогулка по Нилу на фелюге"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Гид-египтолог", "Входные билеты", "Обед", "Трансфер" },
//                ["NotIncludes"] = new List<string> { "Алкогольные напитки", "Фото в гробницах" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский" },
//                ["Duration"] = "10 часов",
//                ["GroupSize"] = "Мини-группа до 8 человек"
//            },
//            Address = "West Bank, Luxor, Egypt"
//        },

//        new Tour {
//            Id = 3,
//            Name = "Дайвинг в Хургаде",
//            City = "Хургада",
//            Theme = "Diving",
//            Reviews = 1342,
//            Price = 65,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/271828/pub_66ff8dae4a836a5f0262d966_66ff8ed57a09ec3743c82d9e/scale_1200",
//            Description = "Погружение к красочным коралловым рифам Красного моря",
//            Activities = new List<string> {
//                "2 погружения с инструктором",
//                "Обед на яхте",
//                "Сноркелинг",
//                "Фотосессия под водой"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Снаряжение", "Инструктор", "Обед", "Трансфер из отеля" },
//                ["NotIncludes"] = new List<string> { "Аренда подводной камеры", "Дополнительные погружения" }
//            },
//            Safety = new List<string> {
//                "Сертифицированные инструкторы PADI",
//                "Медицинская страховка включена",
//                "Группы не более 6 человек"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский", "Немецкий" },
//                ["Duration"] = "6 часов",
//                ["RequiredLevel"] = "Начинающие и продвинутые"
//            },
//            Address = "Hurghada Marina, Hurghada, Egypt"
//        },

//        new Tour {
//            Id = 4,
//            Name = "Пустыня Сахара: Сафари на джипах",
//            City = "Каир",
//            Theme = "Desert",
//            Reviews = 721,
//            Price = 110,
//            ImageUrls = "https://i.pinimg.com/originals/a6/71/f1/a671f1cc81e93c5d4917ac30d37b85fe.jpg",
//            Description = "Экстремальное приключение по дюнам с посещением бедуинской деревни",
//            Activities = new List<string> {
//                "Гонки по дюнам на джипах 4x4",
//                "Катание на квадроциклах",
//                "Ужин у бедуинов",
//                "Наблюдение за звездами"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт", "Ужин", "Развлечения", "Гид" },
//                ["NotIncludes"] = new List<string> { "Аренда квадроциклов", "Сувениры" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Арабский" },
//                ["Duration"] = "Вечерний тур (5 часов)",
//                ["AgeRestriction"] = "От 12 лет"
//            },
//            Address = "Western Desert, Egypt"
//        },

//        new Tour {
//            Id = 5,
//            Name = "Круиз по Нилу: Луксор-Асуан",
//            City = "Луксор",
//            Theme = "Cruise",
//            Reviews = 845,
//            Price = 320,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=c0d385b9263abc9b339459a31b47de68_l-11271031-images-thumbs&n=13",
//            Description = "4-дневный круиз на 5-звездочном лайнере с экскурсиями",
//            Activities = new List<string> {
//                "Храмы Карнак и Луксор",
//                "Эдфу и Ком-Омбо",
//                "Асуанская плотина",
//                "Факульский остров"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Проживание", "Питание", "Экскурсии", "Развлечения" },
//                ["NotIncludes"] = new List<string> { "Алкоголь", "Чаевые", "Дополнительные экскурсии" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский", "Французский" },
//                ["Duration"] = "4 дня/3 ночи",
//                ["ShipClass"] = "5* Deluxe"
//            },
//            Address = "Nile River, Egypt"
//        },
//        new Tour {
//            Id = 6,
//            Name = "Александрия: античные сокровища",
//            City = "Александрия",
//            Theme = "Cultural",
//            Reviews = 587,
//            Price = 60,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/271828/pub_66bba9ab6d88ff2bde7e59fd_66bbaa06b7f20827b6ae22f1/scale_1200",
//            Description = "Исторический тур по главным достопримечательностям второго города Египта",
//            Activities = new List<string> {
//                "Крепость Кайт-Бей",
//                "Александрийская библиотека",
//                "Римский амфитеатр",
//                "Обед с видом на Средиземное море"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт с кондиционером", "Профессиональный гид", "Входные билеты", "Обед" },
//                ["NotIncludes"] = new List<string> { "Личные расходы", "Дополнительные музеи" }
//            },
//            Safety = new List<string> {
//                "Соблюдение всех санитарных норм",
//                "Малые группы для комфорта"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский" },
//                ["Duration"] = "9 часов",
//                ["Transport"] = "Комфортабельный микроавтобус"
//            },
//            Address = "Alexandria, Egypt"
//        },

//        new Tour {
//            Id = 7,
//            Name = "Абу-Симбел: чудо инженерии",
//            City = "Асуан",
//            Theme = "Archaeology",
//            Reviews = 423,
//            Price = 120,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/5234097/pub_6247f3fe0d93f6543d583110_624ac4163d1e6816274f03a8/scale_1200",
//            Description = "Путешествие к величественным храмам, спасенным от затопления",
//            Activities = new List<string> {
//                "Храм Рамзеса II",
//                "Храм Нефертари",
//                "Музей проекта спасения",
//                "Фотосессия на фоне храмов"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Перелет Асуан-Абу-Симбел", "Входные билеты", "Гид-египтолог", "Бутилированная вода" },
//                ["NotIncludes"] = new List<string> { "Видеосъемка внутри храмов", "Сувениры" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Арабский" },
//                ["Duration"] = "12 часов (с 5:00 утра)",
//                ["PhysicalLevel"] = "Умеренная ходьба"
//            },
//            Address = "Abu Simbel, Aswan Governorate, Egypt"
//        },

//        new Tour {
//            Id = 8,
//            Name = "Сокровища Каирского музея",
//            City = "Каир",
//            Theme = "Museum",
//            Reviews = 892,
//            Price = 45,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/1912454/pub_60f977120c3a1968a6fb44e7_60fa5c552c5b736118132dcc/scale_1200",
//            Description = "Экскурсия по крупнейшей коллекции древнеегипетского искусства",
//            Activities = new List<string> {
//                "Золотая маска Тутанхамона",
//                "Зал мумий фараонов",
//                "Сокровища из гробниц",
//                "История древнего искусства"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Входной билет", "Лицензированный гид", "Карта музея" },
//                ["NotIncludes"] = new List<string> { "Аудиогид", "Фотосъемка (требуется отдельный билет)" }
//            },
//            Safety = new List<string> {
//                "Обязательная проверка на входе",
//                "Гиды с медицинской подготовкой"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Французский", "Арабский" },
//                ["Duration"] = "3-4 часа",
//                ["MuseumRules"] = "Запрещены большие сумки"
//            },
//            Address = "Tahrir Square, Cairo, Egypt"
//        },

//        new Tour {
//            Id = 9,
//            Name = "Гора Синай и монастырь",
//            City = "Синай",
//            Theme = "Religious",
//            Reviews = 356,
//            Price = 80,
//            ImageUrls = "https://sun9-12.userapi.com/impg/LzjRAtJWkZjy40CL962EU5kKfqYy0Pzpq0uC5A/fOZpdIDgZgo.jpg?size=1000x666&quality=95&sign=0049f0c95b5301de26061e04ba5e7df2&c_uniq_tag=0Hz4dJ8z2X1cUUrkOA2Dc9BjNOjJQ8EgkrBVxJxK1GA&type=album",
//            Description = "Духовное путешествие к священным местам трех религий",
//            Activities = new List<string> {
//                "Восхождение на гору Синай",
//                "Монастырь Святой Екатерины",
//                "Неопалимая купина",
//                "Встреча рассвета"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Трансфер из отеля", "Гид", "Завтрак", "Фонарик" },
//                ["NotIncludes"] = new List<string> { "Аренда верблюда", "Дополнительные пожертвования" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Греческий" },
//                ["Duration"] = "Ночной тур (10 часов)",
//                ["Clothing"] = "Скромная одежда для посещения монастыря"
//            },
//            Address = "Saint Catherine, South Sinai Governorate, Egypt"
//        },

//        new Tour {
//            Id = 10,
//            Name = "Морская жизнь Хургады",
//            City = "Хургада",
//            Theme = "Family",
//            Reviews = 674,
//            Price = 30,
//            ImageUrls = "https://media.tacdn.com/media/attractions-content--1x-1/0b/27/6c/be.jpg",
//            Description = "Знакомство с подводным миром Красного моря без погружения",
//            Activities = new List<string> {
//                "Подводная обсерватория",
//                "Коралловый риф",
//                "Рыбалка на пирсе",
//                "Морской музей"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Входной билет", "Экскурсия", "Морская прогулка" },
//                ["NotIncludes"] = new List<string> { "Аренда снаряжения для снорклинга", "Сувениры" }
//            },
//            Safety = new List<string> {
//                "Спасатели на территории",
//                "Детские спасательные жилеты"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Арабский", "Русский" },
//                ["Duration"] = "3 часа",
//                ["Accessibility"] = "Подходит для детей и пожилых"
//            },
//            Address = "Hurghada Marina, Red Sea Governorate, Egypt"
//        },
//        /*Бали*/
//        new Tour {
//            Id = 11,
//            Name = "Сердце Бали: храмы и рисовые террасы",
//            City = "Убуд",
//            Theme = "Cultural",
//            Reviews = 892,
//            Price = 55,
//            ImageUrls = "https://stihi.ru/pics/2024/08/12/2388.jpg",
//            Description = "Погружение в культурное наследие Бали с посещением священных мест",
//            Activities = new List<string> {
//                "Храм Тирта Эмпул (очищение в священных источниках)",
//                "Рисовые террасы Тегаллаланг",
//                "Священный лес обезьян",
//                "Традиционный обед в балийском доме"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт с кондиционером", "Русскоговорящий гид", "Входные билеты", "Обед" },
//                ["NotIncludes"] = new List<string> { "Пожертвования в храмах", "Сувениры" }
//            },
//            Safety = new List<string> {
//                "Соблюдение храмовых дресс-кодов",
//                "Безопасное взаимодействие с обезьянами"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский" },
//                ["Duration"] = "10 часов",
//                ["DressCode"] = "Саранг и пояс для посещения храмов (предоставляются)"
//            },
//            Address = "Jl. Raya Tegallalang, Tegallalang, Gianyar, Bali"
//        },

//        new Tour {
//            Id = 12,
//            Name = "Рассвет на вулкане Батур",
//            City = "Кинтамани",
//            Theme = "Adventure",
//            Reviews = 1124,
//            Price = 75,
//            ImageUrls = "https://img.tourister.ru/files/3/3/4/9/9/6/2/7/7/clones/900_900_fixed.jpg",
//            Description = "Ночное восхождение к кратеру активного вулкана для встречи рассвета",
//            Activities = new List<string> {
//                "Треккинг (2 часа восхождения)",
//                "Завтрак с видом на кальдеру",
//                "Купание в горячих источниках",
//                "Посещение кофейной плантации"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Трансфер из отеля", "Гид", "Фонарик", "Завтрак", "Минеральная вода" },
//                ["NotIncludes"] = new List<string> { "Аренда треккинговой обуви", "Дополнительные активности" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Русский" },
//                ["Difficulty"] = "Средний уровень",
//                ["StartTime"] = "2:00 ночи (из Убуда)"
//            },
//            Address = "Mount Batur, Kintamani, Bangli Regency, Bali"
//        },

//        new Tour {
//            Id = 13,
//            Name = "Сноркелинг с мантами у Нуса Пениды",
//            City = "Нуса Пенида",
//            Theme = "Diving",
//            Reviews = 1347,
//            Price = 95,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=977a626f2ecc561c0342c26662c87c0bb1332369-5294555-images-thumbs&n=13",
//            Description = "Встреча с гигантскими мантами в их естественной среде обитания",
//            Activities = new List<string> {
//                "3 точки для сноркелинга",
//                "Обед на пляже Кристал Бэй",
//                "Посещение пляжа Атумбу",
//                "Фотосессия с мантами (подводный фотограф)"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Скоростной катер", "Снаряжение", "Обед", "Страховка", "Фрукты и вода" },
//                ["NotIncludes"] = new List<string> { "Аренда подводной камеры", "Дополнительные фото" }
//            },
//            Safety = new List<string> {
//                "Спасательные жилеты обязательны",
//                "Гидролокация мант перед погружением"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Балийский" },
//                ["BestSeason"] = "Апрель-Октябрь",
//                ["PhysicalRequirement"] = "Умение плавать"
//            },
//            Address = "Manta Point, Nusa Penida, Bali"
//        },

//        new Tour {
//            Id = 14,
//            Name = "Магические водопады Бали",
//            City = "Северный Бали",
//            Theme = "Nature",
//            Reviews = 678,
//            Price = 65,
//            ImageUrls = "https://digitaltravelcouple.com/wp-content/uploads/2021/07/banyumala-twin-waterfall-2022-1536x864.jpg",
//            Description = "Экспедиция к самым живописным водопадам острова",
//            Activities = new List<string> {
//                "Водопад Секумпул (75 метров)",
//                "Скрытый водопад Банюмала",
//                "Купание в природных бассейнах",
//                "Обед с видом на озеро Батур"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт 4x4", "Гид", "Входные билеты", "Обед", "Бутилированная вода" },
//                ["NotIncludes"] = new List<string> { "Аренда полотенец", "Сувениры" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Балийский" },
//                ["Duration"] = "12 часов",
//                ["Clothing"] = "Купальник под одеждой, треккинговые сандалии"
//            },
//            Address = "Sekumpul Waterfall, Sawan, Buleleng, Bali"
//        },

//        new Tour {
//            Id = 15,
//            Name = "Балийский кулинарный мастер-класс",
//            City = "Убуд",
//            Theme = "Food",
//            Reviews = 432,
//            Price = 45,
//            ImageUrls = "https://image.kkday.com/v2/image/get/w_1900%2Cc_fit/s1.kkday.com/product_141069/20230319140648_8Kvnd/jpg",
//            Description = "Приготовление традиционных блюд с местным шеф-поваром",
//            Activities = new List<string> {
//                "Посещение утреннего рынка",
//                "Приготовление 5 балийских блюд",
//                "Дегустация местного кофе Лювак",
//                "Ужин в рисовом поле"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Все ингредиенты", "Фартук и оборудование", "Рецепты на память", "Ужин" },
//                ["NotIncludes"] = new List<string> { "Алкогольные напитки", "Трансфер (опционально)" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Русский (переводчик)" },
//                ["Duration"] = "5 часов (16:00-21:00)",
//                ["Vegetarian"] = "Доступна вегетарианская версия"
//            },
//            Address = "Jl. Raya Sanggingan, Ubud, Bali"
//        },

//        new Tour {
//            Id = 16,
//            Name = "Романтический ужин на рисовых полях",
//            City = "Тегаллаланг",
//            Theme = "Romance",
//            Reviews = 289,
//            Price = 120,
//            ImageUrls = "https://cdn.getyourguide.com/img/tour/5ba316d867c53.jpeg/145.jpg",
//            Description = "Частный ужин при свечах с панорамным видом на террасы",
//            Activities = new List<string> {
//                "Приветственный коктейль",
//                "5-блюдный сет от шеф-повара",
//                "Живая традиционная музыка",
//                "Фотосессия на закате"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Личный повар", "Декорации", "Фотограф (30 мин)", "Вино" },
//                ["NotIncludes"] = new List<string> { "Транспорт", "Дополнительный алкоголь" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "3 часа (18:00-21:00)",
//                ["Capacity"] = "Только для пар"
//            },
//            Address = "Sawah Terrace, Jl. Raya Tegallalang, Bali"
//        },

//        new Tour {
//            Id = 17,
//            Name = "Уроки серфинга на Куте",
//            City = "Кута",
//            Theme = "Sports",
//            Reviews = 876,
//            Price = 40,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=44d013b21eb13a0a5e3760d0d78a1edf_l-5235404-images-thumbs&n=13",
//            Description = "Обучение серфингу с профессиональным инструктором",
//            Activities = new List<string> {
//                "Теория на пляже (30 мин)",
//                "Практика в воде (2 часа)",
//                "Анализ ошибок с видеоразбором",
//                "Сертификат о прохождении"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Доска для серфинга", "Гидрокостюм", "Инструктор", "Страховка" },
//                ["NotIncludes"] = new List<string> { "Фото и видео (опционально)", "Аренда шкафчика" }
//            },
//            Safety = new List<string> {
//                "Спасатели на пляже",
//                "Мелководье для начинающих"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Русский", "Английский", "Балийский" },
//                ["Duration"] = "3 часа",
//                ["AgeLimit"] = "От 12 лет"
//            },
//            Address = "Kuta Beach, Badung Regency, Bali"
//        },

//        new Tour {
//            Id = 18,
//            Name = "Однодневный тур на Гили Траванган",
//            City = "Гили Траванган",
//            Theme = "Island",
//            Reviews = 765,
//            Price = 110,
//            ImageUrls = "https://static.tildacdn.com/tild3531-6265-4630-a139-666261616566/rotate-image-onlinec.jpg",
//            Description = "Путешествие на райский остров без автомобилей",
//            Activities = new List<string> {
//                "Паром из Паданг Бай",
//                "Сноркелинг с черепахами",
//                "Обед на пляже",
//                "Велосипедная экскурсия по острову"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Билеты на паром", "Снаряжение для сноркелинга", "Обед", "Велосипед" },
//                ["NotIncludes"] = new List<string> { "Аренда тележки (cidomo)", "Дополнительные напитки" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Индонезийский" },
//                ["Duration"] = "12 часов (7:00-19:00)",
//                ["Note"] = "Рекомендуется взять наличные (на острове нет банкоматов)"
//            },
//            Address = "Gili Trawangan, Lombok"
//        },

//        new Tour {
//            Id = 19,
//            Name = "Утренний йога-класс в джунглях",
//            City = "Убуд",
//            Theme = "Wellness",
//            Reviews = 321,
//            Price = 25,
//            ImageUrls = "https://welcomebackhome.ru/wp-content/uploads/2020/03/5c60f686de3fd.jpg",
//            Description = "Практика йоги в открытом павильоне среди рисовых полей",
//            Activities = new List<string> {
//                "Хатха-йога (1.5 часа)",
//                "Медитация у реки",
//                "Здоровый завтрак",
//                "Чайная церемония"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Коврик для йоги", "Полотенце", "Завтрак", "Травяной чай" },
//                ["NotIncludes"] = new List<string> { "Персональные занятия", "Транспорт" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Русский (перевод)" },
//                ["Duration"] = "3 часа (7:00-10:00)",
//                ["Level"] = "Для всех уровней"
//            },
//            Address = "The Yoga Barn, Ubud, Bali"
//        },

//        new Tour {
//            Id = 20,
//            Name = "Пабы и бары Семиньяка",
//            City = "Семиньяк",
//            Theme = "Nightlife",
//            Reviews = 198,
//            Price = 70,
//            ImageUrls = "https://i.pinimg.com/originals/7a/c6/f2/7ac6f27bd17bc13f7c72732a89162a0a.jpg",
//            Description = "Тур по лучшим заведениям модного района Бали",
//            Activities = new List<string> {
//                "Посещение 5 премиальных баров",
//                "Дегустация коктейлей",
//                "VIP-вход в клуб",
//                "Фотосессия на пляже"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Транспорт между локациями", "3 коктейля", "Фотограф", "VIP вход" },
//                ["NotIncludes"] = new List<string> { "Дополнительные напитки", "Чаевые" }
//            },
//            Safety = new List<string> {
//                "Ограничение алкоголя - 3 коктейля",
//                "Групповой трансфер до отеля"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Русский гид" },
//                ["Duration"] = "5 часов (20:00-01:00)",
//                ["DressCode"] = "Smart casual (шорты запрещены в клубах)"
//            },
//            Address = "Jl. Kayu Aya, Seminyak, Bali"
//        },
//        /*Сейшелы*/
//        new Tour {
//            Id = 21,
//            Name = "Райский остров Праслин",
//            City = "Праслин",
//            Theme = "Nature",
//            Reviews = 687,
//            Price = 145,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=c72dc82bd76020a86bb144371822f372_l-5238529-images-thumbs&n=13",
//            Description = "Экскурсия на второй по величине остров Сейшел с посещением знаменитого пляжа Анс Лазьо",
//            Activities = new List<string> {
//                "Заповедник Валле-де-Мэ (пальмы Коко-де-мер)",
//                "Пляж Анс Лазьо - один из лучших в мире",
//                "Обед из морепродуктов",
//                "Свободное время для купания"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Паром Маэ-Праслин", "Входные билеты", "Гид", "Обед" },
//                ["NotIncludes"] = new List<string> { "Алкогольные напитки", "Аренда шезлонгов" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "Полный день (8:00-18:00)",
//                ["PhysicalLevel"] = "Легкие прогулки"
//            },
//            Address = "Praslin Island, Seychelles"
//        },

//        new Tour {
//            Id = 22,
//            Name = "Дайвинг с черепахами",
//            City = "Ла-Диг",
//            Theme = "Diving",
//            Reviews = 432,
//            Price = 180,
//            ImageUrls = "https://i.pinimg.com/736x/98/2d/f3/982df3adc21429d753179a45d54e51c5.jpg",
//            Description = "Погружение к нетронутым коралловым рифам в заповедной зоне",
//            Activities = new List<string> {
//                "2 погружения с гидом",
//                "Встреча с гигантскими черепахами",
//                "Обед на пляже Гранд-Анс",
//                "Сноркелинг в лагуне"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Снаряжение", "Инструктор", "Обед", "Страховка" },
//                ["NotIncludes"] = new List<string> { "Аренда подводной камеры", "Трансфер на пароме" }
//            },
//            Safety = new List<string> {
//                "Сертифицированные инструкторы PADI",
//                "Группы не более 6 человек"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Немецкий" },
//                ["Depth"] = "12-18 метров",
//                ["Requirements"] = "Сертификат OWD или выше"
//            },
//            Address = "Anse Patates, La Digue, Seychelles"
//        },

//        new Tour {
//            Id = 23,
//            Name = "Ужин при свечах на берегу океана",
//            City = "Маэ",
//            Theme = "Romance",
//            Reviews = 289,
//            Price = 250,
//            ImageUrls = "https://www.tkbbank.ru/upload/iblock/e1e/17.jpg",
//            Description = "Частный ужин на белоснежном пляже с персональным обслуживанием",
//            Activities = new List<string> {
//                "Приветственный коктейль на закате",
//                "5-курсный ужин от шеф-повара",
//                "Живая креольская музыка",
//                "Фотосессия у океана"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Шампанское", "Персональный официант", "Фотограф", "Декорации" },
//                ["NotIncludes"] = new List<string> { "Трансфер", "Дополнительный алкоголь" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Французский", "Английский" },
//                ["Duration"] = "3 часа (18:30-21:30)",
//                ["Capacity"] = "Только для пар"
//            },
//            Address = "Beau Vallon Beach, Mahe, Seychelles"
//        },

//        new Tour {
//            Id = 24,
//            Name = "Заповедник Кузин",
//            City = "Кузин",
//            Theme = "Wildlife",
//            Reviews = 356,
//            Price = 160,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=c1137f28b8e8380f0d75238e1c14ea59_l-5319549-images-thumbs&n=13",
//            Description = "Посещение птичьего заповедника с эндемичными видами",
//            Activities = new List<string> {
//                "Экскурсия с орнитологом",
//                "Черепаший питомник",
//                "Пикник на безлюдном пляже",
//                "Сноркелинг у кораллового рифа"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Катер", "Гид", "Обед", "Снаряжение для сноркелинга" },
//                ["NotIncludes"] = new List<string> { "Сувениры", "Аренда полотенец" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "6 часов (9:00-15:00)",
//                ["Note"] = "Запрещено кормить животных"
//            },
//            Address = "Cousin Island, Seychelles"
//        },

//        new Tour {
//            Id = 25,
//            Name = "Сейшельская кухня",
//            City = "Маэ",
//            Theme = "Food", //Food
//            Reviews = 198,
//            Price = 95,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/271828/pub_662ca712d8a8ec2d7c1f83d3_662cdab22d418844dc09389d/scale_1200",
//            Description = "Знакомство с креольской кухней на местном рынке и в ресторанах",
//            Activities = new List<string> {
//                "Экскурсия по рынку Sir Selwyn Clarke",
//                "Дегустация 10 традиционных блюд",
//                "Мастер-класс по приготовлению рыбы-попугая",
//                "Ужин с видом на гавань Виктории"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Все дегустации", "Гид", "Ужин", "Рецепты" },
//                ["NotIncludes"] = new List<string> { "Алкоголь", "Сувениры" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Креольский" },
//                ["Duration"] = "5 часов (15:00-20:00)",
//                ["Vegetarian"] = "По запросу"
//            },
//            Address = "Victoria Market, Mahe, Seychelles"
//        },

//        new Tour {
//            Id = 26,
//            Name = "Частный яхтинг на остров Раунд",
//            City = "Маэ",
//            Theme = "Luxury", //Luxury
//            Reviews = 521,
//            Price = 320,
//            ImageUrls = "https://getmecar.ru/wp-content/uploads/2024/02/2021-12-10-12-39-07.jpg",
//            Description = "Эксклюзивный круиз на частной яхте с купанием в лагунах",
//            Activities = new List<string> {
//                "Прогулка на 40-футовой яхте",
//                "Сноркелинг у морского парка Св. Анны",
//                "Барбекю на палубе",
//                "Отдых на частном пляже"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Яхта с капитаном", "Обед", "Напитки", "Снаряжение" },
//                ["NotIncludes"] = new List<string> { "Чаевые экипажу", "Дополнительный алкоголь" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "7 часов (10:00-17:00)",
//                ["Capacity"] = "До 8 человек"
//            },
//            Address = "Eden Marina, Mahe, Seychelles"
//        },

//        new Tour {
//            Id = 27,
//            Name = "Глубокая рыбалка",
//            City = "Маэ",
//            Theme = "Fishing", //Fishing
//            Reviews = 287,
//            Price = 280,
//            ImageUrls = "https://avatars.dzeninfra.ru/get-zen_doc/3341818/pub_611f725d6b308635caf37415_611f88076b308635ca1a28ab/scale_1200",
//            Description = "Трофейная рыбалка на марлина, тунца и барракуду",
//            Activities = new List<string> {
//                "6 часов в открытом океане",
//                "Профессиональные снасти",
//                "Приготовление улова на борту",
//                "Сертификат о рекорде (если повезет)"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Катер", "Снаряжение", "Капитан", "Обед" },
//                ["NotIncludes"] = new List<string> { "Лицензия на рыбалку", "Таксидермия улова" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Креольский" },
//                ["Duration"] = "8 часов (7:00-15:00)",
//                ["Note"] = "Возможна морская болезнь"
//            },
//            Address = "Victoria Harbour, Mahe, Seychelles"
//        },

//        new Tour {
//            Id = 28,
//            Name = "Вертолетный тур над островами",
//            City = "Маэ",
//            Theme = "Adventure", //Adventure
//            Reviews = 156,
//            Price = 450,
//            ImageUrls = "https://avatars.mds.yandex.net/i?id=a2289451b0ef65de7032d9f8681531b9_l-5293988-images-thumbs&n=13",
//            Description = "Панорамные виды с высоты птичьего полета",
//            Activities = new List<string> {
//                "20-минутный полет",
//                "Виды на острова Праслин, Ла-Диг",
//                "Фотосессия у водопада",
//                "Шампанское после посадки"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Вертолет", "Пилот-гид", "Фото", "Шампанское" },
//                ["NotIncludes"] = new List<string> { "Трансфер в аэропорт", "Видеосъемка" }
//            },
//            Safety = new List<string> {
//                "Сертифицированные пилоты",
//                "Страховка включена"
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "1 час (включая подготовку)",
//                ["WeightLimit"] = "Макс 100 кг на человека"
//            },
//            Address = "Seychelles International Airport, Mahe"
//        },

//        new Tour {
//            Id = 29,
//            Name = "Роскошный СПА на берегу океана",
//            City = "Маэ",
//            Theme = "Wellness", //Wellness
//            Reviews = 342,
//            Price = 175,
//            ImageUrls = "https://i.tez-tour.travel/img/hotels/25301/5.jpg",
//            Description = "Процедуры с использованием местных кокосовых масел и ванилина",
//            Activities = new List<string> {
//                "90-минутный массаж",
//                "Обертывание водорослями",
//                "СПА-обед",
//                "Доступ к частному пляжу"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Все процедуры", "Халат и тапочки", "Обед", "Безалкогольные напитки" },
//                ["NotIncludes"] = new List<string> { "Дополнительные процедуры", "Алкоголь" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Французский" },
//                ["Duration"] = "4 часа",
//                ["Note"] = "Бронирование за 24 часа"
//            },
//            Address = "Six Senses Spa, Anse Intendance, Mahe"
//        },

//        new Tour {
//            Id = 30,
//            Name = "Остров гигантских черепах",
//            City = "Курьёз",
//            Theme = "Family",
//            Reviews = 421,
//            Price = 130,
//            ImageUrls = "https://cdn.tripster.ru/thumbs2/c30b9710-e76b-11ee-9d43-323d7e32f61e.1080x810.jpeg",
//            Description = "Знакомство с редкими альдабрскими черепахами в их естественной среде",
//            Activities = new List<string> {
//                "Экскурсия по заповеднику",
//                "Кормление черепах",
//                "Прогулка по мангровому лесу",
//                "Пикник на пляже"
//            },
//            Includes = new Dictionary<string, List<string>> {
//                ["Includes"] = new List<string> { "Катер", "Гид", "Обед", "Входные билеты" },
//                ["NotIncludes"] = new List<string> { "Сувениры", "Аренда снаряжения" }
//            },
//            Details = new Dictionary<string, object> {
//                ["Language"] = new List<string> { "Английский", "Креольский" },
//                ["Duration"] = "5 часов (9:00-14:00)",
//                ["Note"] = "Запрещено кататься на черепахах"
//            },
//            Address = "Curieuse Island, Seychelles"
//        }
//    ];
//}
