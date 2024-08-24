--SELECT I.Id AS Id, item_Name AS Name, item_Quantity AS Quantity, created_date AS CreatedDate, item_description AS Description,C.Id AS CatId,C.code AS Code,C.name AS CatName FROM inventory AS I INNER JOIN category AS C ON C.Id = I.FK_category_id

SELECT code FROM category;
"INSERT INTO inventory (item_Name, item_Quantity, FK_category_id, item_description) " +  "VALUES (@itemName, @itemQuantity, @FK_category_id, @itemDescription)";