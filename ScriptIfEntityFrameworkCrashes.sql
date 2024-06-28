--Teoricamente o entity framework deve conseguir criar o banco automaticamente. Use essa query somente em caso de problema

CREATE SCHEMA custome_schema;

CREATE TABLE custome_schema.TBPRODUCT (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(250) NOT NULL,
    Description VARCHAR(250) NOT NULL,
    Price DOUBLE PRECISION NOT NULL,
    InStock INTEGER NOT NULL
);

CREATE TABLE custome_schema.TBCLIENT (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(250) NOT NULL,
    Address VARCHAR(250) NOT NULL,
    Phone VARCHAR(250) NOT NULL,
    Email VARCHAR(250) NOT NULL
);

CREATE TABLE custome_schema.TBSALE (
    Id SERIAL PRIMARY KEY,
    ProductId INTEGER NOT NULL,
    ClientId INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES custome_schema.TBPRODUCT(Id),
    FOREIGN KEY (ClientId) REFERENCES custome_schema.TBCLIENT(Id)
);