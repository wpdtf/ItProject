DROP DATABASE IF EXISTS [ИтЗаказы]
CREATE DATABASE [ИтЗаказы]
USE [ИтЗаказы]
GO
/****** Object:  Table [dbo].[Заказы]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказы](
	[ИдЗаказа] [int] IDENTITY(1,1) NOT NULL,
	[ИдКлиента] [int] NOT NULL,
	[КомпьютерноеПриложение] [bit] NOT NULL,
	[БраузерноеПриложение] [bit] NOT NULL,
	[МобильноеПриложение] [bit] NOT NULL,
	[ОписаниеКлиента] [nvarchar](max) NOT NULL,
	[ОписаниеСотрудника] [nvarchar](max) NOT NULL,
	[ДатаСоздания] [datetime] NOT NULL,
	[Статус] [nvarchar](50) NOT NULL,
	[Приоритет] [smallint] NOT NULL,
	[Цена] [decimal](12, 2) NULL,
	[ВиделКлиент] [bit] NOT NULL,
	[ВиделСотрудник] [bit] NOT NULL,
	[КогдаВиделКлиент] [datetime] NULL,
	[КогдаВиделСотрудник] [datetime] NULL,
	[Оценка] [int] NULL,
 CONSTRAINT [PK__Заказы__6386FC75B8728A27] PRIMARY KEY CLUSTERED 
(
	[ИдЗаказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИсторияВосстановленияПароля]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  Table [dbo].[Клиенты]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  Table [dbo].[Пользователи]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  Table [dbo].[СообщенияКлиента]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СообщенияКлиента](
	[ИдСообщения] [int] IDENTITY(1,1) NOT NULL,
	[ИдЧата] [int] NOT NULL,
	[ИдКлиента] [int] NOT NULL,
	[Сообщение] [nvarchar](max) NOT NULL,
	[ДатаОтправки] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдСообщения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СообщенияСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СообщенияСотрудника](
	[ИдСообщения] [int] IDENTITY(1,1) NOT NULL,
	[ИдЧата] [int] NOT NULL,
	[ИдСотрудника] [int] NOT NULL,
	[Сообщение] [nvarchar](max) NOT NULL,
	[ДатаОтправки] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдСообщения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудники]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  Table [dbo].[ЧатыПоЗаказам]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ЧатыПоЗаказам](
	[ИдЧата] [int] IDENTITY(1,1) NOT NULL,
	[ИдЗаказа] [int] NOT NULL,
	[ДатаСоздания] [datetime] NOT NULL,
	[ЗакрытЛиЧат] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ИдЧата] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Заказы] ON 
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (3, 5, 1, 0, 1, N'Сайт и десктопное приложение для любителей уличной еды, где можно найти лучшие места с шаурмой, бургерами, пиццей и другими перекусами. Пользователи смогут:
Искать заведения по рейтингу, кухне или местоположению.
Читать отзывы и смотреть фото блюд.
Бронировать еду заранее или заказывать доставку.
Получать персонализированные рекомендации.
Для владельцев точек – кабинет с аналитикой, управлением меню и акциями. Десктопная версия добавит удобные инструменты для работы с заказами и статистикой.', N'ferger', CAST(N'2025-01-01T00:00:00.000' AS DateTime), N'Проверка', 0, CAST(45000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (4, 5, 0, 1, 1, N'Сервис помогает находить мобильные точки уличной еды в реальном времени. Особенности:
Интерактивная карта с GPS-трекингом фудтраков.
Уведомления о передвижении любимых продавцов.
Система лояльности с кэшбэком за отзывы.
Возможность предзаказа через приложение.
Десктопная версия будет полезна организаторам фестивалей и владельцам фудтраков для планирования маршрутов и управления расписанием.', N'2434


Фывфыв', CAST(N'2025-01-02T00:00:00.000' AS DateTime), N'Готов', 0, CAST(85000.00 AS Decimal(12, 2)), 1, 0, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (6, 5, 1, 1, 0, N'Специализированный сервис для ценителей шаурмы:
База данных с рейтингами по соусу, мясу и свежести лаваша.
Фильтры по цене, халяльности и веган-опциям.
Раздел с секретными рецептами от поваров.
Возможность голосовать за лучшую точку в городе.
Десктопная версия добавит статистику продаж для владельцев и инструменты продвижения.', N' ', CAST(N'2024-12-10T00:00:00.000' AS DateTime), N'Готов', 5, CAST(45000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, 1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (8, 5, 1, 1, 1, N'Платформа для фанатов бургеров:
Каталог заведений с детальными описаниями ингредиентов.
Возможность создавать свой бургер и заказывать его в партнерских точках.
Акции и челленджи (например, «Съешь 10 бургеров – получи мерч»).
Live-трансляции с кухонь ресторанов.
Десктоп-версия даст ресторанам CRM-систему для работы с клиентами.', N'vbыфвфыф', CAST(N'2025-01-03T00:00:00.000' AS DateTime), N'Приемка', 1, CAST(65000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (10, 5, 1, 0, 0, N'Сайт и приложение для любителей уличной пиццы:
Поиск по стилю (неаполитанская, нью-йоркская, на тонком тесте).
Таймер свежести – показ, как давно приготовили пиццу.
Раздел «Пицца-арт» с фото необычных вариантов.
Опция «Собери пиццу» с доставкой.
Десктопная версия поможет пекарням управлять поставками и предзаказами.', N'Проверка', CAST(N'2025-01-05T00:00:00.000' AS DateTime), N'Согласование', 1, CAST(49000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (64, 5, 1, 1, 0, N'Чеккккк


фаф в
ФЫВ


ФЫВаы', N'', CAST(N'2025-04-11T23:53:39.820' AS DateTime), N'Новый', 0, CAST(240000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (65, 7, 1, 0, 1, N'Хочу четкий проект
Реально крутой', N'плова илпвоиалпови алпилвао иплво иалв опивао илвпоивлаопиваиоплнужен разносторо
ыв
Чек, того, сюда', CAST(N'2025-04-18T12:17:05.523' AS DateTime), N'Готов', 0, CAST(450000.00 AS Decimal(12, 2)), 0, 0, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (66, 8, 0, 1, 0, N'Хочу большой и очень круто проект!', N'Реально требуется большой и крутой проект

Мне потребуется 40 часов', CAST(N'2025-04-19T12:55:49.620' AS DateTime), N'Готов', 6, CAST(50000.00 AS Decimal(12, 2)), 0, 0, CAST(N'2025-04-19T22:43:50.183' AS DateTime), CAST(N'2025-04-19T22:49:26.850' AS DateTime), 3)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (67, 9, 0, 1, 1, N'Мы хотим большой сайт, с крутым мобильным приложением', N'Хочет сайт на тему продажи еды и воды, с мобильным приложением

Что мне надо 150 часов
А мне надо 200 часов

Все сделал', CAST(N'2025-04-19T13:56:47.607' AS DateTime), N'Готов', 0, CAST(200000.00 AS Decimal(12, 2)), 1, 0, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime), 3)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (68, 10, 0, 1, 1, N'Хотим большой сайт, и мобильное приложение', N'тест
нам нужно 15000 часов, и много средств', CAST(N'2025-04-19T14:16:56.723' AS DateTime), N'Приемка', 4, CAST(800000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (69, 12, 0, 1, 0, N'Тест', N'Тест
Мне надо 150 ч', CAST(N'2025-04-19T14:35:05.073' AS DateTime), N'Согласование', 5, CAST(100000.00 AS Decimal(12, 2)), 0, 0, NULL, NULL, -1)
GO
INSERT [dbo].[Заказы] ([ИдЗаказа], [ИдКлиента], [КомпьютерноеПриложение], [БраузерноеПриложение], [МобильноеПриложение], [ОписаниеКлиента], [ОписаниеСотрудника], [ДатаСоздания], [Статус], [Приоритет], [Цена], [ВиделКлиент], [ВиделСотрудник], [КогдаВиделКлиент], [КогдаВиделСотрудник], [Оценка]) VALUES (70, 13, 0, 1, 1, N'Тест', N'Какое то описание
то се третье десятое', CAST(N'2025-04-21T16:01:11.857' AS DateTime), N'Уточнение деталей', 0, CAST(250000.00 AS Decimal(12, 2)), 0, 0, CAST(N'2025-04-24T09:11:25.923' AS DateTime), CAST(N'2025-04-24T09:11:19.577' AS DateTime), 1)
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
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (11, 7, N'lindsysalmon@ptct.net', 4267, CAST(N'2025-04-18T12:14:33.823' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (12, 8, N'hujnoz@foxcofe.ru', 4765, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (13, 8, N'hujnoz@foxcofe.ru', 4061, CAST(N'2025-04-19T12:54:14.793' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (14, 9, N'genna821@ptct.net', 7148, CAST(N'2025-04-19T13:55:27.940' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (15, 10, N'drona638@ptct.net', 7880, CAST(N'2025-04-19T14:16:03.683' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (16, 11, N'cnstpw3141@atminmail.com', 3751, CAST(N'2025-04-19T14:31:44.787' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (17, 12, N'apricot6970@ptct.net', 792, CAST(N'2025-04-19T14:34:06.947' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (18, 8, N'wpdtf@vk.com', 7182, CAST(N'2025-04-19T22:43:12.227' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (19, 13, N'8charisse@ptct.net', 10964, CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ИсторияВосстановленияПароля] ([ИдИстории], [ИдКлиента], [Почта], [ОтправленныйКод], [ДатаОтправки]) VALUES (20, 13, N'8charisse@ptct.net', 8512, CAST(N'2025-04-21T16:00:19.330' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ИсторияВосстановленияПароля] OFF
GO
SET IDENTITY_INSERT [dbo].[Клиенты] ON 
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (4, N'Сема', N'Семен', N'9038856255', CAST(N'2025-04-07T23:40:43.883' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (5, N'Васюнок', N'Дмитрий', N'9038856255', CAST(N'2025-04-08T22:53:02.137' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (6, N'Серго', N'Сергей', N'9054589875', CAST(N'2025-04-18T12:11:36.823' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (7, N'Проверка', N'Почты', N'9054568795', CAST(N'2025-04-18T12:13:10.267' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (8, N'Акаций', N'Петр', N'9038794598', CAST(N'2025-04-19T12:53:05.350' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (9, N'Буков', N'Генадий', N'9856324587', CAST(N'2025-04-19T13:55:20.200' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (10, N'Дронавидце', N'Иван', N'9876541238', CAST(N'2025-04-19T14:15:54.180' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (11, N'Велий', N'Антон', N'9874561254', CAST(N'2025-04-19T14:31:36.413' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (12, N'Априкот', N'Кот', N'9874562545', CAST(N'2025-04-19T14:34:00.627' AS DateTime))
GO
INSERT [dbo].[Клиенты] ([ИдКлиента], [Фамилия], [Имя], [Телефон], [ДатаРегистрации]) VALUES (13, N'Проверка', N'Такая', N'9874561254', CAST(N'2025-04-21T15:59:48.567' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Клиенты] OFF
GO
SET IDENTITY_INSERT [dbo].[Пользователи] ON 
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (4, 4, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (5, 5, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (6, 3, N'Сотрудник', N'check@vk.com', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (7, 1, N'Сотрудник', N'ttttt@sa.com', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (8, 2, N'Сотрудник', N'rawrawwww@sa.com', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (9, 6, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (10, 7, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (11, 4, N'Сотрудник', N'vasya@gm.com', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (12, 5, N'Сотрудник', N'pasha@gm.com', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (13, 8, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (14, 9, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (15, 10, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (16, 11, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (17, 12, N'Клиент', N'jewelleblack@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
INSERT [dbo].[Пользователи] ([ИдПользователя], [ИдИсточника], [ТипИсточника], [Логин], [Пароль]) VALUES (18, 13, N'Клиент', N'8charisse@ptct.net', N'WihROcXYY2t/6UlcDn7M2TAJThmEpqMPehfVJNiWlWs=')
GO
SET IDENTITY_INSERT [dbo].[Пользователи] OFF
GO
SET IDENTITY_INSERT [dbo].[СообщенияКлиента] ON 
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (1, 1, 5, N'Чек', CAST(N'2025-04-10T00:06:42.670' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (2, 1, 5, N'Еще чек', CAST(N'2025-04-11T23:04:32.620' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (3, 1, 5, N'А чо', CAST(N'2025-04-11T23:07:18.190' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (4, 1, 5, N'😄', CAST(N'2025-04-11T23:11:29.360' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (5, 1, 5, N'd
d
D
d
d
d
d
d', CAST(N'2025-04-11T23:30:54.393' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (6, 1, 5, N'1
2
3
4', CAST(N'2025-04-11T23:31:57.550' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (7, 1, 5, N'хай', CAST(N'2025-04-13T16:40:09.517' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (8, 2, 8, N'bnvbvnvb', CAST(N'2025-04-19T13:39:43.120' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (9, 2, 8, N'fgbvcvbcv', CAST(N'2025-04-19T13:39:46.197' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (10, 2, 8, N'cvbcvbcv', CAST(N'2025-04-19T13:39:47.450' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (11, 2, 8, N'gfdgdf', CAST(N'2025-04-19T13:45:22.493' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (12, 2, 8, N'Чек', CAST(N'2025-04-19T22:38:11.530' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (13, 3, 9, N'Клиенты жалуются на отсутствие чего нибудь', CAST(N'2025-04-19T14:24:49.653' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (14, 4, 13, N'Не работает 3 кнопка', CAST(N'2025-04-21T16:14:25.087' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (15, 4, 13, N'Хорошо, спасибо! Жду!', CAST(N'2025-04-21T16:15:32.450' AS DateTime))
GO
INSERT [dbo].[СообщенияКлиента] ([ИдСообщения], [ИдЧата], [ИдКлиента], [Сообщение], [ДатаОтправки]) VALUES (16, 5, 13, N'Чек', CAST(N'2025-04-24T08:53:15.290' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[СообщенияКлиента] OFF
GO
SET IDENTITY_INSERT [dbo].[СообщенияСотрудника] ON 
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (1, 2, 5, N'hkjhkhj', CAST(N'2025-04-19T13:44:49.100' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (2, 2, 3, N'ролдолро', CAST(N'2025-04-19T22:38:34.250' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (3, 3, 5, N'Сейчас посмотрим', CAST(N'2025-04-19T14:25:40.200' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (4, 3, 5, N'Да, нашли, добавили', CAST(N'2025-04-19T14:26:05.837' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (5, 4, 5, N'Сейчас посмотрим', CAST(N'2025-04-21T16:15:05.377' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (6, 4, 5, N'Все проверил, небольшой ошибка с доступами у некоторых клиентов, все исправили', CAST(N'2025-04-21T16:16:00.680' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (7, 5, 5, N'fghfghfg', CAST(N'2025-04-24T09:09:12.030' AS DateTime))
GO
INSERT [dbo].[СообщенияСотрудника] ([ИдСообщения], [ИдЧата], [ИдСотрудника], [Сообщение], [ДатаОтправки]) VALUES (8, 5, 5, N'ujjj', CAST(N'2025-04-24T09:11:19.570' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[СообщенияСотрудника] OFF
GO
SET IDENTITY_INSERT [dbo].[Сотрудники] ON 
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (1, N'Петров', N'Василий', N'Разработчик МП', N'9038856255', CAST(N'2024-01-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (2, N'Самойлова', N'Мария', N'Менеджер', N'9038856255', CAST(N'2024-01-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (3, N'Работы', N'Проверка', N'Админ', N'9998887755', CAST(N'2019-01-31T23:57:59.670' AS DateTime))
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (4, N'Иван', N'Соколов', N'Разработчик ПО', N'9984561254', CAST(N'2019-01-30T23:57:59.670' AS DateTime))
GO
INSERT [dbo].[Сотрудники] ([ИдСотрудника], [Фамилия], [Имя], [Роль], [Телефон], [ДатаПриема]) VALUES (5, N'Павел', N'Сербухов', N'Верстальщик', N'9856587485', CAST(N'2009-07-10T23:57:59.670' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Сотрудники] OFF
GO
SET IDENTITY_INSERT [dbo].[ЧатыПоЗаказам] ON 
GO
INSERT [dbo].[ЧатыПоЗаказам] ([ИдЧата], [ИдЗаказа], [ДатаСоздания], [ЗакрытЛиЧат]) VALUES (1, 4, CAST(N'2025-04-10T00:06:42.670' AS DateTime), 1)
GO
INSERT [dbo].[ЧатыПоЗаказам] ([ИдЧата], [ИдЗаказа], [ДатаСоздания], [ЗакрытЛиЧат]) VALUES (2, 66, CAST(N'2025-04-19T13:39:43.120' AS DateTime), 1)
GO
INSERT [dbo].[ЧатыПоЗаказам] ([ИдЧата], [ИдЗаказа], [ДатаСоздания], [ЗакрытЛиЧат]) VALUES (3, 67, CAST(N'2025-04-19T14:24:49.653' AS DateTime), 1)
GO
INSERT [dbo].[ЧатыПоЗаказам] ([ИдЧата], [ИдЗаказа], [ДатаСоздания], [ЗакрытЛиЧат]) VALUES (4, 70, CAST(N'2025-04-21T16:14:25.087' AS DateTime), 1)
GO
INSERT [dbo].[ЧатыПоЗаказам] ([ИдЧата], [ИдЗаказа], [ДатаСоздания], [ЗакрытЛиЧат]) VALUES (5, 70, CAST(N'2025-04-24T08:53:02.663' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[ЧатыПоЗаказам] OFF
GO
ALTER TABLE [dbo].[Заказы] ADD  CONSTRAINT [DF__Заказы__ВиделКли__01142BA1]  DEFAULT ((0)) FOR [ВиделКлиент]
GO
ALTER TABLE [dbo].[Заказы] ADD  CONSTRAINT [DF__Заказы__ВиделСот__02084FDA]  DEFAULT ((0)) FOR [ВиделСотрудник]
GO
ALTER TABLE [dbo].[Заказы] ADD  CONSTRAINT [DF_Заказы_Оценка]  DEFAULT ((-1)) FOR [Оценка]
GO
ALTER TABLE [dbo].[СообщенияКлиента] ADD  DEFAULT (getdate()) FOR [ДатаОтправки]
GO
ALTER TABLE [dbo].[СообщенияСотрудника] ADD  DEFAULT (getdate()) FOR [ДатаОтправки]
GO
ALTER TABLE [dbo].[Заказы]  WITH CHECK ADD  CONSTRAINT [FK_Заказы_Клиенты] FOREIGN KEY([ИдКлиента])
REFERENCES [dbo].[Клиенты] ([ИдКлиента])
GO
ALTER TABLE [dbo].[Заказы] CHECK CONSTRAINT [FK_Заказы_Клиенты]
GO
ALTER TABLE [dbo].[ИсторияВосстановленияПароля]  WITH CHECK ADD  CONSTRAINT [FK_ИсторияВосстановленияПароля_Клиенты] FOREIGN KEY([ИдКлиента])
REFERENCES [dbo].[Клиенты] ([ИдКлиента])
GO
ALTER TABLE [dbo].[ИсторияВосстановленияПароля] CHECK CONSTRAINT [FK_ИсторияВосстановленияПароля_Клиенты]
GO
ALTER TABLE [dbo].[СообщенияКлиента]  WITH CHECK ADD  CONSTRAINT [FK_СообщенияКлиента_Клиенты] FOREIGN KEY([ИдКлиента])
REFERENCES [dbo].[Клиенты] ([ИдКлиента])
GO
ALTER TABLE [dbo].[СообщенияКлиента] CHECK CONSTRAINT [FK_СообщенияКлиента_Клиенты]
GO
ALTER TABLE [dbo].[СообщенияКлиента]  WITH CHECK ADD  CONSTRAINT [FK_СообщенияКлиента_ЧатыПоЗаказам] FOREIGN KEY([ИдЧата])
REFERENCES [dbo].[ЧатыПоЗаказам] ([ИдЧата])
GO
ALTER TABLE [dbo].[СообщенияКлиента] CHECK CONSTRAINT [FK_СообщенияКлиента_ЧатыПоЗаказам]
GO
ALTER TABLE [dbo].[СообщенияСотрудника]  WITH CHECK ADD  CONSTRAINT [FK_СообщенияСотрудника_Сотрудники] FOREIGN KEY([ИдСотрудника])
REFERENCES [dbo].[Сотрудники] ([ИдСотрудника])
GO
ALTER TABLE [dbo].[СообщенияСотрудника] CHECK CONSTRAINT [FK_СообщенияСотрудника_Сотрудники]
GO
ALTER TABLE [dbo].[СообщенияСотрудника]  WITH CHECK ADD  CONSTRAINT [FK_СообщенияСотрудника_ЧатыПоЗаказам] FOREIGN KEY([ИдЧата])
REFERENCES [dbo].[ЧатыПоЗаказам] ([ИдЧата])
GO
ALTER TABLE [dbo].[СообщенияСотрудника] CHECK CONSTRAINT [FK_СообщенияСотрудника_ЧатыПоЗаказам]
GO
ALTER TABLE [dbo].[ЧатыПоЗаказам]  WITH CHECK ADD  CONSTRAINT [FK_ЧатыПоЗаказам_Заказы] FOREIGN KEY([ИдЗаказа])
REFERENCES [dbo].[Заказы] ([ИдЗаказа])
GO
ALTER TABLE [dbo].[ЧатыПоЗаказам] CHECK CONSTRAINT [FK_ЧатыПоЗаказам_Заказы]
GO
ALTER TABLE [dbo].[Заказы]  WITH CHECK ADD  CONSTRAINT [CK__Заказы__Цена__6E01572D] CHECK  (([Цена]>(0)))
GO
ALTER TABLE [dbo].[Заказы] CHECK CONSTRAINT [CK__Заказы__Цена__6E01572D]
GO
ALTER TABLE [dbo].[Пользователи]  WITH CHECK ADD CHECK  (([ТипИсточника]=N'Сотрудник' OR [ТипИсточника]=N'Клиент'))
GO
/****** Object:  StoredProcedure [dbo].[Авторизация]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ДобавлениеСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ДобавлениеСотрудника]
@Фамилия AS NVARCHAR(50), @Имя AS NVARCHAR(50), @Роль AS NVARCHAR(50), @Телефон AS NVARCHAR(50), @ДатаПриема AS DATETIME, @Логин AS NVARCHAR(250), @Пароль AS NVARCHAR(250)
as 
begin

DECLARE @Ид AS INT

INSERT INTO dbo.Сотрудники (Фамилия, Имя, Роль, Телефон, ДатаПриема)
VALUES (@Фамилия, @Имя, @Роль, @Телефон, @ДатаПриема)

SET @Ид = SCOPE_IDENTITY()

INSERT INTO dbo.Пользователи (ИдИсточника, ТипИсточника, Логин, Пароль)
VALUES (@Ид, N'Сотрудник', @Логин, @Пароль)

EXEC dbo.ПолучениеСотрудника @Ид = @Ид
end
GO
/****** Object:  StoredProcedure [dbo].[ЗаказыКлиента]    Script Date: 24.04.2025 9:24:48 ******/
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
	   z.ОписаниеСотрудника AS [DescriptionWorker], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделКлиент as IsVisible,
	   z.Оценка AS Score,
	   k.Телефон AS Phone,
	   z.Приоритет AS Prioritet,
	   CAST(ISNULL(chat.IsActive, 0) AS BIT) as IsActiveChat
FROM dbo.Заказы as z
	inner join dbo.Клиенты as k on k.ИдКлиента = z.ИдКлиента
	OUTER APPLY(SELECT 1 as IsActive FROM dbo.ЧатыПоЗаказам as CH WHERE CH.ИдЗаказа = z.ИдЗаказа AND ch.ЗакрытЛиЧат = 0) as chat
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
/****** Object:  StoredProcedure [dbo].[ЗаказыСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ЗаказыСотрудника]
@Ид as INT
as 
begin

DECLARE @isWin AS BIT = null, @isMp AS BIT = null, @isSite AS BIT = null, @isManager AS BIT = 0, @isFull AS BIT = 0

SELECT @isWin = IIF(s.Роль = N'Разработчик ПО', 1, null), 
       @isMp = IIF(s.Роль = N'Разработчик МП', 1, null), 
	   @isSite = IIF(s.Роль = N'Верстальщик', 1, null), 
	   @isManager = IIF(s.Роль = N'Менеджер', 1, 0), 
	   @isFull = IIF(s.Роль = N'Админ', 1, 0)
FROM dbo.Сотрудники as s
WHERE s.ИдСотрудника = @Ид

SELECT z.ИдЗаказа AS Id, 
	   z.ОписаниеКлиента AS [Description], 
	   z.ОписаниеСотрудника AS [DescriptionWorker], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделСотрудник as IsVisible,
	   z.Оценка AS Score,
	   k.Телефон AS Phone,
	   z.Приоритет AS Prioritet,
	   CAST(ISNULL(chat.IsActive, 0) AS BIT) as IsActiveChat
FROM dbo.Заказы as z
	inner join dbo.Клиенты as k on k.ИдКлиента = z.ИдКлиента
	OUTER APPLY(SELECT 1 as IsActive FROM dbo.ЧатыПоЗаказам as CH WHERE CH.ИдЗаказа = z.ИдЗаказа AND ch.ЗакрытЛиЧат = 0) as chat
WHERE ((z.КомпьютерноеПриложение = @isWin OR z.МобильноеПриложение = @isMp OR z.БраузерноеПриложение = @isSite) AND z.Статус IN (N'Проверка', N'Разработка', N'Запуск', N'Уточнение деталей') AND @isManager = 0)
	OR (@isManager = 1 AND z.Статус IN (N'Новый', N'Оценка')
	OR (@isFull = 1))
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
/****** Object:  StoredProcedure [dbo].[ЗакрытьОбращение]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ЗакрытьОбращение]
@Ид as INT
as 
begin
DECLARE @message as nvarchar(Max), @ИдЧата AS INT

UPDATE z SET z.КогдаВиделКлиент = 0, z.КогдаВиделСотрудник = 0, z.Статус = N'Готов'
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

SELECT @ИдЧата = ch.ИдЧата
FROM dbo.ЧатыПоЗаказам as ch
WHERE CH.ИдЗаказа = @Ид AND ch.ЗакрытЛиЧат = 0

UPDATE ch SET ch.ЗакрытЛиЧат = 1
FROM dbo.ЧатыПоЗаказам as ch
WHERE ch.ИдЧата = @ИдЧата

SELECT TOP 1 @message = chat.Сообщение
FROM dbo.СообщенияСотрудника as chat
WHERE chat.ИдЧата = @ИдЧата
ORDER BY chat.ИдСообщения DESC

SELECT p.Логин as Email, k.Фамилия + N' ' + LEFT(k.Имя, 1) + N'.' as [Name], @message as LastMessage
FROM dbo.Заказы as z
INNER JOIN dbo.Клиенты as k ON k.ИдКлиента = z.ИдКлиента
INNER JOIN dbo.Пользователи as p on p.ИдИсточника = k.ИдКлиента AND p.ТипИсточника = N'Клиент'
WHERE z.ИдЗаказа = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьКомментарийСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьКомментарийСотрудника]
@Ид as INT, @Комментарий AS NVARCHAR(MAX)
as 
begin

UPDATE z SET z.ОписаниеСотрудника = @Комментарий
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьНаправлениеМП]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьНаправлениеМП]
@Ид as INT, @why AS BIT
as 
begin

UPDATE z SET z.МобильноеПриложение = @why
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьНаправлениеПК]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьНаправлениеПК]
@Ид as INT, @why AS BIT
as 
begin

UPDATE z SET z.КомпьютерноеПриложение = @why
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьНаправлениеСайт]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьНаправлениеСайт]
@Ид as INT, @why AS BIT
as 
begin

UPDATE z SET z.БраузерноеПриложение = @why
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьПароль]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ОбновитьПриоритетЗаказа]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьПриоритетЗаказа]
@Ид as INT, @Приоритет AS INT
as 
begin

UPDATE z SET z.Приоритет = @Приоритет
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновитьЦенуЗаказа]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновитьЦенуЗаказа]
@Ид as INT, @Цена AS decimal(12, 2)
as 
begin

UPDATE z SET z.Цена = @Цена
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ОбновлениеПользователяСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновлениеПользователяСотрудника]
@Ид AS INT, @Логин AS NVARCHAR(250), @Пароль AS NVARCHAR(250)
as 
begin

UPDATE p SET p.Логин = @Логин, p.Пароль = @Пароль
FROM dbo.Пользователи as p
WHERE p.ИдИсточника = @Ид AND p.ТипИсточника = N'Сотрудник'

EXEC dbo.ПолучениеСотрудника @Ид = @Ид
end
GO
/****** Object:  StoredProcedure [dbo].[ОбновлениеСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОбновлениеСотрудника]
@Ид AS INT, @Фамилия AS NVARCHAR(50), @Имя AS NVARCHAR(50), @Роль AS NVARCHAR(50), @Телефон AS NVARCHAR(50), @ДатаПриема AS DATETIME
as 
begin

UPDATE s SET s.Фамилия = @Фамилия, s.Имя = @Имя, s.Роль = @Роль, s.Телефон = @Телефон, s.ДатаПриема = @ДатаПриема
FROM dbo.Сотрудники as s
WHERE s.ИдСотрудника = @Ид

EXEC dbo.ПолучениеСотрудника @Ид = @Ид
end
GO
/****** Object:  StoredProcedure [dbo].[ОтправитьСообщениеКлиенту]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтправитьСообщениеКлиенту]
@ИдСотрудника as INT, @ИдЗаказа as INT, @Текст as NVARCHAR(MAX)
as 
begin

DECLARE @ИдЧата AS INT

UPDATE z SET z.ВиделКлиент = 1
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @ИдЗаказа

SELECT @ИдЧата = ch.ИдЧата
FROM dbo.ЧатыПоЗаказам as ch
WHERE ch.ИдЗаказа = @ИдЗаказа

insert into dbo.СообщенияСотрудника (ИдЧата, ИдСотрудника, Сообщение, ДатаОтправки)
values (@ИдЧата, @ИдСотрудника, @Текст, GETDATE())

end
GO
/****** Object:  StoredProcedure [dbo].[ОтправитьСообщениеСотруднику]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтправитьСообщениеСотруднику]
@ИдКлиент as INT, @ИдЗаказа as INT, @Текст as NVARCHAR(MAX)
as 
begin

DECLARE @ИдЧата AS INT

UPDATE z SET z.ВиделСотрудник = 1
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @ИдЗаказа

SELECT @ИдЧата = ch.ИдЧата
FROM dbo.ЧатыПоЗаказам as ch
WHERE ch.ИдЗаказа = @ИдЗаказа

insert into dbo.СообщенияКлиента (ИдЧата, ИдКлиента, Сообщение, ДатаОтправки)
values (@ИдЧата, @ИдКлиент, @Текст, GETDATE())

end
GO
/****** Object:  StoredProcedure [dbo].[ОтчетОценки]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтчетОценки]
as 
begin

SELECT z.ИдЗаказа AS orderId, z.ИдКлиента AS clientId, z.БраузерноеПриложение as isSite, z.КомпьютерноеПриложение as isPC, z.МобильноеПриложение AS isMP, z.Приоритет as prioritet, z.ДатаСоздания as dateCreate, z.Оценка as score, z.Цена as price, k.Фамилия as firstName, k.Имя as lastName, k.Телефон as phone
FROM dbo.Заказы AS Z
INNER JOIN dbo.Клиенты AS K ON z.ИдКлиента = k.ИдКлиента
WHERE z.Статус = 'Готов'
ORDER BY z.Оценка

end
GO
/****** Object:  StoredProcedure [dbo].[ОтчетПродажи]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ОтчетПродажи]
as 
begin

SELECT CAST(z.ДатаСоздания AS DATE) as DateCheck, SUM(z.Цена) as MaxSum
FROM dbo.Заказы as Z
WHERE z.Статус = 'Готов'
GROUP BY CAST(z.ДатаСоздания AS DATE)

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучениеЗаказаКлиента]    Script Date: 24.04.2025 9:24:48 ******/
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
	   z.ОписаниеСотрудника AS [DescriptionWorker], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделКлиент as IsVisible,
	   z.Оценка AS Score,
	   k.Телефон AS Phone,
	   z.Приоритет AS Prioritet,
	   CAST(ISNULL(chat.IsActive, 0) AS BIT) as IsActiveChat
FROM dbo.Заказы as z
	inner join dbo.Клиенты as k on k.ИдКлиента = z.ИдКлиента
	OUTER APPLY(SELECT 1 as IsActive FROM dbo.ЧатыПоЗаказам as CH WHERE CH.ИдЗаказа = z.ИдЗаказа AND ch.ЗакрытЛиЧат = 0) as chat
WHERE z.ИдЗаказа = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучениеЗаказаСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучениеЗаказаСотрудника]
@Ид as INT
as 
begin

SELECT z.ИдЗаказа AS Id, 
	   z.ОписаниеКлиента AS [Description], 
	   z.ОписаниеСотрудника AS [DescriptionWorker], 
	   z.Статус AS [Status], 
	   z.КомпьютерноеПриложение AS isWin,
	   z.МобильноеПриложение AS isMp,
	   z.БраузерноеПриложение AS isSite,
	   z.ДатаСоздания AS DateCreate,
	   z.Цена as Price,
	   z.ВиделСотрудник as IsVisible,
	   z.Оценка AS Score,
	   k.Телефон AS Phone,
	   z.Приоритет AS Prioritet,
	   CAST(ISNULL(chat.IsActive, 0) AS BIT) as IsActiveChat
FROM dbo.Заказы as z
	inner join dbo.Клиенты as k on k.ИдКлиента = z.ИдКлиента
	OUTER APPLY(SELECT 1 as IsActive FROM dbo.ЧатыПоЗаказам as CH WHERE CH.ИдЗаказа = z.ИдЗаказа AND ch.ЗакрытЛиЧат = 0) as chat
WHERE z.ИдЗаказа = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучениеСотрудника]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучениеСотрудника]
@Ид as INT
as 
begin

SELECT s.ИдСотрудника as workerId, s.Фамилия as firstName, s.Имя as lastName, s.Роль as position, s.Телефон as phone, s.ДатаПриема as dateStart, p.Логин as [login], null as [password]
FROM dbo.Сотрудники as s
	LEFT JOIN dbo.Пользователи as p ON s.ИдСотрудника = p.ИдИсточника AND p.ТипИсточника = N'Сотрудник'
WHERE s.ИдСотрудника = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучениеСотрудников]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучениеСотрудников]
as 
begin

SELECT s.ИдСотрудника as workerId, s.Фамилия as firstName, s.Имя as lastName, s.Роль as position, s.Телефон as phone, s.ДатаПриема as dateStart, p.Логин as [login], null as [password]
FROM dbo.Сотрудники as s
	LEFT JOIN dbo.Пользователи as p ON s.ИдСотрудника = p.ИдИсточника AND p.ТипИсточника = N'Сотрудник'

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучитьИнформациюДляПочты]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучитьИнформациюДляПочты]
@Ид as INT
as 
begin

SELECT p.Логин as Email, k.Фамилия + N' ' + LEFT(k.Имя, 1) + N'.' as [Name], null as LastMessage
FROM dbo.Заказы as z
INNER JOIN dbo.Клиенты as k ON k.ИдКлиента = z.ИдКлиента
INNER JOIN dbo.Пользователи as p on p.ИдИсточника = k.ИдКлиента AND p.ТипИсточника = N'Клиент'
WHERE z.ИдЗаказа = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучитьСообщение]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучитьСообщение]
@Ид as INT
as 
begin
DECLARE @date as datetime, @idOrder as int

SELECT @idOrder = chats.ИдЗаказа
FROM dbo.СообщенияКлиента as chat
	inner join dbo.ЧатыПоЗаказам as chats on chats.ИдЧата = chat.ИдЧата
where chat.ИдСообщения = @Ид

SELECT @date = ISNULL(z.КогдаВиделСотрудник, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @idOrder

select client.ИдСообщения as IdMessage, client.Сообщение AS TextMessage, client.ДатаОтправки as DateSendMessage, N' ' as NameCompanion, CAST(iif(client.ДатаОтправки < @date, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияКлиента as client on client.ИдЧата = chat.ИдЧата
where client.ИдСообщения = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПолучитьСообщениеСотруднику]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПолучитьСообщениеСотруднику]
@Ид as INT
as 
begin
DECLARE @date as datetime, @idOrder as int

SELECT @idOrder = chats.ИдЗаказа
FROM dbo.СообщенияСотрудника as chat
	inner join dbo.ЧатыПоЗаказам as chats on chats.ИдЧата = chat.ИдЧата
where chat.ИдСообщения = @Ид

SELECT @date = ISNULL(z.КогдаВиделКлиент, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @idOrder

select worker.ИдСообщения as IdMessage, worker.Сообщение AS TextMessage, worker.ДатаОтправки as DateSendMessage, N'' as NameCompanion, CAST(iif(worker.ДатаОтправки < @date, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияСотрудника as worker on worker.ИдЧата = chat.ИдЧата
where worker.ИдСообщения = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ПоставитьОценкуЗаказу]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ПроверитьКод]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ПросмотретьСообщенияПоЗаказуКлиенту]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПросмотретьСообщенияПоЗаказуКлиенту]
@Ид as INT
as 
begin

DECLARE @lastUpdate AS DATETIME, @ИдЧата AS INT

SELECT @lastUpdate = ISNULL(z.КогдаВиделСотрудник, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

UPDATE z SET z.ВиделКлиент = 0, КогдаВиделКлиент = getdate()
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

SELECT @ИдЧата = chat.ИдЧата
FROM dbo.ЧатыПоЗаказам as chat
WHERE chat.ИдЗаказа = @Ид AND chat.ЗакрытЛиЧат = 0

select worker.ИдСообщения as IdMessage, worker.Сообщение AS TextMessage, worker.ДатаОтправки as DateSendMessage, workerSpr.Фамилия + N' ' + LEFT(workerSpr.Имя, 1) + N'.' as NameCompanion, CAST(iif(worker.ДатаОтправки < @lastUpdate, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияСотрудника as worker on worker.ИдЧата = chat.ИдЧата
	INNER JOIN dbo.Сотрудники as workerSpr ON worker.ИдСотрудника = workerSpr.ИдСотрудника
where chat.ИдЧата = @ИдЧата
UNION ALL
select client.ИдСообщения as IdMessage, client.Сообщение AS TextMessage, client.ДатаОтправки as DateSendMessage, N'' as NameCompanion, CAST(iif(client.ДатаОтправки < @lastUpdate, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияКлиента as client on client.ИдЧата = chat.ИдЧата
where chat.ИдЧата = @ИдЧата
ORDER BY DateSendMessage DESC

end
GO
/****** Object:  StoredProcedure [dbo].[ПросмотретьСообщенияПоЗаказуСотруднику]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ПросмотретьСообщенияПоЗаказуСотруднику]
@Ид as INT
as 
begin

DECLARE @lastUpdate AS DATETIME, @ИдЧата AS INT

SELECT @lastUpdate = ISNULL(z.КогдаВиделКлиент, '20000101')
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

UPDATE z SET z.ВиделСотрудник = 0, КогдаВиделСотрудник = getdate()
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

SELECT @ИдЧата = chat.ИдЧата
FROM dbo.ЧатыПоЗаказам as chat
WHERE chat.ИдЗаказа = @Ид AND chat.ЗакрытЛиЧат = 0

select worker.ИдСообщения as IdMessage, worker.Сообщение AS TextMessage, worker.ДатаОтправки as DateSendMessage, N'' as NameCompanion, CAST(iif(worker.ДатаОтправки < @lastUpdate, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияСотрудника as worker on worker.ИдЧата = chat.ИдЧата
where chat.ИдЧата = @ИдЧата
UNION ALL
select client.ИдСообщения as IdMessage, client.Сообщение AS TextMessage, client.ДатаОтправки as DateSendMessage, clientSpr.Фамилия + N' ' + LEFT(clientSpr.Имя, 1) + N'.' as NameCompanion, CAST(iif(client.ДатаОтправки < @lastUpdate, 1, 0) AS BIT) as IsVisible
FROM dbo.ЧатыПоЗаказам as chat
	INNER JOIN dbo.СообщенияКлиента as client on client.ИдЧата = chat.ИдЧата
	INNER JOIN dbo.Клиенты as clientSpr ON client.ИдКлиента = clientSpr.ИдКлиента
where chat.ИдЧата = @ИдЧата
ORDER BY DateSendMessage dESC

end
GO
/****** Object:  StoredProcedure [dbo].[Регистрация]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[СоздатьЗадание]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[СоздатьКодДляВосстановления]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[СоздатьОбращениеКлиенту]    Script Date: 24.04.2025 9:24:48 ******/
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

insert into dbo.ЧатыПоЗаказам (ИдЗаказа, ДатаСоздания, ЗакрытЛиЧат)
 VALUES (@Ид, GETDATE(), 0)

EXEC dbo.ПолучениеЗаказаКлиента @Ид = @Ид

end
GO
/****** Object:  StoredProcedure [dbo].[ТолкнутьЗаказКлиенту]    Script Date: 24.04.2025 9:24:48 ******/
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
/****** Object:  StoredProcedure [dbo].[ТолкнутьЗаказСотруднику]    Script Date: 24.04.2025 9:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ТолкнутьЗаказСотруднику]
@Ид as INT
as 
begin

UPDATE z SET z.Статус = CASE z.Статус WHEN N'Новый' THEN N'Проверка' WHEN N'Проверка' THEN N'Оценка' WHEN N'Оценка' THEN N'Согласование' WHEN N'Разработка' THEN N'Приемка' WHEN N'Запуск' THEN N'Готов' END
FROM dbo.Заказы as z
WHERE z.ИдЗаказа = @Ид

EXEC dbo.ПолучениеЗаказаСотрудника @Ид = @Ид

end
GO
