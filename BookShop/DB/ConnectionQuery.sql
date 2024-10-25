USE BookShopDB
GO

-- PassWord SQLCmmand

SELECT * FROM tblUser WHERE userName = '' AND userPassword = ''
GO


SELECT * FROM tblGender
GO


SELECT * FROM tblAuthors
GO

SELECT authorID FROM tblAuthors
GO

-- INSERT tblAuthors SQLCmmand

-- INSERT INTO tblAuthors(authorName, genderID, authorEmail, authorPhone, authorImage)VALUES()
-- GO

-- authorID SQLCmmand

SELECT authorID, authorName, genderID, authorEmail, authorPhone, authorImage FROM tblAuthors WHERE authorID =1
GO

-- UPDATE tblAuthors SQLCmmand

UPDATE tblAuthors SET authorName='', genderID ='', authorEmail='', authorPhone='', authorImage='' WHERE authorID = 1
GO

-- DELETE tblAuthors SQLCmmand

DELETE FROM tblAuthors WHERE authorID =1
GO

-- INSERT INTO tblAuthors(authorName, genderID, authorEmail, authorPhone, authorImage)VALUES()

SELECT a.authorID,  a.authorName, g.genderType, a.authorEmail, a.authorPhone, a.authorImage FROM tblAuthors a INNER JOIN tblGender g ON a.genderID = g.genderID
GO

Select * FROM tblPublishers
GO


Select * FROM tblCustomers
GO

Select * FROM tblBooks
GO

SELECT b.bookName, c.categoryType, a.authorName, p.publisherName, b.bookPrice, b.bookAvailable FROM tblBooks b INNER JOIN tblBookCategory c ON b.categoryID = c.categoryID INNER JOIN tblAuthors a ON a.authorID = b.authorID INNER JOIN tblPublishers p ON p.publisherID = b.publisherID
GO