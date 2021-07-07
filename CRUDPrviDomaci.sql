USE TSQL2012;
GO

--READ

CREATE OR ALTER PROC Production.SelectSuppliers
AS
SET LOCK_TIMEOUT 3000; --max 3 sec za wait
BEGIN TRY
	SELECT *
	FROM Production.Suppliers
	ORDER BY supplierid
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO


--INSERT

CREATE OR ALTER PROC Production.InsertSuppliers
@companyname nvarchar(40), @contactname nvarchar(30), @contacttitle nvarchar(30),
@address nvarchar(60), @city nvarchar(15), @region nvarchar(15), @postalcode nvarchar(10), @country nvarchar(15), 
@phone nvarchar(24), @fax nvarchar(24) 
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	INSERT INTO Production.Suppliers(companyname, contactname, contacttitle, address, city, region, postalcode, country, phone, fax)
	VALUES(@companyname, @contactname, @contacttitle, @address, @city, @region, @postalcode, @country, @phone, @fax)
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO





--DELETE

CREATE OR ALTER PROC Production.DeleteSuppliers
@supplierid int
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	DELETE FROM Production.Suppliers 
	WHERE supplierid = @supplierid
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO




--UPDATE
CREATE OR ALTER PROC Production.UpdateSuppliers
@supplierid int,@companyname nvarchar(40), @contactname nvarchar(30), @contacttitle nvarchar(30),
@address nvarchar(60), @city nvarchar(15), @region nvarchar(15), @postalcode nvarchar(10), @country nvarchar(15), 
@phone nvarchar(24), @fax nvarchar(24) 
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	UPDATE Production.Suppliers
	SET companyname = @companyname, contactname = @contactname, contacttitle = @contacttitle,  address = @address, city = @city, region = @region, postalcode = @postalcode, country = @country, phone = @phone, fax = @fax
	WHERE supplierid = @supplierid
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO