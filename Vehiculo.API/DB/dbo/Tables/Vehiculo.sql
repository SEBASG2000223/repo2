CREATE TABLE [dbo].[Vehiculo] (
    [Id]                  UNIQUEIDENTIFIER NOT NULL,
    [IdModelo]            UNIQUEIDENTIFIER NOT NULL,
    [Placa]               VARCHAR (MAX)    NOT NULL,
    [Color]               VARCHAR (MAX)    NOT NULL,
    [Precio]              INT              NOT NULL,
    [Anio]                DECIMAL (18)     NOT NULL,
    [CorreoPropietario]   VARCHAR (MAX)    NOT NULL,
    [TelefonoPropietario] VARCHAR (MAX)    NOT NULL,
    CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

