create database QuanLyGV
create table SALARY 
(
   SALARYID             varchar(50)                   not null,
   TEACHERID            varchar(50)                   null,
   TEACHINGHOUR         float                         null,
   RATEHOUR             decimal                       null,
   SALARY               float                         null,
   MONTHYEAR            datetime                      null,
   constraint PK_SALARY primary key (SALARYID),
   constraint FK_TEACHERID_sa foreign key references TEACHER(TEACHERID )
);

create table SCHEDULETEACHING 
(
   SCHEDULEID           varchar(50)                   not null,
   TEACHERID            varchar(50)                   not null,
   TIMESTART            datetime                      null,
   TIMEEND              datetime                      null,
   constraint PK_SCHEDULETEACHING primary key (SCHEDULEID),
   constraint K_TEACHERID foreign key references TEACHER(TEACHERID)
);

create table SESSIONMANAGEMENT 
(
   SESSIONID            nvarchar(50)                         not null,
   TEACHERID            nvarchar(50)                         null,
   TOKEN                varchar(55)                    null,
   EXPIRATIONTIME       timestamp                      null,
   USERID               integer                        null,
   constraint PK_SESSIONMANAGEMENT primary key (SESSIONID),
   constraint FK_TEACHERID foreign key references TEACHER(TEACHERID)
);

create table STATISTIC 
(
   STATISTICSID         nvarchar(50)                        not null,
   TEACHERID            nvarchar(50)                        null,
   TEACHINGHOUR         float                          null,
   SALARY               float                          null,
   constraint PK_STATISTICS primary key (STATISTICSID),
   foreign key references TEACHER(TEACHERID)
);

create table TEACHER 
(
   TEACHERID            nvarchar(50)                    not null,
   USERNAME             nvarchar(50)                   null,
   PASSWORD             varchar(50)                   null,
   FULLNAME             nvarchar(50)                   null,
   CONTRACT				nvarchar(100)                   null,
   PHONENUMBER          numeric                        null,
   EMAIL                nvarchar(50)                   null,
   constraint PK_TEACHER primary key (TEACHERID)
);
