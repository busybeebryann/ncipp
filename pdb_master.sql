USE [master]
GO
/****** Object:  Database [payroll_db]    Script Date: 8/2/2017 10:03:29 AM ******/
CREATE DATABASE [payroll_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'payroll_db', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\payroll_db.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'payroll_db_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\payroll_db_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [payroll_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [payroll_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [payroll_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [payroll_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [payroll_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [payroll_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [payroll_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [payroll_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [payroll_db] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [payroll_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [payroll_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [payroll_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [payroll_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [payroll_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [payroll_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [payroll_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [payroll_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [payroll_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [payroll_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [payroll_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [payroll_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [payroll_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [payroll_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [payroll_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [payroll_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [payroll_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [payroll_db] SET  MULTI_USER 
GO
ALTER DATABASE [payroll_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [payroll_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [payroll_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [payroll_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [payroll_db]
GO
/****** Object:  Table [dbo].[tAttendance]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tAttendance](
	[att_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NULL,
	[stime_in] [varchar](50) NULL,
	[stime_out] [varchar](50) NULL,
	[time_in] [datetime] NULL,
	[time_out] [datetime] NULL,
	[reg_hr] [decimal](18, 0) NULL,
	[OT] [decimal](18, 0) NULL,
	[ND] [decimal](18, 0) NULL,
	[att_date] [datetime] NULL,
	[status] [varchar](18) NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tAttendance] PRIMARY KEY CLUSTERED 
(
	[att_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_AttPayroll]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_AttPayroll](
	[att_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nvarchar](25) NOT NULL,
	[time_in] [nvarchar](15) NOT NULL,
	[time_out] [nvarchar](15) NOT NULL,
	[reg_hr] [nvarchar](4) NOT NULL,
	[OT] [nvarchar](4) NOT NULL,
	[ND] [nvarchar](4) NOT NULL,
	[att_date] [nvarchar](15) NOT NULL,
	[status] [nvarchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_department]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_department](
	[dept_id] [int] IDENTITY(1,1) NOT NULL,
	[dept_name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_docs]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_docs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nchar](50) NULL,
	[category] [nchar](50) NULL,
	[description] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_jobpos]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_jobpos](
	[pos_id] [int] IDENTITY(1,1) NOT NULL,
	[job_pos] [nchar](25) NOT NULL,
	[basic_pay] [nvarchar](25) NOT NULL,
	[department] [nchar](50) NULL,
	[salary_grade] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_leave]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_leave](
	[emp_id] [nvarchar](50) NULL,
	[leave_type] [nvarchar](50) NULL,
	[no_days] [nvarchar](50) NULL,
	[no_paid] [nvarchar](50) NULL,
	[s_d] [nvarchar](50) NULL,
	[e_d] [nvarchar](50) NULL,
	[e_credits] [decimal](18, 2) NULL,
	[b_credits] [decimal](18, 2) NULL,
	[modifiedon] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_loans]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_loans](
	[load_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nvarchar](25) NOT NULL,
	[loan_type] [nvarchar](50) NOT NULL,
	[interest] [nvarchar](11) NOT NULL,
	[months_to_pay] [nvarchar](50) NOT NULL,
	[payment_amount] [nvarchar](11) NOT NULL,
	[interest_rate] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_logindetails]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_logindetails](
	[acc_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[pass_word] [varchar](50) NOT NULL,
	[access_lvl] [nchar](10) NOT NULL,
	[acc_locked] [nchar](50) NULL,
	[empid] [int] NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tbl_logindetails] PRIMARY KEY CLUSTERED 
(
	[acc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_logindetails2]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_logindetails2](
	[acc_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nchar](25) NOT NULL,
	[user_name] [nchar](25) NOT NULL,
	[pass_word] [nchar](25) NOT NULL,
	[access_lvl] [nchar](10) NOT NULL,
	[acc_locked] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_payroll]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_payroll](
	[salary_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nvarchar](25) NULL,
	[emp_name] [nvarchar](100) NULL,
	[position] [nvarchar](25) NULL,
	[department] [nvarchar](25) NULL,
	[daterange] [nvarchar](35) NULL,
	[civil_stat] [nvarchar](10) NULL,
	[dependents] [nvarchar](6) NULL,
	[rate_day] [nvarchar](10) NULL,
	[rate_hour] [nvarchar](10) NULL,
	[NH] [nvarchar](10) NULL,
	[OT] [nvarchar](10) NULL,
	[ND] [nvarchar](10) NULL,
	[monthly_pay] [nvarchar](15) NULL,
	[PERA] [nvarchar](15) NULL,
	[Grosspay] [nvarchar](15) NULL,
	[policy_loan] [nvarchar](15) NULL,
	[e_card] [nvarchar](15) NULL,
	[emergency_loan] [nvarchar](15) NULL,
	[conso_loan] [nvarchar](15) NULL,
	[pagibig_loan] [nvarchar](15) NULL,
	[pagibig_housing] [nvarchar](15) NULL,
	[ncipae_loan] [nvarchar](15) NULL,
	[lbp_loan] [nvarchar](15) NULL,
	[educ_loan] [nvarchar](15) NULL,
	[uoli_cont] [nvarchar](15) NULL,
	[gsis_social_cont] [nvarchar](15) NULL,
	[ncipae_man_fee] [nvarchar](15) NULL,
	[ncipae_mem_fee] [nvarchar](15) NULL,
	[Philhealth] [nvarchar](20) NULL,
	[Pagibig] [nvarchar](20) NULL,
	[TAX] [nvarchar](20) NULL,
	[net_pay] [nvarchar](20) NULL,
	[additional_deductions] [nvarchar](max) NULL,
	[status] [nchar](10) NULL,
	[date_computed] [nvarchar](25) NULL,
	[month_computed] [nvarchar](25) NULL,
	[time_computed] [nvarchar](25) NULL,
	[tDed] [nvarchar](25) NULL,
	[province] [nvarchar](25) NULL,
	[createdon] [datetime] NOT NULL,
	[modifiedon] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PayrollData]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PayrollData](
	[pay_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nvarchar](15) NOT NULL,
	[tot_RH] [nvarchar](4) NOT NULL,
	[tot_OT] [nvarchar](4) NOT NULL,
	[tot_ND] [nvarchar](4) NOT NULL,
	[daterange] [nvarchar](70) NOT NULL,
	[drange_dur] [nvarchar](4) NOT NULL,
	[status] [nvarchar](4) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_selUserRep]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_selUserRep](
	[rep_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nvarchar](25) NOT NULL,
	[fn] [nvarchar](30) NOT NULL,
	[ln] [nvarchar](30) NOT NULL,
	[mi] [nvarchar](5) NOT NULL,
	[gr] [nvarchar](7) NOT NULL,
	[jp] [nvarchar](25) NOT NULL,
	[dp] [nvarchar](25) NOT NULL,
	[dh] [nvarchar](35) NOT NULL,
	[dn] [nchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_service]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nchar](25) NULL,
	[first_name] [nchar](25) NULL,
	[middle_name] [nchar](25) NULL,
	[last_name] [nchar](25) NULL,
	[b_date] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_service_rpt]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_service_rpt](
	[sr_id] [int] NOT NULL,
	[emp_id] [nchar](25) NOT NULL,
	[first_name] [nchar](25) NULL,
	[last_name] [nchar](25) NULL,
	[middle_name] [nchar](25) NULL,
	[job_pos] [nchar](25) NOT NULL,
	[dept] [nchar](25) NOT NULL,
	[date_hired] [nvarchar](50) NOT NULL,
	[marital_stat] [nchar](10) NOT NULL,
	[address] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_user](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[middle_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[b_date] [datetime] NOT NULL,
	[age] [tinyint] NOT NULL,
	[c_no] [varchar](50) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[address] [varchar](max) NOT NULL,
	[job_pos] [varchar](100) NOT NULL,
	[dept] [varchar](100) NOT NULL,
	[date_hired] [datetime] NOT NULL,
	[marital_status] [varchar](10) NOT NULL,
	[dependents] [tinyint] NOT NULL,
	[philhealth] [varchar](50) NULL,
	[pagibig] [varchar](50) NOT NULL,
	[TAX] [varchar](50) NOT NULL,
	[DIN] [varchar](50) NULL,
	[basic_pay] [decimal](12, 2) NULL,
	[educ_loan] [varchar](50) NULL,
	[province] [varchar](50) NULL,
	[gsis_no] [varchar](50) NULL,
	[bp_number] [varchar](50) NULL,
	[lbp_number] [varchar](50) NULL,
	[pol_number] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[status_date] [datetime] NULL,
	[assigned_place] [varchar](50) NULL,
	[deptid] [int] NULL,
	[positionid] [int] NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tbl_user1] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_user2]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_user2](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [nchar](25) NOT NULL,
	[first_name] [nchar](25) NOT NULL,
	[middle_name] [nchar](25) NOT NULL,
	[last_name] [nchar](25) NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[b_date] [nvarchar](50) NOT NULL,
	[age] [nvarchar](50) NOT NULL,
	[c_no] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[job_pos] [nchar](25) NOT NULL,
	[dept] [nchar](25) NOT NULL,
	[date_hired] [nvarchar](50) NOT NULL,
	[marital_status] [nchar](15) NOT NULL,
	[dependents] [nvarchar](5) NOT NULL,
	[SSS] [nvarchar](50) NULL,
	[philhealth] [nvarchar](50) NOT NULL,
	[pagibig] [nvarchar](50) NOT NULL,
	[TAX] [nvarchar](50) NOT NULL,
	[DIN] [int] NULL,
	[hr_pr_day] [nvarchar](50) NULL,
	[basic_pay] [nchar](50) NULL,
	[educ_loan] [varchar](50) NULL,
	[province] [nvarchar](50) NULL,
	[bp_number] [nvarchar](50) NULL,
	[lbp_number] [nvarchar](50) NULL,
	[pol_number] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[date_retired] [nvarchar](50) NULL,
	[date_terminated] [nvarchar](50) NULL,
	[date_resigned] [nvarchar](50) NULL,
	[date_separated] [nvarchar](50) NULL,
	[assigned_place] [nvarchar](50) NULL,
	[gsis_no] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_user3]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_user3](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[middle_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[b_date] [datetime] NOT NULL,
	[age] [tinyint] NOT NULL,
	[c_no] [varchar](50) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[address] [varchar](max) NOT NULL,
	[job_pos] [varchar](100) NOT NULL,
	[dept] [varchar](100) NOT NULL,
	[date_hired] [datetime] NOT NULL,
	[marital_status] [varchar](10) NOT NULL,
	[dependents] [tinyint] NOT NULL,
	[SSS] [varchar](50) NULL,
	[philhealth] [varchar](50) NULL,
	[pagibig] [varchar](50) NOT NULL,
	[TAX] [varchar](50) NOT NULL,
	[DIN] [varchar](50) NULL,
	[hr_pr_day] [tinyint] NULL,
	[basic_pay] [decimal](12, 2) NULL,
	[educ_loan] [varchar](50) NULL,
	[province] [varchar](50) NULL,
	[bp_number] [varchar](50) NULL,
	[lbp_number] [varchar](50) NULL,
	[pol_number] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[date_retired] [datetime] NULL,
	[date_terminated] [datetime] NULL,
	[date_resigned] [datetime] NULL,
	[date_separated] [datetime] NULL,
	[assigned_place] [varchar](50) NULL,
	[gsis_no] [varchar](50) NULL,
	[deptid] [int] NULL,
	[positionid] [int] NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tDepartment]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tDepartment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [varchar](100) NOT NULL,
	[createdon] [datetime] NOT NULL,
	[modifiedon] [datetime] NOT NULL,
 CONSTRAINT [PK_tDepartment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tEarnedCredits]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tEarnedCredits](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NULL,
	[slbalance] [decimal](18, 2) NULL,
	[vlbalance] [decimal](18, 2) NULL,
	[balance_date] [datetime] NULL,
	[modifiedon] [datetime] NULL,
	[createdon] [datetime] NULL,
 CONSTRAINT [PK_tEarnedCredits] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tLeave]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tLeave](
	[l_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](50) NULL,
	[leave_type] [varchar](50) NULL,
	[no_days] [varchar](50) NULL,
	[no_paid] [varchar](50) NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[slcredits] [decimal](18, 2) NULL,
	[vlcredits] [decimal](18, 2) NULL,
	[slearned] [decimal](18, 2) NULL,
	[vlearned] [decimal](18, 2) NULL,
	[sl_balance] [decimal](18, 2) NULL,
	[vl_balance] [decimal](18, 2) NULL,
	[remark] [varchar](max) NULL,
	[modifiedon] [datetime] NULL,
	[createdon] [datetime] NULL,
 CONSTRAINT [PK_tLeave] PRIMARY KEY CLUSTERED 
(
	[l_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tLoan]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tLoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[Status] [varchar](100) NULL,
	[basicPay] [decimal](12, 2) NULL,
	[gsis_ouli] [decimal](12, 2) NULL,
	[gsis_ec] [decimal](12, 2) NULL,
	[gsis_ee] [decimal](12, 2) NULL,
	[gsis_er] [decimal](12, 2) NULL,
	[gsis_cl_remarks] [varchar](100) NULL,
	[gsis_cl_totalpay] [decimal](12, 2) NULL,
	[gsis_cl_totalAm] [decimal](12, 2) NULL,
	[gsis_cl_monAm] [decimal](12, 2) NULL,
	[gsis_cl_paidAm] [decimal](12, 2) NULL,
	[gsis_cl_balance] [decimal](12, 2) NULL,
	[gsis_cloan] [decimal](12, 2) NULL,
	[gsis_cl_end] [datetime] NULL,
	[gsis_cl_start] [datetime] NULL,
	[gsis_cl_gdate] [datetime] NULL,
	[gsis_el_remarks] [varchar](100) NULL,
	[gsis_el_totalpay] [decimal](12, 2) NULL,
	[gsis_el_totalAm] [decimal](12, 2) NULL,
	[gsis_el_monAm] [decimal](12, 2) NULL,
	[gsis_el_paidAm] [decimal](12, 2) NULL,
	[gsis_el_balance] [decimal](12, 2) NULL,
	[gsis_eloan] [decimal](12, 2) NULL,
	[gsis_el_end] [datetime] NULL,
	[gsis_el_start] [datetime] NULL,
	[gsis_el_gdate] [datetime] NULL,
	[gsis_pl_remarks] [varchar](100) NULL,
	[gsis_pl_totalpay] [decimal](12, 2) NULL,
	[gsis_pl_totalAm] [decimal](12, 2) NULL,
	[gsis_pl_monAm] [decimal](12, 2) NULL,
	[gsis_pl_paidAm] [decimal](12, 2) NULL,
	[gsis_pl_balance] [decimal](12, 2) NULL,
	[gsis_ploan] [decimal](12, 2) NULL,
	[gsis_pl_end] [datetime] NULL,
	[gsis_pl_start] [datetime] NULL,
	[gsis_pl_gdate] [datetime] NULL,
	[gsis_edu_remarks] [varchar](100) NULL,
	[gsis_edu_totalpay] [decimal](12, 2) NULL,
	[gsis_edu_totalAm] [decimal](12, 2) NULL,
	[gsis_edu_monAm] [decimal](12, 2) NULL,
	[gsis_edu_paidAm] [decimal](12, 2) NULL,
	[gsis_edu_balance] [decimal](12, 2) NULL,
	[gsis_eduloan] [decimal](12, 2) NULL,
	[gsis_edu_end] [datetime] NULL,
	[gsis_edu_start] [datetime] NULL,
	[gsis_edu_gdate] [datetime] NULL,
	[hdmf_hs_remarks] [varchar](100) NULL,
	[hdmf_hs_totalpay] [decimal](12, 2) NULL,
	[hdmf_hs_totalAm] [decimal](12, 2) NULL,
	[hdmf_hs_monAm] [decimal](12, 2) NULL,
	[hdmf_hs_paidAm] [decimal](12, 2) NULL,
	[hdmf_hs_balance] [decimal](12, 2) NULL,
	[hdmf_hsloan] [decimal](12, 2) NULL,
	[hdmf_hs_end] [datetime] NULL,
	[hdmf_hs_start] [datetime] NULL,
	[hdmf_hs_gdate] [datetime] NULL,
	[hdmf_mp_remarks] [varchar](100) NULL,
	[hdmf_mp_totalpay] [decimal](12, 2) NULL,
	[hdmf_mp_totalAm] [decimal](12, 2) NULL,
	[hdmf_mp_monAm] [decimal](12, 2) NULL,
	[hdmf_mp_paidAm] [decimal](12, 2) NULL,
	[hdmf_mp_balance] [decimal](12, 2) NULL,
	[hdmf_mploan] [decimal](12, 2) NULL,
	[hdmf_mp_end] [datetime] NULL,
	[hdmf_mp_start] [datetime] NULL,
	[hdmf_mp_gdate] [datetime] NULL,
	[lbp_totalpay] [decimal](12, 2) NULL,
	[lbp_totalAm] [decimal](12, 2) NULL,
	[lbp_monAm] [decimal](12, 2) NULL,
	[lbp_balance] [decimal](12, 2) NULL,
	[lbp_gloan] [decimal](12, 2) NULL,
	[lbp_paidAm] [decimal](12, 2) NULL,
	[lbp_end] [datetime] NULL,
	[lbp_start] [datetime] NULL,
	[lbp_gdate] [datetime] NULL,
	[lbp_remarks] [varchar](100) NULL,
	[ncipea_mandatory] [decimal](12, 2) NULL,
	[ncipea_amount] [decimal](12, 2) NULL,
	[ncipea_totalpay] [decimal](12, 2) NULL,
	[ncipea_totalAm] [decimal](12, 2) NULL,
	[ncipea_monAm] [decimal](12, 2) NULL,
	[ncipea_loan] [decimal](12, 2) NULL,
	[ncipea_balance] [decimal](12, 2) NULL,
	[ncipea_paidAm] [decimal](12, 2) NULL,
	[ncipea_end] [datetime] NULL,
	[ncipea_start] [datetime] NULL,
	[ncipea_gdate] [datetime] NULL,
	[ncipea_remarks] [varchar](100) NULL,
	[phic_ee] [decimal](12, 2) NULL,
	[phic_er] [decimal](12, 2) NULL,
	[hdmf_ee] [decimal](12, 2) NULL,
	[wt_amount] [decimal](12, 2) NULL,
	[hdmf_er] [decimal](12, 2) NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tLoans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tMontWTax]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tMontWTax](
	[wTax_Id] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](100) NULL,
	[dependent] [varchar](100) NULL,
	[compensation1] [decimal](12, 2) NULL,
	[compensation2] [decimal](12, 2) NULL,
	[overam] [decimal](12, 2) NULL,
	[exemption] [decimal](12, 2) NULL,
	[remarks] [varchar](100) NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPayroll]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPayroll](
	[salary_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_id] [varchar](100) NULL,
	[emp_name] [varchar](100) NULL,
	[position] [varchar](100) NULL,
	[department] [varchar](100) NULL,
	[daterange] [varchar](100) NULL,
	[civil_stat] [varchar](100) NULL,
	[dependents] [varchar](100) NULL,
	[rate_day] [varchar](100) NULL,
	[rate_hour] [varchar](100) NULL,
	[NH] [nvarchar](10) NULL,
	[OT] [nvarchar](10) NULL,
	[ND] [nvarchar](10) NULL,
	[monthly_pay] [decimal](12, 2) NULL,
	[PERA] [decimal](12, 2) NULL,
	[Grosspay] [decimal](12, 2) NULL,
	[policy_loan] [decimal](12, 2) NULL,
	[e_card] [decimal](12, 2) NULL,
	[emergency_loan] [decimal](12, 2) NULL,
	[conso_loan] [decimal](12, 2) NULL,
	[pagibig_loan] [decimal](12, 2) NULL,
	[pagibig_housing] [decimal](12, 2) NULL,
	[ncipae_loan] [decimal](12, 2) NULL,
	[lbp_loan] [decimal](12, 2) NULL,
	[educ_loan] [decimal](12, 2) NULL,
	[uoli_cont] [decimal](12, 2) NULL,
	[gsis_social_cont] [decimal](12, 2) NULL,
	[ncipae_man_fee] [decimal](12, 2) NULL,
	[ncipae_mem_fee] [decimal](12, 2) NULL,
	[Philhealth] [decimal](12, 2) NULL,
	[Pagibig] [decimal](12, 2) NULL,
	[TAX] [decimal](12, 2) NULL,
	[net_pay] [decimal](12, 2) NULL,
	[additional_deductions] [varchar](max) NULL,
	[status] [varchar](100) NULL,
	[date_computed] [datetime] NOT NULL,
	[month_computed] [varchar](100) NULL,
	[time_computed] [datetime] NOT NULL,
	[tDed] [varchar](100) NULL,
	[province] [varchar](100) NULL,
	[createdon] [datetime] NOT NULL,
	[modifiedon] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPosition]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tPosition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[SalaryGrade] [varchar](50) NULL,
	[BasicPay] [decimal](12, 2) NULL,
	[DeptID] [int] NOT NULL,
	[DeptName] [varchar](100) NOT NULL,
	[createdon] [datetime] NOT NULL,
	[modifiedon] [datetime] NOT NULL,
 CONSTRAINT [PK_tPosition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tSemiWTax]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tSemiWTax](
	[wTax_Id] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](100) NULL,
	[dependent] [varchar](100) NULL,
	[compensation1] [decimal](12, 2) NULL,
	[compensation2] [decimal](12, 2) NULL,
	[overam] [decimal](12, 2) NULL,
	[exemption] [decimal](12, 2) NULL,
	[remarks] [varchar](100) NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tService]    Script Date: 8/2/2017 10:03:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tService](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [varchar](100) NOT NULL,
	[Designation] [varchar](100) NOT NULL,
	[AppointmentStatus] [varchar](100) NOT NULL,
	[MonthlySalary] [decimal](12, 2) NULL,
	[AnnualSalary] [decimal](12, 2) NULL,
	[OfficeAssignment] [varchar](100) NULL,
	[Remarks] [varchar](max) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[createdon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
 CONSTRAINT [PK_tService] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tAttendance] ON 

GO
INSERT [dbo].[tAttendance] ([att_id], [emp_id], [stime_in], [stime_out], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status], [createdon], [modifiedon]) VALUES (1, N'PL20170002', N'4:35:38 PM', N'4:48:53 PM', CAST(0x0000000001117578 AS DateTime), CAST(0x000000000115191C AS DateTime), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0x0000A7B700000000 AS DateTime), N'0', CAST(0x0000A7B70111E331 AS DateTime), CAST(0x0000A7B70115F83B AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tAttendance] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_AttPayroll] ON 

GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (83, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-01', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (84, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-02', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (85, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-03', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (86, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-04', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (87, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-05', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (88, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-08', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (89, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-09', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (90, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-10', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (91, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-11', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (92, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-12', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (93, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-15', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (116, N'PL20160004', N'9:16:31 AM', N'3:03:26 PM', N'6', N'0', N'0', N'3/08/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (138, N'PL20160005', N'5:03:42 PM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-3-22', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (139, N'PL20160004               ', N'Leave', N'3:03:26 PM', N'6', N'0', N'0', N'3/28/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (140, N'PL20160004               ', N'Leave', N'3:03:26 PM', N'6', N'0', N'0', N'3/29/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (144, N'PL20160003               ', N'Leave', N'4:55:28 PM', N'0', N'0', N'0', N'5/9/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (145, N'PL20160003               ', N'Leave', N'4:55:28 PM', N'0', N'0', N'0', N'5/10/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (146, N'PL20160003               ', N'7:00:00 AM', N'4:55:28 PM', N'0', N'0', N'0', N'2016-5-05', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (1144, N'PL20160003               ', N'4:41:00 PM', N'4:41:00 PM', N'0', N'0', N'0', N'2016-12-01', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (1145, N'PL20170001', N'1:44:36 PM', N'1:49:07 PM', N'0', N'0', N'0', N'2017-6-08', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (1146, N'PL20170002', N'2:48:35 PM', N'2:48:15 PM', N'0', N'0', N'0', N'2017-7-12', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (2146, N'PL20170002', N'3:40:58 PM', N'none', N'0', N'0', N'0', N'2017-7-21', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (128, N'PL20160005               ', N'Leave', N'5:03:11 PM', N'0', N'0', N'0', N'3/27/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (129, N'PL20160005               ', N'Leave', N'5:03:11 PM', N'0', N'0', N'0', N'3/28/2016', N'0')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (72, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-16', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (73, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-17', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (74, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-18', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (75, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-19', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (77, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-22', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (78, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-23', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (79, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-24', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (80, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-25', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (81, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-26', N'1')
GO
INSERT [dbo].[tbl_AttPayroll] ([att_id], [emp_id], [time_in], [time_out], [reg_hr], [OT], [ND], [att_date], [status]) VALUES (82, N'PL20160005               ', N'8:00:00 AM', N'5:03:11 PM', N'0', N'0', N'0', N'2016-2-29', N'1')
GO
SET IDENTITY_INSERT [dbo].[tbl_AttPayroll] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_department] ON 

GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (1, N'Accounting ')
GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (2, N'IT')
GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (3, N'Custodian Officer')
GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (4, N'HRD')
GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (5, N'Service Operation')
GO
INSERT [dbo].[tbl_department] ([dept_id], [dept_name]) VALUES (10, N'Support')
GO
SET IDENTITY_INSERT [dbo].[tbl_department] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_docs] ON 

GO
INSERT [dbo].[tbl_docs] ([id], [emp_id], [category], [description]) VALUES (10, N'PL20160003                                        ', N'Office Documents                                  ', N'COE                                               ')
GO
SET IDENTITY_INSERT [dbo].[tbl_docs] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_jobpos] ON 

GO
INSERT [dbo].[tbl_jobpos] ([pos_id], [job_pos], [basic_pay], [department], [salary_grade]) VALUES (7, N'Programmer               ', N'18000', N'IT                                                ', N'I')
GO
INSERT [dbo].[tbl_jobpos] ([pos_id], [job_pos], [basic_pay], [department], [salary_grade]) VALUES (8, N'Accounting Head          ', N'15000', N'Accounting                                        ', N'I')
GO
INSERT [dbo].[tbl_jobpos] ([pos_id], [job_pos], [basic_pay], [department], [salary_grade]) VALUES (9, N'Accountant               ', N'50,000.00', N'Accounting                                        ', N'III')
GO
INSERT [dbo].[tbl_jobpos] ([pos_id], [job_pos], [basic_pay], [department], [salary_grade]) VALUES (13, N'Quality Assurance        ', N'12,000.00', N'IT                                                ', N'I')
GO
SET IDENTITY_INSERT [dbo].[tbl_jobpos] OFF
GO
INSERT [dbo].[tbl_leave] ([emp_id], [leave_type], [no_days], [no_paid], [s_d], [e_d], [e_credits], [b_credits], [modifiedon]) VALUES (N'PL20160003               ', N'Sick Leave', N'2', N'2', N'5/9/2016', N'5/10/2016', CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_loans] ON 

GO
INSERT [dbo].[tbl_loans] ([load_id], [emp_id], [loan_type], [interest], [months_to_pay], [payment_amount], [interest_rate]) VALUES (3, N'PL20160003               ', N'Conso Loan', N'1', N'118', N'505', N'')
GO
INSERT [dbo].[tbl_loans] ([load_id], [emp_id], [loan_type], [interest], [months_to_pay], [payment_amount], [interest_rate]) VALUES (4, N'PL20160003               ', N'Conso Loan', N'8', N'118', N'1620', N'')
GO
SET IDENTITY_INSERT [dbo].[tbl_loans] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_logindetails] ON 

GO
INSERT [dbo].[tbl_logindetails] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked], [empid], [createdon], [modifiedon]) VALUES (2, N'PR001108151', N'admin', N'admin', N'1         ', NULL, 1, NULL, NULL)
GO
INSERT [dbo].[tbl_logindetails] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked], [empid], [createdon], [modifiedon]) VALUES (1002, N'PL20170001', N'PL20170001', N'admin123', N'2         ', N'                                                  ', 1, CAST(0x0000A72300F5EA94 AS DateTime), CAST(0x0000A72300F5EA94 AS DateTime))
GO
INSERT [dbo].[tbl_logindetails] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked], [empid], [createdon], [modifiedon]) VALUES (1003, N'PL20170002', N'PL20170002', N'admin123', N'2         ', N'                                                  ', 2, CAST(0x0000A723010EDC14 AS DateTime), CAST(0x0000A723010EDC14 AS DateTime))
GO
INSERT [dbo].[tbl_logindetails] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked], [empid], [createdon], [modifiedon]) VALUES (1004, N'PL20170003', N'PL20170003', N'admin123', N'2         ', N'                                                  ', 3, CAST(0x0000A73700D8A450 AS DateTime), CAST(0x0000A73700D8A450 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_logindetails] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_logindetails2] ON 

GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (1, N'PR001108151              ', N'admin                    ', N'admin                    ', N'1         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (1020, N'PL20160004               ', N'PL20160004               ', N'p@$$w0rd                 ', N'2         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (2020, N'PL20170004               ', N'PL20170004               ', N'p@$$w0rd                 ', N'2         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (20, N'PL20160003               ', N'PL20160003               ', N'maryann123               ', N'2         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (2021, N'PL20170004               ', N'PL20170004               ', N'p@$$w0rd                 ', N'2         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (2022, N'PL20170005               ', N'PL20170005               ', N'p@$$w0rd                 ', N'2         ', NULL)
GO
INSERT [dbo].[tbl_logindetails2] ([acc_id], [emp_id], [user_name], [pass_word], [access_lvl], [acc_locked]) VALUES (2023, N'PL20170006               ', N'PL20170006               ', N'p@$$w0rd                 ', N'2         ', NULL)
GO
SET IDENTITY_INSERT [dbo].[tbl_logindetails2] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_payroll] ON 

GO
INSERT [dbo].[tbl_payroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (5, N'PL20160003     ', N'Chua, Mary Ann A.', N'Programmer', N'IT', N'2016-5-16 - 2016-5-30', N'Single', N'0', N'1363.64', N'170.46', N'10', N'0', N'0', N'13,636.80', N'2,000.00', N'15,636.80', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'1,407.31', N'100.00', N'25.00', N'187.5', N'100.00', N'1,471.73', N'12,325.26', N'', N'0         ', N'5/5/2016 2:01:29 PM', N'May', N'2:01:29 PM', N'3311.54', N'Ifugao', CAST(0x0000A72700E85C3E AS DateTime), CAST(0x0000A72800E7D28C AS DateTime))
GO
INSERT [dbo].[tbl_payroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (6, N'PL20160003     ', N'Chua, Mary Ann A.', N'Programmer', N'IT', N'2016-12-01 - 2016-12-01', N'Single', N'1', N'15000', N'1875', N'0', N'0', N'0', N'000.00', N'2,000.00', N'2,000.00', N'0.00', N'0.00', N'0.00', N'1,620.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'180.00', N'100.00', N'25.00', N'100', N'040.00', N'0', N'1915', N'1000 -  Php
1000 - 1000 Php
fgfgfgfgfgfg - 1000 Php
', N'0         ', N'12/6/2016 4:42:45 PM', N'December', N'4:42:45 PM', N'2085', N'Ifugao', CAST(0x0000A72700E85C3E AS DateTime), CAST(0x0000A72800E7D28C AS DateTime))
GO
INSERT [dbo].[tbl_payroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (7, N'PL20170003', N'Terrado, Reyan ', N'Admin.Aide I', N'IT', N'2016-12-06 - 2016-12-06', N'Single', N'1', N'15000', N'1875', N'0', N'0', N'0', N'000.00', N'2,000.00', N'15,636.80', N'0.00', N'0.00', N'0.00', N'1,620.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'0.00', N'180.00', N'100.00', N'25.00', N'100', N'040.00', N'1,471.73', N'12,325.26', N'', N'0         ', N'12/6/2016 4:45:06 PM', N'December', N'4:45:06 PM', N'2085', N'Ifugao', CAST(0x0000A72700E85C3E AS DateTime), CAST(0x0000A72800E7D28C AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_payroll] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_PayrollData] ON 

GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (17, N'PR001108151    ', N'0', N'0', N'0', N'2016-2-01 - 2016-2-15', N'11', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (32, N'PR001108151    ', N'0', N'0', N'0', N'2016-5-02 - 2016-5-13', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (22, N'PR001108151    ', N'0', N'0', N'0', N'2016-3-15 - 2016-3-30', N'12', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (34, N'PR001108151    ', N'0', N'0', N'0', N'2016-5-16 - 2016-5-30', N'11', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (35, N'PL20160003     ', N'0', N'0', N'0', N'2016-5-16 - 2016-5-30', N'11', N'1')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (26, N'PR001108151    ', N'0', N'0', N'0', N'2016-3-30 - 2016-4-15', N'13', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (1032, N'PR001108151    ', N'0', N'0', N'0', N'2016-12-01 - 2016-12-01', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (29, N'PR001108151    ', N'0', N'0', N'0', N'2016-5-01 - 2016-5-13', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (1033, N'PL20160003     ', N'0', N'0', N'0', N'2016-12-01 - 2016-12-01', N'1', N'1')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (1034, N'PR001108151    ', N'0', N'0', N'0', N'2016-12-06 - 2016-12-06', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (1035, N'PL20160003     ', N'0', N'0', N'0', N'2016-12-06 - 2016-12-06', N'1', N'1')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (1036, N'PL20160003     ', N'0', N'0', N'0', N'2016-12-06 - 2016-12-06', N'1', N'1')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2034, N'PR001108151    ', N'', N'', N'', N'2017-1-18 - 2017-1-31', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2035, N'PL20160004     ', N'', N'', N'', N'2017-1-18 - 2017-1-31', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2036, N'PL20160003     ', N'', N'', N'', N'2017-1-18 - 2017-1-31', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2037, N'PL20170004     ', N'', N'', N'', N'2017-1-18 - 2017-1-31', N'10', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2038, N'PR001108151    ', N'', N'', N'', N'2017-1-01 - 2017-1-31', N'22', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2039, N'PL20160004     ', N'', N'', N'', N'2017-1-01 - 2017-1-31', N'22', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2040, N'PL20160003     ', N'', N'', N'', N'2017-1-01 - 2017-1-31', N'22', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2041, N'PL20170004     ', N'', N'', N'', N'2017-1-01 - 2017-1-31', N'22', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2042, N'PL20170001', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2043, N'PL20170002', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2044, N'PL20170003', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2045, N'PL20170001', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2046, N'PL20170002', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
INSERT [dbo].[tbl_PayrollData] ([pay_id], [emp_id], [tot_RH], [tot_OT], [tot_ND], [daterange], [drange_dur], [status]) VALUES (2047, N'PL20170003', N'', N'', N'', N'2017-5-29 - 2017-5-29', N'1', N'0')
GO
SET IDENTITY_INSERT [dbo].[tbl_PayrollData] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_selUserRep] ON 

GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (11, N'PR001108151', N'Jovelyn', N'Nogales', N'A', N'Female', N'Administrator', N'Administrator', N'11-12-2000', N'2    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (12, N'PR001108152', N'Timothy Martin', N'Masagca', N'M', N'Male', N'Administrator', N'HRD', N'11-06-2015', N'1    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (13, N'PR001108151', N'Jovelyn', N'Nogales', N'A', N'Female', N'Administrator', N'Administrator', N'11-12-2000', N'2    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (14, N'PR001108152', N'Timothy Martin', N'Masagca', N'M', N'Male', N'Administrator', N'HRD', N'11-06-2015', N'1    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (15, N'PR001108151', N'Jovelyn', N'Nogales', N'A', N'Female', N'Administrator', N'Administrator', N'11-12-2000', N'2    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (16, N'PR001108152', N'Timothy Martin', N'Masagca', N'M', N'Male', N'Administrator', N'HRD', N'11-06-2015', N'1    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (17, N'PR001108151', N'Jovelyn', N'Nogales', N'A', N'Female', N'Administrator', N'Administrator', N'11-12-2000', N'2    ')
GO
INSERT [dbo].[tbl_selUserRep] ([rep_id], [emp_id], [fn], [ln], [mi], [gr], [jp], [dp], [dh], [dn]) VALUES (18, N'PR001108152', N'Timothy Martin', N'Masagca', N'M', N'Male', N'Administrator', N'HRD', N'11-06-2015', N'1    ')
GO
SET IDENTITY_INSERT [dbo].[tbl_selUserRep] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

GO
INSERT [dbo].[tbl_user] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [philhealth], [pagibig], [TAX], [DIN], [basic_pay], [educ_loan], [province], [gsis_no], [bp_number], [lbp_number], [pol_number], [status], [status_date], [assigned_place], [deptid], [positionid], [createdon], [modifiedon]) VALUES (1, N'PL20170001', N'Firstname', N'F', N'Lastname', N'Male', CAST(0x000087BF00000000 AS DateTime), 22, N'1222222222', N'email@d.com', N'Baguio', N'Administrator', N'Accounting and finance', CAST(0x0000A72300000000 AS DateTime), N'Single', 0, N'11-1111111111-1', N'1111-1111-1111', N'221-225-000', N'111-111-111', CAST(20555.00 AS Decimal(12, 2)), N'YES', N'Benguet', N'11-1111111111-1', N'2222-2222-1111', N'1111-1111-1111', N'1111-1111-1111', N'Active', CAST(0x0000000000000000 AS DateTime), N'Baguio', 2, 1002, CAST(0x0000A72300F5EA7C AS DateTime), CAST(0x0000A723010F653A AS DateTime))
GO
INSERT [dbo].[tbl_user] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [philhealth], [pagibig], [TAX], [DIN], [basic_pay], [educ_loan], [province], [gsis_no], [bp_number], [lbp_number], [pol_number], [status], [status_date], [assigned_place], [deptid], [positionid], [createdon], [modifiedon]) VALUES (2, N'PL20170002', N'Bryann', N'F', N'Quejadas', N'Male', CAST(0x00007D7500000000 AS DateTime), 29, N'112222222', N'email@ede.com', N'Baguio', N'Web Developer', N'Information Department', CAST(0x0000A72300000000 AS DateTime), N'Married', 0, N'33-4567677888-9', N'2334-4444-4567', N'221-225-001', N'567-990-433', CAST(87005.00 AS Decimal(12, 2)), N'YES', N'Ifugao', N'34-666666789--0', N'2333-4234-6523', N'2334-345363663', N'232323242-4252', N'Active', CAST(0x0000000000000000 AS DateTime), N'Ifugao', 1, 5, CAST(0x0000A723010EDC10 AS DateTime), CAST(0x0000A723010EDC10 AS DateTime))
GO
INSERT [dbo].[tbl_user] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [philhealth], [pagibig], [TAX], [DIN], [basic_pay], [educ_loan], [province], [gsis_no], [bp_number], [lbp_number], [pol_number], [status], [status_date], [assigned_place], [deptid], [positionid], [createdon], [modifiedon]) VALUES (3, N'PL20170003', N'Reyan', N'W', N'Terrado', N'Male', CAST(0x00008C7800000000 AS DateTime), 18, N'3', N'rey@mail.com', N'sdasdadasdadas', N'Admin.Aide I', N'Information Department', CAST(0x0000A73700000000 AS DateTime), N'Single', 0, N'33-3333333333-3', N'2333-2332-3232', N'221-225-002', N'111-111-111', CAST(45445.00 AS Decimal(12, 2)), N'YES', N'Benguet', N'22-2222222222-2', N'4333-3333-3333', N'4333-3333-3333', N'6666-6444-4333', N'Active', CAST(0x0000000000000000 AS DateTime), N'Rsda!!', 1, 1003, CAST(0x0000A73700D8A445 AS DateTime), CAST(0x0000A74D00BC0756 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_user2] ON 

GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (1, N'PR001108151              ', N'Jovelyn                  ', N'A                        ', N'Nogales                  ', N'Female    ', N'12-16-1995', N'20', N'+63935445456', N'jovy@gmail.com', N'Pasig, Philippines', N'Administrator            ', N'Administrator            ', N'11-12-2000', N'Single         ', N'4', N'78-6543216541-3', N'35-4654712354-6', N'2421-4215-4654', N'464-646-465', 2, N'8', N'10000                                             ', N'Yes', NULL, NULL, NULL, NULL, N'Active', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (2023, N'PL20160004               ', N'Pete                     ', N'M                        ', N'Pistol                   ', N'Male      ', N'12-05-1987', N'29', N'45464544646', N'pete@mail.com', N'Benguet', N'Programmer               ', N'IT                       ', N'12-05-2016', N'Widowed        ', N'2', N'44-4444444444-4', N'14-4444444444-4', N'4444-4444-4444', N'111-111-111', NULL, N'3', N'12000                                             ', N'Yes', N'Benguet', N'7879797987997', N'121212121', N'123123123123', N'Active', NULL, NULL, NULL, NULL, NULL, N'666649816')
GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (1023, N'PL20160003               ', N'Mary Ann                 ', N'A.                       ', N'Chua                     ', N'Female    ', N'6-01-1995', N'20', N'+639365684405', N'maryann@mybusybee.net', N'Ifugao City, Ifugao', N'Programmer               ', N'IT                       ', N'5-02-2016', N'Single         ', N'1', N'12-3256412316-4', N'65-4231654131-3', N'2315-6468-4465', N'123-132-155', NULL, N'8', N'15000                                             ', N'Yes', N'Ifugao', N'2', N'2', N'2', N'Active', NULL, NULL, NULL, NULL, NULL, N'213364667')
GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (2024, N'PL20170004               ', N'Bryann                   ', N'F                        ', N'Quejadas                 ', N'Male      ', N'12-08-1987', N'29', N'09151590086', N'bryan@mybusybee.net', N'Baguio City', N'Programmer               ', N'IT                       ', N'1-05-2017', N'Married        ', N'0', NULL, N'22-2111233333-3', N'1112-2334-4556', N'223-242-555', NULL, N'', N'12000                                             ', N'Yes', N'Benguet', N'2323242', N'232323', N'232323', N'Active', NULL, NULL, NULL, NULL, N'Atok', N'233111111')
GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (2025, N'PL20170005               ', N'Bry                      ', N'r                        ', N'Busybee                  ', N'Female    ', N'12-01-2009', N'7', N'232', N'email@mail.com', N'Benguet', N'Programmer               ', N'IT                       ', N'1-26-2017', N'Married        ', N'2', NULL, N'00-0000000000-0', N'0000-0000-0000', N'000-400-000', NULL, N'', N'12000                                             ', N'Yes', N'Benguet', N'2', N'3', N'2', N'Active', NULL, NULL, NULL, NULL, N'Benguet', N'14000000000')
GO
INSERT [dbo].[tbl_user2] ([user_id], [emp_id], [first_name], [middle_name], [last_name], [gender], [b_date], [age], [c_no], [email], [address], [job_pos], [dept], [date_hired], [marital_status], [dependents], [SSS], [philhealth], [pagibig], [TAX], [DIN], [hr_pr_day], [basic_pay], [educ_loan], [province], [bp_number], [lbp_number], [pol_number], [status], [date_retired], [date_terminated], [date_resigned], [date_separated], [assigned_place], [gsis_no]) VALUES (2026, N'PL20170006               ', N'Sda                      ', N'f                        ', N'sda                      ', N'Female    ', N'12-26-1987', N'29', N'1', N'email@csd.com', N'sdsdsd', N'Programmer               ', N'IT                       ', N'1-26-2017', N'Single         ', N'1', NULL, N'11-1212121212-1', N'1212-1212-1212', N'444-444-444', NULL, N'', N'12000                                             ', N'Yes', N'Benguet', N'1', N'1', N'1', N'Active', NULL, NULL, NULL, NULL, N'sdsdsd', N'44444444444')
GO
SET IDENTITY_INSERT [dbo].[tbl_user2] OFF
GO
SET IDENTITY_INSERT [dbo].[tDepartment] ON 

GO
INSERT [dbo].[tDepartment] ([ID], [DeptName], [createdon], [modifiedon]) VALUES (1, N'Information Department', CAST(0x0000A71D00F9FCD0 AS DateTime), CAST(0x0000A71D00F9FCD0 AS DateTime))
GO
INSERT [dbo].[tDepartment] ([ID], [DeptName], [createdon], [modifiedon]) VALUES (2, N'Accounting and finance', CAST(0x0000A71D00FA0A9D AS DateTime), CAST(0x0000A71D00FA0A9D AS DateTime))
GO
INSERT [dbo].[tDepartment] ([ID], [DeptName], [createdon], [modifiedon]) VALUES (3, N'Human Resources', CAST(0x0000A71D00FA1B70 AS DateTime), CAST(0x0000A71D00FA1B70 AS DateTime))
GO
INSERT [dbo].[tDepartment] ([ID], [DeptName], [createdon], [modifiedon]) VALUES (4, N'Sales and Account Executives', CAST(0x0000A71D00FA3158 AS DateTime), CAST(0x0000A71D00FA3158 AS DateTime))
GO
INSERT [dbo].[tDepartment] ([ID], [DeptName], [createdon], [modifiedon]) VALUES (1002, N'Finance and Accounting', CAST(0x0000A78900A03F71 AS DateTime), CAST(0x0000A78900A03F71 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tDepartment] OFF
GO
SET IDENTITY_INSERT [dbo].[tEarnedCredits] ON 

GO
INSERT [dbo].[tEarnedCredits] ([id], [emp_id], [slbalance], [vlbalance], [balance_date], [modifiedon], [createdon]) VALUES (1, N'PL20170001', CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), NULL, CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7BB0101F3A3 AS DateTime))
GO
INSERT [dbo].[tEarnedCredits] ([id], [emp_id], [slbalance], [vlbalance], [balance_date], [modifiedon], [createdon]) VALUES (2, N'PL20170002', CAST(10.25 AS Decimal(18, 2)), CAST(10.25 AS Decimal(18, 2)), NULL, CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7BB0101F3A3 AS DateTime))
GO
INSERT [dbo].[tEarnedCredits] ([id], [emp_id], [slbalance], [vlbalance], [balance_date], [modifiedon], [createdon]) VALUES (3, N'PL20170003', CAST(4.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), NULL, CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7BB0101F3A3 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tEarnedCredits] OFF
GO
SET IDENTITY_INSERT [dbo].[tLeave] ON 

GO
INSERT [dbo].[tLeave] ([l_id], [emp_id], [leave_type], [no_days], [no_paid], [start_date], [end_date], [slcredits], [vlcredits], [slearned], [vlearned], [sl_balance], [vl_balance], [remark], [modifiedon], [createdon]) VALUES (2, N'PL20170001', N'Sick', N'2', N'2', CAST(0x0000A7BB0101DE10 AS DateTime), CAST(0x0000A7BD0101DE10 AS DateTime), CAST(2.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), NULL, NULL, N'SL', CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7BB0101F3A3 AS DateTime))
GO
INSERT [dbo].[tLeave] ([l_id], [emp_id], [leave_type], [no_days], [no_paid], [start_date], [end_date], [slcredits], [vlcredits], [slearned], [vlearned], [sl_balance], [vl_balance], [remark], [modifiedon], [createdon]) VALUES (3, N'PL20170001', N'Vacation', N'2', N'2', CAST(0x0000A7BB0101DE10 AS DateTime), CAST(0x0000A7BD0101DE10 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), NULL, NULL, N'VL', CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7BB0101F3A3 AS DateTime))
GO
INSERT [dbo].[tLeave] ([l_id], [emp_id], [leave_type], [no_days], [no_paid], [start_date], [end_date], [slcredits], [vlcredits], [slearned], [vlearned], [sl_balance], [vl_balance], [remark], [modifiedon], [createdon]) VALUES (4, N'PL20170001', N'Sick', N'0', N'0', CAST(0x0000A7060101DE10 AS DateTime), CAST(0x0000A7080101DE10 AS DateTime), CAST(0.12 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), NULL, NULL, N'SL', CAST(0x0000A7BB0101F3A3 AS DateTime), CAST(0x0000A7060101F3A3 AS DateTime))
GO
INSERT [dbo].[tLeave] ([l_id], [emp_id], [leave_type], [no_days], [no_paid], [start_date], [end_date], [slcredits], [vlcredits], [slearned], [vlearned], [sl_balance], [vl_balance], [remark], [modifiedon], [createdon]) VALUES (5, N'PL20170001', N'Sick', N'2/23/2017 12:00:00 AM', N'08/02/2017', CAST(0x0000A7C300C5BD7C AS DateTime), CAST(0x0000A7C900C5BD7C AS DateTime), CAST(3.50 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, N'SL for August', CAST(0x0000A7C200C5FE20 AS DateTime), CAST(0x0000A7C200C5FE20 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tLeave] OFF
GO
SET IDENTITY_INSERT [dbo].[tLoan] ON 

GO
INSERT [dbo].[tLoan] ([ID], [EmployeeID], [LastName], [FirstName], [Status], [basicPay], [gsis_ouli], [gsis_ec], [gsis_ee], [gsis_er], [gsis_cl_remarks], [gsis_cl_totalpay], [gsis_cl_totalAm], [gsis_cl_monAm], [gsis_cl_paidAm], [gsis_cl_balance], [gsis_cloan], [gsis_cl_end], [gsis_cl_start], [gsis_cl_gdate], [gsis_el_remarks], [gsis_el_totalpay], [gsis_el_totalAm], [gsis_el_monAm], [gsis_el_paidAm], [gsis_el_balance], [gsis_eloan], [gsis_el_end], [gsis_el_start], [gsis_el_gdate], [gsis_pl_remarks], [gsis_pl_totalpay], [gsis_pl_totalAm], [gsis_pl_monAm], [gsis_pl_paidAm], [gsis_pl_balance], [gsis_ploan], [gsis_pl_end], [gsis_pl_start], [gsis_pl_gdate], [gsis_edu_remarks], [gsis_edu_totalpay], [gsis_edu_totalAm], [gsis_edu_monAm], [gsis_edu_paidAm], [gsis_edu_balance], [gsis_eduloan], [gsis_edu_end], [gsis_edu_start], [gsis_edu_gdate], [hdmf_hs_remarks], [hdmf_hs_totalpay], [hdmf_hs_totalAm], [hdmf_hs_monAm], [hdmf_hs_paidAm], [hdmf_hs_balance], [hdmf_hsloan], [hdmf_hs_end], [hdmf_hs_start], [hdmf_hs_gdate], [hdmf_mp_remarks], [hdmf_mp_totalpay], [hdmf_mp_totalAm], [hdmf_mp_monAm], [hdmf_mp_paidAm], [hdmf_mp_balance], [hdmf_mploan], [hdmf_mp_end], [hdmf_mp_start], [hdmf_mp_gdate], [lbp_totalpay], [lbp_totalAm], [lbp_monAm], [lbp_balance], [lbp_gloan], [lbp_paidAm], [lbp_end], [lbp_start], [lbp_gdate], [lbp_remarks], [ncipea_mandatory], [ncipea_amount], [ncipea_totalpay], [ncipea_totalAm], [ncipea_monAm], [ncipea_loan], [ncipea_balance], [ncipea_paidAm], [ncipea_end], [ncipea_start], [ncipea_gdate], [ncipea_remarks], [phic_ee], [phic_er], [hdmf_ee], [wt_amount], [hdmf_er], [createdon], [modifiedon]) VALUES (1, N'PL20170002', N'Quejadas', N'Bryann', N'Active', CAST(87005.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(50000.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50000.00 AS Decimal(12, 2)), CAST(0x0000A7BE00000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A7AC00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), CAST(0x0000A7AD00000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)), CAST(0x0000A7AD01139681 AS DateTime), CAST(0x0000A7B5011D6014 AS DateTime))
GO
INSERT [dbo].[tLoan] ([ID], [EmployeeID], [LastName], [FirstName], [Status], [basicPay], [gsis_ouli], [gsis_ec], [gsis_ee], [gsis_er], [gsis_cl_remarks], [gsis_cl_totalpay], [gsis_cl_totalAm], [gsis_cl_monAm], [gsis_cl_paidAm], [gsis_cl_balance], [gsis_cloan], [gsis_cl_end], [gsis_cl_start], [gsis_cl_gdate], [gsis_el_remarks], [gsis_el_totalpay], [gsis_el_totalAm], [gsis_el_monAm], [gsis_el_paidAm], [gsis_el_balance], [gsis_eloan], [gsis_el_end], [gsis_el_start], [gsis_el_gdate], [gsis_pl_remarks], [gsis_pl_totalpay], [gsis_pl_totalAm], [gsis_pl_monAm], [gsis_pl_paidAm], [gsis_pl_balance], [gsis_ploan], [gsis_pl_end], [gsis_pl_start], [gsis_pl_gdate], [gsis_edu_remarks], [gsis_edu_totalpay], [gsis_edu_totalAm], [gsis_edu_monAm], [gsis_edu_paidAm], [gsis_edu_balance], [gsis_eduloan], [gsis_edu_end], [gsis_edu_start], [gsis_edu_gdate], [hdmf_hs_remarks], [hdmf_hs_totalpay], [hdmf_hs_totalAm], [hdmf_hs_monAm], [hdmf_hs_paidAm], [hdmf_hs_balance], [hdmf_hsloan], [hdmf_hs_end], [hdmf_hs_start], [hdmf_hs_gdate], [hdmf_mp_remarks], [hdmf_mp_totalpay], [hdmf_mp_totalAm], [hdmf_mp_monAm], [hdmf_mp_paidAm], [hdmf_mp_balance], [hdmf_mploan], [hdmf_mp_end], [hdmf_mp_start], [hdmf_mp_gdate], [lbp_totalpay], [lbp_totalAm], [lbp_monAm], [lbp_balance], [lbp_gloan], [lbp_paidAm], [lbp_end], [lbp_start], [lbp_gdate], [lbp_remarks], [ncipea_mandatory], [ncipea_amount], [ncipea_totalpay], [ncipea_totalAm], [ncipea_monAm], [ncipea_loan], [ncipea_balance], [ncipea_paidAm], [ncipea_end], [ncipea_start], [ncipea_gdate], [ncipea_remarks], [phic_ee], [phic_er], [hdmf_ee], [wt_amount], [hdmf_er], [createdon], [modifiedon]) VALUES (2, N'PL20170003', N'Terrado', N'Reyan', N'Active', CAST(45445.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(9000.00 AS Decimal(12, 2)), CAST(12000.00 AS Decimal(12, 2)), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(50000.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50000.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), CAST(0x0000A74400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)), CAST(0x0000A7A100B855AC AS DateTime), CAST(0x0000A7B5011D68D2 AS DateTime))
GO
INSERT [dbo].[tLoan] ([ID], [EmployeeID], [LastName], [FirstName], [Status], [basicPay], [gsis_ouli], [gsis_ec], [gsis_ee], [gsis_er], [gsis_cl_remarks], [gsis_cl_totalpay], [gsis_cl_totalAm], [gsis_cl_monAm], [gsis_cl_paidAm], [gsis_cl_balance], [gsis_cloan], [gsis_cl_end], [gsis_cl_start], [gsis_cl_gdate], [gsis_el_remarks], [gsis_el_totalpay], [gsis_el_totalAm], [gsis_el_monAm], [gsis_el_paidAm], [gsis_el_balance], [gsis_eloan], [gsis_el_end], [gsis_el_start], [gsis_el_gdate], [gsis_pl_remarks], [gsis_pl_totalpay], [gsis_pl_totalAm], [gsis_pl_monAm], [gsis_pl_paidAm], [gsis_pl_balance], [gsis_ploan], [gsis_pl_end], [gsis_pl_start], [gsis_pl_gdate], [gsis_edu_remarks], [gsis_edu_totalpay], [gsis_edu_totalAm], [gsis_edu_monAm], [gsis_edu_paidAm], [gsis_edu_balance], [gsis_eduloan], [gsis_edu_end], [gsis_edu_start], [gsis_edu_gdate], [hdmf_hs_remarks], [hdmf_hs_totalpay], [hdmf_hs_totalAm], [hdmf_hs_monAm], [hdmf_hs_paidAm], [hdmf_hs_balance], [hdmf_hsloan], [hdmf_hs_end], [hdmf_hs_start], [hdmf_hs_gdate], [hdmf_mp_remarks], [hdmf_mp_totalpay], [hdmf_mp_totalAm], [hdmf_mp_monAm], [hdmf_mp_paidAm], [hdmf_mp_balance], [hdmf_mploan], [hdmf_mp_end], [hdmf_mp_start], [hdmf_mp_gdate], [lbp_totalpay], [lbp_totalAm], [lbp_monAm], [lbp_balance], [lbp_gloan], [lbp_paidAm], [lbp_end], [lbp_start], [lbp_gdate], [lbp_remarks], [ncipea_mandatory], [ncipea_amount], [ncipea_totalpay], [ncipea_totalAm], [ncipea_monAm], [ncipea_loan], [ncipea_balance], [ncipea_paidAm], [ncipea_end], [ncipea_start], [ncipea_gdate], [ncipea_remarks], [phic_ee], [phic_er], [hdmf_ee], [wt_amount], [hdmf_er], [createdon], [modifiedon]) VALUES (1002, N'PL20170001', N'Lastname', N'Firstname', N'Active', CAST(20555.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(50000.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50000.00 AS Decimal(12, 2)), CAST(0x0000A76800000000 AS DateTime), CAST(0x0000A76800000000 AS DateTime), CAST(0x0000A76800000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), CAST(0x0000A7B400000000 AS DateTime), N'', CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)), CAST(0x0000A7B40101D374 AS DateTime), CAST(0x0000A7B5011D191A AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tLoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tMontWTax] ON 

GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (1, N'S/ME', N'0', CAST(4167.00 AS Decimal(12, 2)), CAST(5000.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (2, N'S/ME', N'0', CAST(5000.00 AS Decimal(12, 2)), CAST(6667.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(41.67 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (3, N'S/ME', N'0', CAST(6667.00 AS Decimal(12, 2)), CAST(10000.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(208.83 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (4, N'S/ME', N'0', CAST(10000.00 AS Decimal(12, 2)), CAST(15833.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(708.33 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (5, N'S/ME', N'0', CAST(15833.00 AS Decimal(12, 2)), CAST(25000.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(1875.00 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (6, N'S/ME', N'0', CAST(25000.00 AS Decimal(12, 2)), CAST(45833.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(4166.67 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (7, N'S/ME', N'0', CAST(45833.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(10416.67 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (8, N'ME1 / S1', N'1', CAST(6250.00 AS Decimal(12, 2)), CAST(7083.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (9, N'ME1 / S1', N'1', CAST(7083.00 AS Decimal(12, 2)), CAST(8750.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(41.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (10, N'ME1 / S1', N'1', CAST(8750.00 AS Decimal(12, 2)), CAST(12083.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(208.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (11, N'ME1 / S1', N'1', CAST(12083.00 AS Decimal(12, 2)), CAST(17917.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(708.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (12, N'ME1 / S1', N'1', CAST(17917.00 AS Decimal(12, 2)), CAST(27083.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(1875.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (13, N'ME1 / S1', N'1', CAST(27083.00 AS Decimal(12, 2)), CAST(47917.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(4166.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (14, N'ME1 / S1', N'1', CAST(47917.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(10416.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (15, N'ME2 / S2', N'2', CAST(8333.00 AS Decimal(12, 2)), CAST(9167.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (16, N'ME2 / S2', N'2', CAST(9167.00 AS Decimal(12, 2)), CAST(10833.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(41.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (17, N'ME2 / S2', N'2', CAST(10833.00 AS Decimal(12, 2)), CAST(14167.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(208.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (18, N'ME2 / S2', N'2', CAST(14167.00 AS Decimal(12, 2)), CAST(20000.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(708.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (19, N'ME2 / S2', N'2', CAST(20000.00 AS Decimal(12, 2)), CAST(29167.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(1875.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (20, N'ME2 / S2', N'2', CAST(29167.00 AS Decimal(12, 2)), CAST(50000.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(4166.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (21, N'ME2 / S2', N'2', CAST(50000.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(10416.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (22, N'ME3 / S3', N'3', CAST(10417.00 AS Decimal(12, 2)), CAST(11250.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (23, N'ME3 / S3', N'3', CAST(11250.00 AS Decimal(12, 2)), CAST(12917.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(41.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (24, N'ME3 / S3', N'3', CAST(12917.00 AS Decimal(12, 2)), CAST(16250.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(208.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (25, N'ME3 / S3', N'3', CAST(16250.00 AS Decimal(12, 2)), CAST(22083.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(708.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (26, N'ME3 / S3', N'3', CAST(22083.00 AS Decimal(12, 2)), CAST(31250.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(1875.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (27, N'ME3 / S3', N'3', CAST(31250.00 AS Decimal(12, 2)), CAST(52083.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(4166.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (28, N'ME3 / S3', N'3', CAST(52083.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(10416.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (29, N'ME4 / S4', N'4', CAST(12500.00 AS Decimal(12, 2)), CAST(13333.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (30, N'ME4 / S4', N'4', CAST(13333.00 AS Decimal(12, 2)), CAST(15000.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(41.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (31, N'ME4 / S4', N'4', CAST(15000.00 AS Decimal(12, 2)), CAST(18333.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(208.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (32, N'ME4 / S4', N'4', CAST(18333.00 AS Decimal(12, 2)), CAST(24167.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(708.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (33, N'ME4 / S4', N'4', CAST(24167.00 AS Decimal(12, 2)), CAST(33333.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(1875.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (34, N'ME4 / S4', N'4', CAST(33333.00 AS Decimal(12, 2)), CAST(54167.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(4166.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tMontWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (35, N'ME4 / S4', N'4', CAST(54167.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(10416.67 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tMontWTax] OFF
GO
SET IDENTITY_INSERT [dbo].[tPayroll] ON 

GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (45, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Jul 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(6972.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F874B0 AS DateTime), N'July', CAST(0x0000000000F89B5C AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F89D8F AS DateTime), CAST(0x0000A7B500F89D8F AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (46, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Jul 1-31 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(52886.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F8C208 AS DateTime), N'July', CAST(0x0000000000F8D144 AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B500F8D403 AS DateTime), CAST(0x0000A7B500F8D403 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (47, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Jul 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(24569.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F8F598 AS DateTime), N'July', CAST(0x0000000000F90600 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F909B4 AS DateTime), CAST(0x0000A7B500F909B4 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (48, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Aug 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(6972.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F95B8C AS DateTime), N'July', CAST(0x0000000000F95CB8 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F95D43 AS DateTime), CAST(0x0000A7B500F95D43 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (49, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Aug 1-31 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(52886.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F963C0 AS DateTime), N'July', CAST(0x0000000000F964EC AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B500F96533 AS DateTime), CAST(0x0000A7B500F96533 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (50, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Aug 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(24569.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F96618 AS DateTime), N'July', CAST(0x0000000000F96744 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F96762 AS DateTime), CAST(0x0000A7B500F96762 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (51, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Sep 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(6972.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F9BF28 AS DateTime), N'July', CAST(0x0000000000F9C054 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F9C0CF AS DateTime), CAST(0x0000A7B500F9C0CF AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (52, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Sep 1-30 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(52886.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F9C180 AS DateTime), N'July', CAST(0x0000000000F9C2AC AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B500F9C2CF AS DateTime), CAST(0x0000A7B500F9C2CF AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (53, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Sep 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(24569.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500F9C3D8 AS DateTime), N'July', CAST(0x0000000000F9C3D8 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500F9C4BE AS DateTime), CAST(0x0000A7B500F9C4BE AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (54, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Oct 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(6972.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FA0B54 AS DateTime), N'July', CAST(0x0000000000FA0C80 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500FA0CEA AS DateTime), CAST(0x0000A7B500FA0CEA AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (55, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Oct 1-31 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(52886.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FA0DAC AS DateTime), N'July', CAST(0x0000000000FA0ED8 AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B500FA0EE8 AS DateTime), CAST(0x0000A7B500FA0EE8 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (56, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Oct 1-31 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(24569.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FA0ED8 AS DateTime), N'July', CAST(0x0000000000FA1004 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500FA10AC AS DateTime), CAST(0x0000A7B500FA10AC AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (59, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Nov 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(19472.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FEFE20 AS DateTime), N'July', CAST(0x0000000000FF08AC AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500FF1095 AS DateTime), CAST(0x0000A7B500FF1095 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (60, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Nov 1-30 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(65386.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FF9420 AS DateTime), N'July', CAST(0x0000000000FF9420 AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B500FF94BB AS DateTime), CAST(0x0000A7B500FF94BB AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (61, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Nov 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(37069.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B500FF9678 AS DateTime), N'July', CAST(0x0000000000FF9678 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B500FF96CF AS DateTime), CAST(0x0000A7B500FF96CF AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (62, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Nov 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(19472.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B5010CF584 AS DateTime), N'July', CAST(0x00000000010CF7DC AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B5010CFBAD AS DateTime), CAST(0x0000A7B5010CFBAD AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (63, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Nov 1-30 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(65386.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B5010D6730 AS DateTime), N'July', CAST(0x00000000010D6BE0 AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B5010D727D AS DateTime), CAST(0x0000A7B5010D727D AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (64, N'PL20170001', N'Firstname Lastname', N'Administrator', N'Accounting and finance', N'Nov 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(20555.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(20555.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3055.50 AS Decimal(12, 2)), CAST(19472.50 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B5011D0A50 AS DateTime), N'July', CAST(0x00000000011D0B7C AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B5011D0E50 AS DateTime), CAST(0x0000A7B5011D0E50 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (65, N'PL20170002', N'Bryann Quejadas', N'Web Developer', N'Information Department', N'Nov 1-30 2017', N'Married', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(87005.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(87005.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(1.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(23591.71 AS Decimal(12, 2)), CAST(65386.29 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B5011D28C8 AS DateTime), N'July', CAST(0x00000000011D29F4 AS DateTime), N'tDed', N'Ifugao', CAST(0x0000A7B5011D2C39 AS DateTime), CAST(0x0000A7B5011D2C39 AS DateTime))
GO
INSERT [dbo].[tPayroll] ([salary_id], [emp_id], [emp_name], [position], [department], [daterange], [civil_stat], [dependents], [rate_day], [rate_hour], [NH], [OT], [ND], [monthly_pay], [PERA], [Grosspay], [policy_loan], [e_card], [emergency_loan], [conso_loan], [pagibig_loan], [pagibig_housing], [ncipae_loan], [lbp_loan], [educ_loan], [uoli_cont], [gsis_social_cont], [ncipae_man_fee], [ncipae_mem_fee], [Philhealth], [Pagibig], [TAX], [net_pay], [additional_deductions], [status], [date_computed], [month_computed], [time_computed], [tDed], [province], [createdon], [modifiedon]) VALUES (66, N'PL20170003', N'Reyan Terrado', N'Admin.Aide I', N'Information Department', N'Nov 1-30 2017', N'Single', N'0', N'rate_day', N'rate_houre', N'0.00', N'0.00', N'0.00', CAST(45445.00 AS Decimal(12, 2)), CAST(2000.00 AS Decimal(12, 2)), CAST(45445.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)), CAST(10300.17 AS Decimal(12, 2)), CAST(37069.83 AS Decimal(12, 2)), N'addtional', N'0.00', CAST(0x0000A7B5011D6810 AS DateTime), N'July', CAST(0x00000000011D6810 AS DateTime), N'tDed', N'Benguet', CAST(0x0000A7B5011D68BC AS DateTime), CAST(0x0000A7B5011D68BC AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tPayroll] OFF
GO
SET IDENTITY_INSERT [dbo].[tPosition] ON 

GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (1, N'Chief Technology Officer', N'I', CAST(50000.00 AS Decimal(12, 2)), 1, N'Information Department', CAST(0x0000A71D00FA61FA AS DateTime), CAST(0x0000A7B700C3A0C7 AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (2, N'Web Developer', N'I', CAST(14000.00 AS Decimal(12, 2)), 1, N'Information Department', CAST(0x0000A71D00FA7315 AS DateTime), CAST(0x0000A7B700BFA98E AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (4, N'Mobile Developer', N'III', CAST(15000.00 AS Decimal(12, 2)), 1, N'Information Department', CAST(0x0000A71D00FAA015 AS DateTime), CAST(0x0000A7B700C32551 AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (5, N'Web Developer', N'I', CAST(15000.00 AS Decimal(12, 2)), 1, N'Information Department', CAST(0x0000A71D00FAAE6B AS DateTime), CAST(0x0000A71D00FAAE6B AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (6, N'Account Executive', N'IV', CAST(18000.00 AS Decimal(12, 2)), 4, N'Sales and Account Executives', CAST(0x0000A71D00FAD6A8 AS DateTime), CAST(0x0000A7B700BF7804 AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (1002, N'Administrator', N'I', CAST(150000.00 AS Decimal(12, 2)), 2, N'Accounting and finance', CAST(0x0000A723010F4C56 AS DateTime), CAST(0x0000A723010F4C56 AS DateTime))
GO
INSERT [dbo].[tPosition] ([ID], [PositionName], [SalaryGrade], [BasicPay], [DeptID], [DeptName], [createdon], [modifiedon]) VALUES (1003, N'Admin.Aide I', N'I', CAST(15000.00 AS Decimal(12, 2)), 1, N'Information Department', CAST(0x0000A74D00BBE4FA AS DateTime), CAST(0x0000A74D00BBE4FA AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tPosition] OFF
GO
SET IDENTITY_INSERT [dbo].[tSemiWTax] ON 

GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (1, N'S/ME', N'0', CAST(2083.00 AS Decimal(12, 2)), CAST(2500.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (2, N'S/ME', N'0', CAST(2500.00 AS Decimal(12, 2)), CAST(3333.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(20.83 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (3, N'S/ME', N'0', CAST(3333.00 AS Decimal(12, 2)), CAST(5000.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(104.17 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (4, N'S/ME', N'0', CAST(5000.00 AS Decimal(12, 2)), CAST(7917.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(354.17 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (5, N'S/ME', N'0', CAST(7917.00 AS Decimal(12, 2)), CAST(12500.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(937.50 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (6, N'S/ME', N'0', CAST(12500.00 AS Decimal(12, 2)), CAST(22917.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(2083.33 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (7, N'S/ME', N'0', CAST(22917.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(5208.33 AS Decimal(12, 2)), N'Single / Married Employee', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (8, N'ME1 / S1', N'1', CAST(3125.00 AS Decimal(12, 2)), CAST(3542.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (9, N'ME1 / S1', N'1', CAST(3542.00 AS Decimal(12, 2)), CAST(4375.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(20.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (10, N'ME1 / S1', N'1', CAST(4375.00 AS Decimal(12, 2)), CAST(6042.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(104.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (11, N'ME1 / S1', N'1', CAST(6042.00 AS Decimal(12, 2)), CAST(8958.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(354.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (12, N'ME1 / S1', N'1', CAST(8958.00 AS Decimal(12, 2)), CAST(13542.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(937.50 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (13, N'ME1 / S1', N'1', CAST(13542.00 AS Decimal(12, 2)), CAST(23958.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(2083.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (14, N'ME1 / S1', N'1', CAST(23958.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(5208.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 1 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (15, N'ME2 / S2', N'2', CAST(4167.00 AS Decimal(12, 2)), CAST(4583.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (16, N'ME2 / S2', N'2', CAST(4583.00 AS Decimal(12, 2)), CAST(5417.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(20.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (17, N'ME2 / S2', N'2', CAST(5417.00 AS Decimal(12, 2)), CAST(7083.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(104.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (18, N'ME2 / S2', N'2', CAST(7083.00 AS Decimal(12, 2)), CAST(10000.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(354.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (19, N'ME2 / S2', N'2', CAST(10000.00 AS Decimal(12, 2)), CAST(14583.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(937.50 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (20, N'ME2 / S2', N'2', CAST(14583.00 AS Decimal(12, 2)), CAST(25000.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(2083.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (21, N'ME2 / S2', N'2', CAST(25000.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(5208.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 2 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (22, N'ME3 / S3', N'3', CAST(5208.00 AS Decimal(12, 2)), CAST(5625.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (23, N'ME3 / S3', N'3', CAST(5625.00 AS Decimal(12, 2)), CAST(6458.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(20.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (24, N'ME3 / S3', N'3', CAST(6458.00 AS Decimal(12, 2)), CAST(8125.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(104.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (25, N'ME3 / S3', N'3', CAST(8125.00 AS Decimal(12, 2)), CAST(11042.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(354.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (26, N'ME3 / S3', N'3', CAST(11042.00 AS Decimal(12, 2)), CAST(15625.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(937.50 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (27, N'ME3 / S3', N'3', CAST(15625.00 AS Decimal(12, 2)), CAST(26042.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(2083.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (28, N'ME3 / S3', N'3', CAST(26042.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(5208.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 3 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (29, N'ME4 / S4', N'4', CAST(6250.00 AS Decimal(12, 2)), CAST(6667.00 AS Decimal(12, 2)), CAST(0.05 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (30, N'ME4 / S4', N'4', CAST(6667.00 AS Decimal(12, 2)), CAST(7500.00 AS Decimal(12, 2)), CAST(0.10 AS Decimal(12, 2)), CAST(20.83 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (31, N'ME4 / S4', N'4', CAST(7500.00 AS Decimal(12, 2)), CAST(9167.00 AS Decimal(12, 2)), CAST(0.15 AS Decimal(12, 2)), CAST(104.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (32, N'ME4 / S4', N'4', CAST(9167.00 AS Decimal(12, 2)), CAST(12083.00 AS Decimal(12, 2)), CAST(0.20 AS Decimal(12, 2)), CAST(354.17 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (33, N'ME4 / S4', N'4', CAST(12083.00 AS Decimal(12, 2)), CAST(16667.00 AS Decimal(12, 2)), CAST(0.25 AS Decimal(12, 2)), CAST(937.50 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (34, N'ME4 / S4', N'4', CAST(16667.00 AS Decimal(12, 2)), CAST(27083.00 AS Decimal(12, 2)), CAST(0.30 AS Decimal(12, 2)), CAST(2083.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
INSERT [dbo].[tSemiWTax] ([wTax_Id], [status], [dependent], [compensation1], [compensation2], [overam], [exemption], [remarks], [createdon], [modifiedon]) VALUES (35, N'ME4 / S4', N'4', CAST(27083.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(5208.33 AS Decimal(12, 2)), N'Married Employee / Single w/ 4 dependent', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[tSemiWTax] OFF
GO
SET IDENTITY_INSERT [dbo].[tService] ON 

GO
INSERT [dbo].[tService] ([ID], [EmployeeID], [Designation], [AppointmentStatus], [MonthlySalary], [AnnualSalary], [OfficeAssignment], [Remarks], [FromDate], [ToDate], [createdon], [modifiedon]) VALUES (1, N'2', N'Lab Aide. II', N'Permanent', CAST(2250.00 AS Decimal(12, 2)), CAST(27000.00 AS Decimal(12, 2)), N'SDSDSDSDS', N'Original Appointment', CAST(0x000081B200000000 AS DateTime), CAST(0x0000A72700000000 AS DateTime), CAST(0x0000A72700E85C3E AS DateTime), CAST(0x0000A72800E7D28C AS DateTime))
GO
INSERT [dbo].[tService] ([ID], [EmployeeID], [Designation], [AppointmentStatus], [MonthlySalary], [AnnualSalary], [OfficeAssignment], [Remarks], [FromDate], [ToDate], [createdon], [modifiedon]) VALUES (2, N'2', N'Lab Aide II', N'Permanent', CAST(3750.00 AS Decimal(12, 2)), CAST(45000.00 AS Decimal(12, 2)), N'Ifugao IIIII', N'DBM-CSC Circ #1', CAST(0x0000819900000000 AS DateTime), CAST(0x0000861C00000000 AS DateTime), CAST(0x0000A72700EBE2F0 AS DateTime), CAST(0x0000A72800E7EAE2 AS DateTime))
GO
INSERT [dbo].[tService] ([ID], [EmployeeID], [Designation], [AppointmentStatus], [MonthlySalary], [AnnualSalary], [OfficeAssignment], [Remarks], [FromDate], [ToDate], [createdon], [modifiedon]) VALUES (3, N'1', N'Desig 1I', N'Tempory', CAST(1500.00 AS Decimal(12, 2)), CAST(30000.00 AS Decimal(12, 2)), N'Baguio', N'optional post', CAST(0x0000A59A00000000 AS DateTime), CAST(0x0000A72700000000 AS DateTime), CAST(0x0000A72700ED2E9E AS DateTime), CAST(0x0000A72700ED2E9E AS DateTime))
GO
INSERT [dbo].[tService] ([ID], [EmployeeID], [Designation], [AppointmentStatus], [MonthlySalary], [AnnualSalary], [OfficeAssignment], [Remarks], [FromDate], [ToDate], [createdon], [modifiedon]) VALUES (1002, N'2', N'1', N'Tempory', CAST(233.00 AS Decimal(12, 2)), CAST(3444.00 AS Decimal(12, 2)), N'zxc', N'zxczxc', CAST(0x0000A74B00000000 AS DateTime), CAST(0x0000A75F00000000 AS DateTime), CAST(0x0000A75F00A89089 AS DateTime), CAST(0x0000A75F00A89089 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tService] OFF
GO
USE [master]
GO
ALTER DATABASE [payroll_db] SET  READ_WRITE 
GO
