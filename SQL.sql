SELECT * FROM product 
LEFT JOIN connection_prod_cat ON product.Id=connection_prod_cat.prodID 
LEFT JOIN category ON category.Id=connection_prod_cat.catID