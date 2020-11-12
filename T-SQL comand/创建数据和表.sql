--�������д�κ����ݿ�Ĳ����Ĵ���

--����Ҫָ����������ݿ�

use master
go



if exists(select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB
go
--�������ݿ�


create database CourseManageDB
on primary 
(
	--���ݿ���߼��ļ���
	name = "CourseManageDB_data",
	--���ݿ������ļ���������·����
	filename="D:\SQLData\CourseManageDB_data.mdf",
	--���ݿ��ʼ�ļ���С������ʵ����������������
	size = 10MB,
	--�����ļ���ֵ��
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


---������ʦ��
--ָ��Ҫ���������ݿ�
use CourseManageDB
go

if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go

create table Teacher
(
	TeacherId int primary key identity(10000,1),--��ʦ��� ����
	LoginAccount varchar(50) not null,--��¼�˺�
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18) not null,
	TeacherName varchar(20) not null,
	PhoneNumber char(11) not null,
	NowAddress nvarchar(100) default('��ַ����')
)
go


--�����γ̷����

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
-- �γ̱�
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


---��Ӳ�������
use CourseManageDB
go
insert into Teacher(LoginAccount,loginPwd,TeacherName,PhoneNumber)
values('abc','123456','zbh','15613219111'),
('abc','123456','zbh','15613219111'),
('abc','123456','zbh','15613219111')

 
--ɾ������

delete from Teacher where TeacherId=10003


--��������

update Teacher set TeacherName='����',LoginPwd='654321' where TeacherId=10004


select * from Teacher



--��ӿγ̷���

insert into CourseCategory(CategoryName)
values('.net����'),('.net����'),('.net����')

select * from CourseCategory
--��ӿγ�
insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)
values('��Net��λ������','��λ�������γ̵�����','10','3','10001','10001')S


select CourseId, CourseName,CourseContent,ClassHour,Credit,Course.CategoryId,CategoryName,Course.TeacherId from Course 
inner join CourseCategory on Course.CategoryId = CourseCategory.CategoryId


update Course set CourseName='ADOѧϰ',CourseContent='ADO.NET����ѧϰ'where CourseId = 10003 

select count(*) as �γ����� from Course