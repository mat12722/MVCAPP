CREATE TABLE [dbo].[Employee] (
    [Id]           INT            NOT NULL,
    [EmployeeId]   INT            NOT NULL,
    [FirstName]    NVARCHAR (50)  NULL,
    [LastName]    NVARCHAR (50)  NULL,
    [EmailAddress] NVARCHAR (100) NULL,
    [Password]     NCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

