﻿CREATE TABLE [dbo].[Employees] (
    [EMPLOYEE_ID]       NUMERIC (18) NOT NULL,
    [EMPLOYEE_EGN]      VARCHAR (10) NOT NULL,
    [EMPLOYEE_NAME]     VARCHAR (50) NOT NULL,
    [EMPLOYEE_SURNAME]  VARCHAR (50) NOT NULL,
    [EMPLOYEE_LASTNAME] VARCHAR (50) NULL,
    [EMPLOYEE_POSITION] VARCHAR (50) NULL,
    [EMPLOYEE_HIREDATE] DATE         NULL,
    PRIMARY KEY CLUSTERED ([EMPLOYEE_ID] ASC)
);

