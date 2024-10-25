USE BookShopDB
GO

-- Insert Data Into [tblUser]

INSERT INTO tblUser ( userName, userPassword) 
VALUES ('admin', 'admin')
GO

SELECT * FROM tblUser
GO 


-- Insert Data Into [tblGender]

INSERT INTO tblGender VALUES
('1', 'Male'),
('2', 'Female')
GO

SELECT * FROM tblGender
GO

INSERT INTO tblBooKCategory VALUES
('1', 'Novels'),
('2', 'Story Books'),
('3', 'Poem'),
('4', 'Autobiography'),
('5', 'Islamic Books'),
('6', 'Science Fiction'),
('7', 'Computer and Internet'),
('8', 'Historical')
GO

SELECT * FROM tblBooKCategory
GO









