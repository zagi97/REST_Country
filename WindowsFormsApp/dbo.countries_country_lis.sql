﻿CREATE TABLE [dbo].[countries_country_lis]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NULL, 
    [code] VARCHAR(50) NULL, 
    [long] FLOAT NULL, 
    [lat] FLOAT NULL, 
    [capital] VARCHAR(50) NULL, 
    [population] INT NULL, 
    [area] FLOAT NULL, 
    [region] VARCHAR(50) NULL
)
