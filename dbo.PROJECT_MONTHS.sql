﻿CREATE TABLE [dbo].[PROJECT_MONTHS]
(
	[PROJECT_MONTH_ID] NUMERIC NOT NULL PRIMARY KEY, 
    [PROJECT_ID] NUMERIC NOT NULL, 
    [PROJECT_YEAR] NUMERIC NOT NULL, 
    [PROJECT_MONTH] NUMERIC NOT NULL, 
    [PROJECT_MONTH_STATUS] CHAR NOT NULL 
)
