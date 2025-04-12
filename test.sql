create database ИтЗаказы
USE [ИтЗаказы]
GO
/****** Object:  Table [dbo].[Заказы]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказы](
	[ИдЗаказа] [int] IDENTITY(1,1) NOT NULL,
	[ИдКлиента] [nvarchar](50) NOT NULL,
	[КомпьютерноеПриложение] [bit] NOT NULL,
	[БраузерноеПриложение] [bit] NOT NULL,
	[МобильноеПриложение] [bit] NOT NULL,
	[ОписаниеКлиента] [nvarchar](max) NOT NULL,
	[ОписаниеСотрудника] [nvarchar](max) NOT NULL,
	[ДатаСоздания] [datetime] NOT NULL,
	[Статус] [nvarchar](50) NOT NULL,
	[Приоритет] [smallint] NOT NULL,
	[Цена] [decimal](12, 3) NULL,
	[ВиделКлиент] [bit] NOT NULL,
	[ВиделСотрудник] [bit] NOT NULL,
	[КогдаВиделКлиент] [datetime] NULL,
	[КогдаВиделСотрудник] [datetime] NULL,
	[Оценка] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдЗаказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИсторияВосстановленияПароля]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ИсторияВосстановленияПароля](
	[ИдИстории] [int] IDENTITY(1,1) NOT NULL,
	[ИдКлиента] [int] NOT NULL,
	[Почта] [nvarchar](250) NOT NULL,
	[ОтправленныйКод] [int] NOT NULL,
	[ДатаОтправки] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Клиенты]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиенты](
	[ИдКлиента] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NOT NULL,
	[Имя] [nvarchar](50) NOT NULL,
	[Телефон] [nvarchar](10) NOT NULL,
	[ДатаРегистрации] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдКлиента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пользователи]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пользователи](
	[ИдПользователя] [int] IDENTITY(1,1) NOT NULL,
	[ИдИсточника] [int] NOT NULL,
	[ТипИсточника] [nvarchar](15) NOT NULL,
	[Логин] [nvarchar](250) NOT NULL,
	[Пароль] [nvarchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдПользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудники]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудники](
	[ИдСотрудника] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NOT NULL,
	[Имя] [nvarchar](50) NOT NULL,
	[Роль] [nvarchar](50) NOT NULL,
	[Телефон] [nvarchar](10) NOT NULL,
	[ДатаПриема] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдСотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ЧатПоЗаказам]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ЧатПоЗаказам](
	[ИдСообщения] [int] IDENTITY(1,1) NOT NULL,
	[ИдЗаказа] [int] NOT NULL,
	[ИдСотрудника] [int] NOT NULL,
	[ИдКлиента] [int] NOT NULL,
	[Сообщение] [nvarchar](max) NOT NULL,
	[ДатаОтправки] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдСообщения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Заказы] ON 
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (3, N'1', 1, 0, 0, N'Сайт и десктопное приложение для любителей уличной еды, где можно найти лучшие места с шаурмой, бургерами, пиццей и другими перекусами. Пользователи смогут:

Искать заведения по рейтингу, кухне или местоположению.

Читать отзывы и смотреть фото блюд.

Бронировать еду заранее или заказывать доставку.

Получать персонализированные рекомендации.

Для владельцев точек – кабинет с аналитикой, управлением меню и акциями. Десктопная версия добавит удобные инструменты для работы с заказами и статистикой.', N'', CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Новый', 0, CAST(45000.000 AS Decimal(12, 3)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (4, N'2', 0, 1, 1, N'Сервис помогает находить мобильные точки уличной еды в реальном времени. Особенности:

Интерактивная карта с GPS-трекингом фудтраков.

Уведомления о передвижении любимых продавцов.

Система лояльности с кэшбэком за отзывы.

Возможность предзаказа через приложение.

Десктопная версия будет полезна организаторам фестивалей и владельцам фудтраков для планирования маршрутов и управления расписанием.', N' ', CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Уточнение деталей', 0, CAST(85000.000 AS Decimal(12, 3)), 0, 1, CAST(N'2025-04-12T16:59:47.090' AS DateTime), CAST(N'2025-04-11T23:05:55.190' AS DateTime), -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (6, N'2', 1, 1, 0, N'Специализированный сервис для ценителей шаурмы:

База данных с рейтингами по соусу, мясу и свежести лаваша.

Фильтры по цене, халяльности и веган-опциям.

Раздел с секретными рецептами от поваров.

Возможность голосовать за лучшую точку в городе.

Десктопная версия добавит статистику продаж для владельцев и инструменты продвижения.', N' ', CAST(N'2024-12-10T00:00:00.000' AS DateTime), N'Готов', 2, CAST(45000.000 AS Decimal(12, 3)), 0, 0, NULL, NULL, 1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (8, N'3', 1, 1, 0, N'Платформа для фанатов бургеров:

Каталог заведений с детальными описаниями ингредиентов.

Возможность создавать свой бургер и заказывать его в партнерских точках.

Акции и челленджи (например, «Съешь 10 бургеров – получи мерч»).

Live-трансляции с кухонь ресторанов.

Десктоп-версия даст ресторанам CRM-систему для работы с клиентами.', N' ', CAST(N'2025-01-03T00:00:00.000' AS DateTime), N'Разработка', 1, CAST(65000.000 AS Decimal(12, 3)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (10, N'4', 1, 0, 0, N'Сайт и приложение для любителей уличной пиццы:

Поиск по стилю (неаполитанская, нью-йоркская, на тонком тесте).

Таймер свежести – показ, как давно приготовили пиццу.

Раздел «Пицца-арт» с фото необычных вариантов.

Опция «Собери пиццу» с доставкой.

Десктопная версия поможет пекарням управлять поставками и предзаказами.', N' ', CAST(N'2025-01-05T00:00:00.000' AS DateTime), N'Согласование', 1, CAST(49000.000 AS Decimal(12, 3)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (64, N'2', 1, 1, 1, N'Чеккккк


фаф в
ФЫВ


ФЫВаы', N'', CAST(N'2025-04-11T23:53:39.820' AS DateTime), N'Новый', 0, CAST(150000.000 AS Decimal(12, 3)), 0, 0, NULL, NULL, -1)
GO
SET IDENTITY_INSERT [dbo].[Заказы] OFF
GO
SET IDENTITY_INSERT [dbo].[ИсторияВосстановленияПароля] ON 
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (1, 5, N'wpdtf@vk.com', 5544, CAST(N'2025-04-12T15:23:41.740' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (2, 5, N'wpdtf@vk.com', 4395, CAST(N'2025-04-12T15:32:53.430' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (3, 5, N'wpdtf@vk.com', 13555, CAST(N'2025-04-12T16:05:33.040' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (4, 5, N'wpdtf@vk.com', 10465, CAST(N'2025-04-12T16:11:20.217' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (5, 5, N'wpdtf@vk.com', 9121, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (6, 5, N'wpdtf@vk.com', 3261, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (7, 5, N'wpdtf@vk.com', 10206, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (8, 5, N'wpdtf@vk.com', 14281, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (9, 5, N'wpdtf@vk.com', 5091, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (10, 5, N'wpdtf@vk.com', 172, CAST(N'2025-04-12T16:24:21.323' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ИсторияВосстановленияПароля] OFF
GO
SET IDENTITY_INSERT [dbo].[Клиенты] ON 
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (1, N'string', N'string', N'string', CAST(N'2025-04-05T18:56:27.903' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (2, N'', N'', N'', CAST(N'2025-04-06T11:47:28.340' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (3, N'string', N'string', N'string', CAST(N'2025-04-06T11:49:21.973' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (4, N'Сема', N'Семен', N'9038856255', CAST(N'2025-04-07T23:40:43.883' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (5, N'Саяпин', N'Дмитрий', N'9038856255', CAST(N'2025-04-08T22:53:02.137' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Клиенты] OFF
GO
SET IDENTITY_INSERT [dbo].[Пользователи] ON 
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (1, 1, N'Клиент', N'string', N'string')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (2, 2, N'Клиент', N'', N'')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (3, 3, N'Клиент', N'string2', N'string')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (4, 4, N'Клиент', N'wpdtf@adadas.ru', N'aIASGF&*AFG(a8sfh0as=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (5, 5, N'Клиент', N'wpdtf@vk.com', N'NNLaNBqO+O0BOx0gDZwdrq3CcgFS49irayp4Jow/SAg=')
GO
SET IDENTITY_INSERT [dbo].[Пользователи] OFF
GO
SET IDENTITY_INSERT [dbo].[Сотрудники] ON 
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (1, N'Петров', N'Василий', N'РазработчикМП', N'9038856255', CAST(N'2024-01-02T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Сотрудники] OFF
GO
SET IDENTITY_INSERT [dbo].[ЧатПоЗаказам] ON 
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (1, 4, -1, 2, N'Чек', CAST(N'2025-04-10T00:06:42.670' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (2, 4, -1, 2, N'Еще чек', CAST(N'2025-04-11T23:04:32.620' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (3, 4, 1, -1, N'Добрый день! У Вас все хорошо?', CAST(N'2025-04-11T23:06:53.027' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (4, 4, -1, 2, N'А чо', CAST(N'2025-04-11T23:07:18.190' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (5, 4, -1, 2, N'😄', CAST(N'2025-04-11T23:11:29.360' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (6, 4, -1, 2, N'd
d
D
d
d
d
d
d', CAST(N'2025-04-11T23:30:54.393' AS DateTime))
GO
INSERT [dbo].[ЧатПоЗаказам] ([ИдСообщения], [ИдЗаказа], [ИдСотрудника], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (7, 4, -1, 2, N'1
2
3
4', CAST(N'2025-04-11T23:31:57.550' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ЧатПоЗаказам] OFF
GO
ALTER TABLE [dbo].[Заказы] ADD  DEFAULT ((0)) FOR [ВиделКлиент]
GO
ALTER TABLE [dbo].[Заказы] ADD  DEFAULT ((0)) FOR [ВиделСотрудник]
GO
ALTER TABLE [dbo].[Заказы] ADD  CONSTRAINT [DF_Заказы_Оценка]  DEFAULT ((-1)) FOR [Оценка]
GO
ALTER TABLE [dbo].[Заказы]  WITH CHECK ADD CHECK  (([Цена]>(0)))
GO
ALTER TABLE [dbo].[Пользователи]  WITH CHECK ADD CHECK  (([ТипИсточника]=N'Сотрудник' OR [ТипИсточника]=N'Клиент'))
GO
/****** Object:  StoredProcedure [dbo].[Авторизация]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Авторизация]
@login as nvarchar(250)
,@password as nvarchar(250)
as 
begin

DECLARE @Ид AS INT, @isEmployee as BIT

SELECT @Ид = u.ИдИсточника, @isEmployee = IIF(u.ТипИсточника = N'Клиент', 0 ,1)
FROM dbo.Пользователи as u
WHERE u.Логин = @login AND u.Пароль = @password

IF @isEmployee = 1
	SELECT s.ИдСотрудника as idUser, s.Роль as Position
	FROM dbo.Сотрудники as s
	WHERE s.ИдСотрудника = @Ид
ELSE
	SELECT k.ИдКлиента as idUser, N'' as Position
	FROM dbo.Клиенты as k
	WHERE k.ИдКлиента = @Ид
end
GO
/****** Object:  StoredProcedure [dbo].[ЗаказыКлиента]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ЗаказыКлиента]
@Ид as INT
as 
begin

SELECT z.ИдЗаказа AS Id, 
	   z.ОписаниеКлиента AS [Description], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделКлиент as IsVisible,
	   z.Оценка AS Score
FROM dbo.Заказы as z
WHERE z.ИдКлиента = @Ид
ORDER BY IIF(z.Статус NOT IN (N'Принят'), z.Приоритет, 0)
DESC, CASE z.Статус
WHEN N'Новый' THEN 1
WHEN N'Проверка' THEN 4
WHEN N'Оценка' THEN 5
WHEN N'Согласование' THEN 2
WHEN N'Разработка' THEN 6
WHEN N'Приемка' THEN 7
WHEN N'Запуск' THEN 3
WHEN N'Готов' THEN 8
WHEN N'Уточнение деталей' THEN 0
END ASC

end
GO
/****** Object:  StoredProcedure [dbo].[ЗаказыСотрудника]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ЗаказыСотрудника]
@Ид as INT
as 
begin

DECLARE @isWin AS BIT = 0, @isMp AS BIT = 0, @isSite AS BIT = 0

SELECT @isWin = IIF(s.Роль = N'Разработчик ПО', 1, 0), 
       @isMp = IIF(s.Роль = N'Разработчик МП', 1, 0), 
	   @isSite = IIF(s.Роль = N'Верстальщик', 1, 0)
FROM dbo.Сотрудники as s
WHERE s.ИдСотрудника = @Ид

SELECT z.ИдЗаказа AS Id, 
	   z.ОписаниеКлиента AS [Description], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.Оценка AS Score
FROM dbo.Заказы as z
WHERE (z.КомпьютерноеПриложение = @isWin OR z.МобильноеПриложение = @isMp OR z.БраузерноеПриложение = @isSite) AND z.Статус IN (N'Оценка', N'Разработка', N'Запуск')
ORDER BY Приоритет DESC, CASE z.Статус
WHEN N'Новый' THEN 1
WHEN N'Проверка' THEN 4
WHEN N'Оценка' THEN 5
WHEN N'Согласование' THEN 2
WHEN N'Разработка' THEN 6
WHEN N'Приемка' THEN 7
WHEN N'Запуск' THEN 3
WHEN N'Готов' THEN 8
WHEN N'Уточнение деталей' THEN 0
END ASC

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьПароль]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьПароль]
@Почта as nvarchar(250)
,@password as nvarchar(250)
as 
begin

UPDATE p set p.Пароль = @password
FROM dbo.Пользователи as p
WHERE p.Логин = @Почта

end
GO
/****** Object:  StoredProcedure [dbo].[ОтправитьСообщениеКлиенту]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтправитьСообщениеКлиенту]
@ИдСотрудника as INT, @ИдЗаказа as INT, @Текст as NVARCHAR(MAX)
as 
begin

UPDATE z SET z.ВиделКлиент = 1
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @ИдЗаказа

insert into dbo.ЧатПоЗаказам
values (@ИдЗаказа, @ИдСотрудника, -1, @Текст, GETDATE())

end
GO
/****** Object:  StoredProcedure [dbo].[ОтправитьСообщениеСотруднику]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтправитьСообщениеСотруднику]
@ИдКлиент as INT, @ИдЗаказа as INT, @Текст as NVARCHAR(MAX)
as 
begin

UPDATE z SET z.ВиделСотрудник = 1
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @ИдЗаказа

insert into dbo.ЧатПоЗаказам
values (@ИдЗаказа, -1, @ИдКлиент, @Текст, GETDATE())

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучениеЗаказаКлиента]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучениеЗаказаКлиента]
@Ид as INT
as 
begin

SELECT z.ИдЗаказа AS Id, 
	   z.ОписаниеКлиента AS [Description], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделКлиент as IsVisible
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучитьСообщение]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучитьСообщение]
@Ид as INT
as 
begin
DECLARE @date as datetime, @idOrder as int

SELECT @idOrder = chat.ИдЗаказа
FROM dbo.ЧатПоЗаказам as chat
where chat.ИдСообщения = @Ид

SELECT @date = ISNULL(z.КогдаВиделСотрудник, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @idOrder

SELECT chat.ИдСообщения as IdMessage, chat.Сообщение AS TextMessage, chat.ДатаОтправки as DateSendMessage, ISNULL(CONCAT(s.Фамилия, N' ', LEFT(s.Имя, 1), N'.'), N'') as NameCompanion, CAST(iif(chat.ДатаОтправки < @date, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатПоЗаказам as chat
	LEFT JOIN dbo.Сотрудники AS s ON chat.ИдСотрудника = s.ИдСотрудника
where chat.ИдСообщения = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПоставитьОценкуЗаказу]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПоставитьОценкуЗаказу]
@Ид as INT, @Оценка AS INT
as 
begin

UPDATE z SET z.Оценка = @Оценка
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаКлиента @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПроверитьКод]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПроверитьКод]
@Почта as nvarchar(250), @Код AS INT
as 
begin

DECLARE @ИдКлиента as int, @isSuccess as bit = 0

SELECT @ИдКлиента = p.ИдИсточника
FROM dbo.Пользователи as p
where p.Логин = @Почта and p.ТипИсточника = N'Клиент'

SELECT @isSuccess = 1
FROM dbo.ИсторияВосстановленияПароля as hst
WHERE hst.Почта = @Почта AND hst.ОтправленныйКод = @Код and hst.ДатаОтправки > dateadd(minute, -5, getdate())

SELECT @isSuccess as isSuccess

end
GO
/****** Object:  StoredProcedure [dbo].[ПросмотретьСообщенияПоЗаказуКлиенту]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПросмотретьСообщенияПоЗаказуКлиенту]
@Ид as INT
as 
begin

DECLARE @lastUpdate AS DATETIME

SELECT @lastUpdate = ISNULL(z.КогдаВиделСотрудник, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

UPDATE z SET z.ВиделКлиент = 0, КогдаВиделКлиент = getdate()
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

SELECT chat.ИдСообщения as IdMessage, chat.Сообщение AS TextMessage, chat.ДатаОтправки as DateSendMessage, ISNULL(s.Фамилия + N' ' + LEFT(s.Имя, 1) + N'.', N'') as NameCompanion, CAST(iif(chat.ДатаОтправки < @lastUpdate, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатПоЗаказам as chat
	LEFT JOIN dbo.Сотрудники AS s ON chat.ИдСотрудника = s.ИдСотрудника
where chat.ИдЗаказа = @Ид
ORDER BY chat.ДатаОтправки DESC

end
GO
/****** Object:  StoredProcedure [dbo].[Регистрация]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Регистрация]
@login as nvarchar(250)
,@password as nvarchar(250)
,@lastName nvarchar(50)
,@firstName nvarchar(50)
,@phone nvarchar(10)
as 
begin

IF EXISTS (SELECT 1
	       FROM dbo.Пользователи as u
		   WHERE u.Логин = @login)
	THROW 50001, 'Пользователь с таким логином уже существует', 1;

DECLARE @Ид AS INT

INSERT INTO dbo.Клиенты (Фамилия, Имя, Телефон, ДатаРегистрации)
VALUES (@lastName, @firstName, @phone, GETDATE())

SET @Ид = SCOPE_IDENTITY()

INSERT INTO dbo.Пользователи(ИдИсточника, ТипИсточника, Логин, Пароль)
VALUES(@Ид, N'Клиент', @login, @password)

end
GO
/****** Object:  StoredProcedure [dbo].[СоздатьЗадание]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[СоздатьЗадание]
@ИдКлиента as INT, @Текст as NVARCHAR(MAX)
as 
begin

INSERT INTO dbo.Заказы (ИдКлиента, ОписаниеКлиента, ДатаСоздания, Статус, МобильноеПриложение, КомпьютерноеПриложение, БраузерноеПриложение, ОписаниеСотрудника, Приоритет, Цена)
VALUEs (@ИдКлиента, @Текст, getdate(), N'Новый', 1, 1, 1, N'', 0, 150000)

end
GO
/****** Object:  StoredProcedure [dbo].[СоздатьКодДляВосстановления]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[СоздатьКодДляВосстановления]
@Почта as nvarchar(250)
as 
begin

DECLARE @ИдКлиента as int, @Код as int = rand()*15000

SELECT @ИдКлиента = p.ИдИсточника
FROM dbo.Пользователи as p
where p.Логин = @Почта and p.ТипИсточника = N'Клиент'

IF @ИдКлиента is null
	THROW 50001, 'Пользователя с таким логином не существует', 1;

UPDATE hst SET hst.ДатаОтправки = '20250101'
FROM dbo.ИсторияВосстановленияПароля as hst
WHERE hst.Почта = @Почта AND hst.ДатаОтправки > dateadd(minute, -5, getdate())

insert into dbo.ИсторияВосстановленияПароля (ИдКлиента, Почта, ОтправленныйКод, ДатаОтправки)
values(@ИдКлиента, @Почта, @Код, getdate())

SELECT @Код as Code
end
GO
/****** Object:  StoredProcedure [dbo].[СоздатьОбращениеКлиенту]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[СоздатьОбращениеКлиенту]
@Ид as INT
as 
begin

UPDATE z SET z.Статус = N'Уточнение деталей'
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаКлиента @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ТолкнутьЗаказКлиенту]    Script Date: 12.04.2025 17:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ТолкнутьЗаказКлиенту]
@Ид as INT
as 
begin

UPDATE z SET z.Статус = IIF(z.Статус = N'Согласование', N'Разработка', N'Запуск')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаКлиента @Ид = @Ид

end
GO
