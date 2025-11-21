using static System.Console;  
using static LINQ_ProlemSolving.Data.DataLists;  
#region Easy
#region 1. Retrieve all products with a unit price greater than $50.


//var products = Products.Where(p => p.UnitPrice > 50);
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}

#endregion

#region 2. List the names of all customers from London.
//var customersFromLondon = Customers.Where(c => c.City == "London")
//                                   .Select(c=> c.CompanyName);

//foreach (var customer in customersFromLondon)
//{
//    Console.WriteLine(customer);
//}

#endregion

#region 3. Find all orders shipped by "Speedy Express".
//var orders = Orders.Join(Shippers,
//         order => order.ShipperID,
//          shipper => shipper.ShipperID,
//          (order, shipper) => new
//          {
//              Order = order,
//              Shipper = shipper
//          }).Where(s => s.Shipper.CompanyName == "Speedy Express").Select(s => s.Order);


//foreach (var order in orders)
//{
//    Console.WriteLine(order);
//}

#endregion

#region 4. Get the total number of orders placed by customer "BONAP".

//var customers= Customers.Join(Orders,
//        customer=> customer.CustomerID,
//        order => order.CustomerID,
//        (customer,order) => new 
//        {
//            customer = customer,
//            order = order

//        }).Where(c => c.customer.CustomerID == "BONAP").Count();
   
//    WriteLine($"Total orders placed by customer 'BONAP': {customers}");

#endregion

#region 5. List all employees who are managers.
#endregion

#region 6. Find products that are discontinued.
#endregion

#region 7. Retrieve the names and phone numbers of all suppliers.
#endregion

#region 8. Get all orders placed in the year 1997.
#endregion

#region 9. Find all customers in the "USA".
#endregion

#region 10. List products that belong to category "Beverages".
#endregion

#region 11. Retrieve orders with a freight cost less than 20.
#endregion

#region 12. Get the names and titles of all employees.
#endregion

#region 13. Find suppliers from "Germany".
#endregion

#region 14. List all products with quantities between 10 and 50.
#endregion

#region 15. Retrieve orders that were shipped but not yet delivered.
#endregion

#region 16. Get the total number of products in each category.
#endregion

#region 17. List all orders placed by employee with ID 5.
#endregion

#region 18. Find the name of the supplier with the highest ID.
#endregion

#region 19. Retrieve products that have "box" in their quantity per unit description.
#endregion

#region 20. List all customers from "Germany".
#endregion

#region 21. Find all products that have never been ordered.
#endregion

#region 22. Get all orders with a freight cost greater than 50.
#endregion

#region 23. Retrieve names of all categories.
#endregion

#region 24. List all orders where the ship city is "Mannheim".
#endregion

#region 25. Find the employees who have "Sales" in their title.
#endregion

#region 26. Retrieve orders that were placed in the month of June.
#endregion

#region 27. Get the names and phone numbers of suppliers from "Italy".
#endregion

#region 28. List all products with unit prices less than 20.
#endregion

#region 29. Find orders that were shipped in 1997.
#endregion

#region 30. Retrieve the names of all customers who have placed more than 5 orders.
#endregion

#region 31. List products with no quantity on order.
#endregion

#region 32. Get all categories with more than 5 products.
#endregion

#region 33. Find the customer with the most recent order.
#endregion

#region 34. Retrieve employees who work in "Sales".
#endregion

#region 35. List all products with a reorder level less than 10.
#endregion

#region 36. Find orders with a ship country of "UK" and a freight cost less than $20.
#endregion

#region 37. Get the names of suppliers who have a fax number.
#endregion

#region 38. List all orders placed in the first quarter of 1998.
#endregion

#region 39. Retrieve products that have a unit price between $20 and $50.
#endregion

#region 40. Find customers who have a postal code starting with "9".
#endregion

#region 41. List all employees with their address details.
#endregion

#region 42. Get all orders where the ship city is "London".
#endregion

#region 43. Find all categories with at least one product in stock.
#endregion

#region 44. Retrieve the names and cities of customers who live in "USA".
#endregion

#region 45. List products supplied by supplier with ID 10.
#endregion

#region 46. Find all orders where the ship name contains "snabbköp".
#endregion

#region 47. Get the details of products with more than 20 units in stock.
#endregion

#region 48. Retrieve all orders where the order date is in 1998.
#endregion

#region 49. List all suppliers from "Canada" who have a phone number starting with "(416)".
#endregion

#region 50. Find products that have been ordered more than 50 times.
#endregion

#region 51. Get the names of all employees who are not managers
#endregion

#region 52. List orders where the ship country is "Mexico"
#endregion

#region 53. Retrieve all products with a quantity per unit description containing "bottle"
#endregion

#region 54. Find the top 5 products with the highest unit price
#endregion

#region 55. Get all customers who have a contact title of "Owner"
#endregion

#region 56. List all employees who have their last name starting with "S"
#endregion

#region 57. Retrieve orders placed in the month of December
#endregion

#region 58. Find products that are neither discontinued nor have a reorder level of 0
#endregion

#region 59. Get the names of suppliers who have their country listed as "UK"
#endregion

#region 60. List all orders with a ship city of "London" and a freight cost greater than $30
#endregion

#region 61. Retrieve all employees who were hired in 1997
#endregion

#region 62. Find products that have been ordered by more than 10 different customers
#endregion

#region 63. Get all categories that do not have any discontinued products
#endregion

#region 64. List all customers who have a region specified
#endregion

#region 65. Retrieve products where the unit price is greater than the average unit price
#endregion

#region 66. Find the supplier with the most products
#endregion

#region 67. Get all orders where the order date is after November 15, 1997
#endregion

#region 68. List products with a unit price that is a multiple of 5
#endregion

#region 69. Retrieve the names of customers who have placed at least 3 orders
#endregion

#region 70. Find all orders shipped by "United Package"
#endregion

#region 71. Get the details of orders that were shipped in "Berlin"
#endregion

#region 72. List products that have been discontinued and have a unit price greater than $20
#endregion

#region 73. Retrieve employees who have not shipped any orders
#endregion

#region 74. Find customers who have orders with a discount applied
#endregion

#region 75. Get the top 3 most expensive products
#endregion

#region 76. List all suppliers with a home page
#endregion

#region 77. Retrieve orders where the freight cost is between $10 and $50
#endregion

#region 78. Find products supplied by a supplier with the name "Exotic Liquids"
#endregion

#region 79. Get all orders that were required before the order date
#endregion

#region 80. List products that have been ordered at least once in each year of the 1990s
#endregion

#region 81. Retrieve all orders where the ship city is "Seattle" or "Portland"
#endregion

#region 82. Find employees who have more than one phone number listed
#endregion

#region 83. Get the details of orders placed by the customer "ANATR"
#endregion

#region 84. List products with a quantity per unit description that includes "can"
#endregion

#region 85. Retrieve the names of all customers who have their contact name starting with "A"
#endregion

#region 86. Find all products with a unit price between $15 and $25
#endregion

#region 87. Get all orders that were shipped in the year 1997 but required before 1996
#endregion

#region 88. List all categories with at least one product that is not discontinued
#endregion

#region 89. Retrieve the names of suppliers who do not have a fax number
#endregion

#region 90. Find customers who live in cities starting with "S"
#endregion

#region 91. Get the total number of products for each supplier
#endregion

#region 92. List all orders where the freight cost is exactly $15
#endregion

#region 93. Retrieve employees who have a title containing "Manager"
#endregion

#region 94. Find products with a unit price that is not an integer
#endregion

#region 95. Get the names of all employees whose last name is "Davies"
#endregion

#region 96. List all orders shipped by "Federal Shipping"
#endregion

#region 97. Retrieve products with a unit price less than $25 and greater than $10
#endregion

#region 98. Find all customers with the same city as "Berlin"
#endregion

#region 99. Get the details of orders where the required date is within a week of the order date
#endregion

#region 100. List all products that have been ordered but have a quantity per unit of "6 boxes"
#endregion

#endregion Easy
