CREATE TABLE [dbo].[patient] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [patient_Name]          VARCHAR (255) NOT NULL,
    [patient_Illness]      VARCHAR (255) NOT NULL,
    [patient_contactNumber] VARCHAR (50)  NOT NULL, 
    [patient_gender] VARCHAR(50) NOT NULL
);

