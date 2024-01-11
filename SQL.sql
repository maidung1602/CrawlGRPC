CREATE Database CrawledData
GO
USE CrawledData;

CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Url VARCHAR(255) NOT NULL
);

-- Articles table
CREATE TABLE Articles (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Content TEXT NOT NULL,
    CategoryId INT NOT NULL,
    Page INT NOT NULL DEFAULT 1,
    Url VARCHAR(255) NOT NULL,
    CreatedAtUTC DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);