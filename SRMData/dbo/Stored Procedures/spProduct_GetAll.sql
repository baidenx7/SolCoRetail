﻿CREATE PROCEDURE [dbo].[spProduct_GetAll]

AS
Begin
	set nocount on;
	Select Id, ProductName, [Description], RetailPrice, QuantityInStock 
	From dbo.Product 
	order by ProductName
End
