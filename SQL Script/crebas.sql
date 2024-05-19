/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     19-May-24 5:58:39 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('APPOINTMENT') and o.name = 'FK_APPOINTM_HAVE_DOCTOR')
alter table APPOINTMENT
   drop constraint FK_APPOINTM_HAVE_DOCTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('APPOINTMENT') and o.name = 'FK_APPOINTM_MAKES_PATIENT')
alter table APPOINTMENT
   drop constraint FK_APPOINTM_MAKES_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NURSE') and o.name = 'FK_NURSE_SERVES_IN_ROOM')
alter table NURSE
   drop constraint FK_NURSE_SERVES_IN_ROOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PATIENT') and o.name = 'FK_PATIENT_TREATS_IN_ROOM')
alter table PATIENT
   drop constraint FK_PATIENT_TREATS_IN_ROOM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES_MEDICATI')
alter table TAKES
   drop constraint FK_TAKES_TAKES_MEDICATI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES2_PATIENT')
alter table TAKES
   drop constraint FK_TAKES_TAKES2_PATIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APPOINTMENT')
            and   name  = 'HAVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index APPOINTMENT.HAVE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APPOINTMENT')
            and   name  = 'MAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index APPOINTMENT.MAKES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('APPOINTMENT')
            and   type = 'U')
   drop table APPOINTMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCTOR')
            and   type = 'U')
   drop table DOCTOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDICATION')
            and   type = 'U')
   drop table MEDICATION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NURSE')
            and   name  = 'SERVES_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index NURSE.SERVES_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NURSE')
            and   type = 'U')
   drop table NURSE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PATIENT')
            and   name  = 'TREATS_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PATIENT.TREATS_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PATIENT')
            and   type = 'U')
   drop table PATIENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROOM')
            and   type = 'U')
   drop table ROOM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAKES')
            and   type = 'U')
   drop table TAKES
go

/*==============================================================*/
/* Table: APPOINTMENT                                           */
/*==============================================================*/
create table APPOINTMENT (
   APPOINTMENT_ID       int                  not null,
   PATIENT_ID           int                  not null,
   DOCTOR_ID            int                  not null,
   DOCTORID             int                  not null,
   PATIENTID            int                  not null,
   APPOINTMENTDATE      datetime             null,
   REASONFORVISIT       varchar(100)         null,
   constraint PK_APPOINTMENT primary key (APPOINTMENT_ID)
)
go

/*==============================================================*/
/* Index: MAKES_FK                                              */
/*==============================================================*/




create nonclustered index MAKES_FK on APPOINTMENT (PATIENT_ID ASC)
go

/*==============================================================*/
/* Index: HAVE_FK                                               */
/*==============================================================*/




create nonclustered index HAVE_FK on APPOINTMENT (DOCTOR_ID ASC)
go

/*==============================================================*/
/* Table: DOCTOR                                                */
/*==============================================================*/
create table DOCTOR (
   DOCTOR_ID            int                  not null,
   NAME                 varchar(50)          not null,
   SPECIALTY            varchar(50)          null,
   DEPARTMENT           varchar(50)          null,
   YEARSOFEXPERIENCE    varchar(10)          null,
   constraint PK_DOCTOR primary key (DOCTOR_ID)
)
go

/*==============================================================*/
/* Table: MEDICATION                                            */
/*==============================================================*/
create table MEDICATION (
   MEDICATION_ID        int                  not null,
   NAME                 varchar(50)          null,
   DOSAGE               decimal(3,0)         null,
   DESCRIPTION          varchar(100)         null,
   constraint PK_MEDICATION primary key (MEDICATION_ID)
)
go

/*==============================================================*/
/* Table: NURSE                                                 */
/*==============================================================*/
create table NURSE (
   NURSE_ID             int                  not null,
   NAME                 varchar(50)          not null,
   DEPARTMENT           varchar(50)          null,
   YEARSOFEXPERIENCE    varchar(10)          null,
   ROOM_ID               int                  null,
   constraint PK_NURSE primary key (NURSE_ID)
)
go

/*==============================================================*/
/* Index: SERVES_IN_FK                                          */
/*==============================================================*/




create nonclustered index SERVES_IN_FK on NURSE (ROOM_ID ASC)
go

/*==============================================================*/
/* Table: PATIENT                                               */
/*==============================================================*/
create table PATIENT (
   PATIENT_ID           int                  not null,
   NAME                 varchar(50)          not null,
   DATEOFBIRTH          datetime             null,
   ADDRESS              varchar(50)          null,
   PHONENUMBER          varchar(50)          null,
   EMERGENCYCONTACTNAME varchar(50)          null,
   EMERGENCYCONTACTPHONE varchar(50)          null,
   INSURANCEINFORMATION varchar(100)         null,
   ROOM_ID               int                  null,
   constraint PK_PATIENT primary key (PATIENT_ID)
)
go

/*==============================================================*/
/* Index: TREATS_IN_FK                                          */
/*==============================================================*/




create nonclustered index TREATS_IN_FK on PATIENT (ROOM_ID ASC)
go

/*==============================================================*/
/* Table: ROOM                                                  */
/*==============================================================*/
create table ROOM (
   ROOM_ID              int                  not null,
   NAME                 varchar(50)          null,
   DESCRIPTION          varchar(100)         null,
   constraint PK_ROOM primary key (ROOM_ID)
)
go

/*==============================================================*/
/* Table: TAKES                                                 */
/*==============================================================*/
create table TAKES (
   MEDICATION_ID        int                  not null,
   PATIENT_ID           int                  not null,
   constraint PK_TAKES primary key (MEDICATION_ID, PATIENT_ID)
)
go

/*==============================================================*/
/* Index: TAKES_FK                                              */
/*==============================================================*/




create nonclustered index TAKES_FK on TAKES (MEDICATION_ID ASC)
go

/*==============================================================*/
/* Index: TAKES2_FK                                             */
/*==============================================================*/




create nonclustered index TAKES2_FK on TAKES (PATIENT_ID ASC)
go

alter table APPOINTMENT
   add constraint FK_APPOINTM_HAVE_DOCTOR foreign key (DOCTOR_ID)
      references DOCTOR (DOCTOR_ID)
go

alter table APPOINTMENT
   add constraint FK_APPOINTM_MAKES_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

alter table NURSE
   add constraint FK_NURSE_SERVES_IN_ROOM foreign key (ROOM_ID)
      references ROOM (ROOM_ID)
go

alter table PATIENT
   add constraint FK_PATIENT_TREATS_IN_ROOM foreign key (ROOM_ID)
      references ROOM (ROOM_ID)
go

alter table TAKES
   add constraint FK_TAKES_TAKES_MEDICATI foreign key (MEDICATION_ID)
      references MEDICATION (MEDICATION_ID)
go

alter table TAKES
   add constraint FK_TAKES_TAKES2_PATIENT foreign key (PATIENT_ID)
      references PATIENT (PATIENT_ID)
go

