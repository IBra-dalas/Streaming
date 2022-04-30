

CREATE TABLE [dbo].[Documents]
(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(100),
	DocumentContent VARBINARY(5000),
	Extension VARCHAR(5)
)