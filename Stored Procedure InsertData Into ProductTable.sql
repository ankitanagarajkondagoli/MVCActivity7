CREATE PROC usp_InsertIntoProduct(@ProductName nvarchar(50),@ProductGroupName nvarchar(50),@ProductModifiedDate datetime)
AS
BEGIN
BEGIN TRY
IF @ProductName IS NOT NULL
BEGIN
IF @ProductGroupName IS NOT NULL
BEGIN
IF @ProductModifiedDate IS NOT NULL
BEGIN
INSERT INTO Product(Name,GroupName,ModifiedDate) VALUES(@ProductName,@ProductGroupName,@ProductModifiedDate)
RETURN 1
END
Else
RETURN -3
END
ELSE
RETURN -2
END
RETURN -1
END TRY
BEGIN CATCH
RETURN -99
END CATCH
END