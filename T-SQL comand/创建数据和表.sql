--在这里编写任何数据库的操作的代码

--首先要指向操作的数据库

use master
go



if exists(select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB
go
--创建数据库


create database CourseManageDB
on primary 
(
	--数据库的逻辑文件名
	name = "CourseManageDB_data",
	--数据库物理文件名（绝对路径）
	filename="D:\SQLData\CourseManageDB_data.mdf",
	--数据库初始文件大小（根据实际生产需求来定）
	size = 10MB,
	--数据文件增值量
	filegrowth = 1MB

),
(

    
	name = "CourseManageDB_data1",
	filename="D:\SQLData\CourseManageDB_data.ndf",	
	size = 10MB,
	filegrowth = 1MB

)
log on 
(
	name = "CourseManageDB_log",
	filename="D:\SQLData\CourseMangeDB_data.ldf",	
	size = 10MB,
	filegrowth = 1MB
)
go


---创建讲师表
--指向要操作的数据库
use CourseManageDB
go

if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go

create table Teacher
(
	TeacherId int primary key identity(10000,1),--讲师编号 主键
	LoginAccount varchar(50) not null,--登录账号
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18) not null,
	TeacherName varchar(20) not null,
	PhoneNumber char(11) not null,
	NowAddress nvarchar(100) default('地址不详')
)
go


--创建课程分类表

if exists(select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go

create table CourseCategory
(
	CategoryId int primary key identity(10000,1),
	CategoryName varchar(50) not null,
	
)
go

if exists(select * from sysobjects where name='Course')
drop table Course
go
-- 课程表
create table Course
(
	CourseId int primary key identity(10000,1),
	CourseName varchar(50) not null,
	CourseContent nvarchar(500) not null,
	ClassHour int not null,
	Credit int check(Credit>=1 and Credit<=30) not null,
	CategoryId int references CourseCategory(CategoryId) not null,
	TeacherId int references Teacher(TeacherId) not null,
	
)
go


---添加测试数据
use CourseManageDB
go
insert into Teacher(LoginAccount,loginPwd,TeacherName,PhoneNumber)
values('abc','123456','zbh','15613219111'),
('abc','123456','zbh','15613219111'),
('abc','123456','zbh','15613219111')

 
--删除数据

delete from Teacher where TeacherId=10003


--更新数据

update Teacher set TeacherName='张三',LoginPwd='654321' where TeacherId=10004


select * from Teacher



--添加课程分类

insert into CourseCategory(CategoryName)
values('.net开发'),('.net开发'),('.net开发')

select * from CourseCategory
--添加课程
insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)
values('。Net上位机开发','上位机开发课程的王牌','10','3','10001','10001')S


select CourseId, CourseName,CourseContent,ClassHour,Credit,Course.CategoryId,CategoryName,Course.TeacherId from Course 
inner join CourseCategory on Course.CategoryId = CourseCategory.CategoryId


update Course set CourseName='ADO学习',CourseContent='ADO.NET基础学习'where CourseId = 10003 

select count(*) as 课程总数 from Course