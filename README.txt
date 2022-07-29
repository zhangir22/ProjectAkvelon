Это проект был Создан исключительно для компании akvelon

Весь проект длился около 5 или 6 часов с перерывами
-------------------------------------
Первые шаг был создание базы данных 
В которым содержится 2 таблицы 
с полямя

1 таблица(
id int primary key identity not null,
name nvarchar(max) not null,
startProject datetime not null,
completationProject datetime not null,
statusProject nvarchar(max) not null,
priroty int not null
)
-----
2 таблица непосредственно связона с 1-ой 
(
id int primary key identity not null,
name nvarchar(max) not null,
status nvarchar(max) not null,
description nvarchar(max) not null,
priroty int not null,
idProject int not null foreign key 1таблица(id)
)
----------------------------------------------
Вторым шагам являлся скачевание entity framework
и затем изменение кода в web.config
А тем добавление строки подключение к базе данных
	<connectionStrings>
		<add name="Context" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAkvelon;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient" />
	</connectionStrings>
-------------------------------------------------
Третьим шагам был создание разных моделей
По этим же таблицам
------
Четвертый шаг была реализация в представлений всех моделей 