using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
//uncomment for spatial data type and run Install-Package System.Spatial 
//using System.Spatial;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated using  OData2Poco Class library.
//     Service Url: http://services.odata.org/V3/Northwind/Northwind.svc
//     MetaData Version: 1.0
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindModel
{

	public class Category
	{
	    public int CategoryID  {get;set;} //PrimaryKey not null
	    public string CategoryName  {get;set;} // not null
	    public string Description  {get;set;} 
	    public byte[] Picture  {get;set;} 
	}

	public class CustomerDemographic
	{
	    public string CustomerTypeID  {get;set;} //PrimaryKey not null
	    public string CustomerDesc  {get;set;} 
	}

	public class Customer
	{
	    public string CustomerID  {get;set;} //PrimaryKey not null
	    public string CompanyName  {get;set;} // not null
	    public string ContactName  {get;set;} 
	    public string ContactTitle  {get;set;} 
	    public string Address  {get;set;} 
	    public string City  {get;set;} 
	    public string Region  {get;set;} 
	    public string PostalCode  {get;set;} 
	    public string Country  {get;set;} 
	    public string Phone  {get;set;} 
	    public string Fax  {get;set;} 
	}

	public class Employee
	{
	    public int EmployeeID  {get;set;} //PrimaryKey not null
	    public string LastName  {get;set;} // not null
	    public string FirstName  {get;set;} // not null
	    public string Title  {get;set;} 
	    public string TitleOfCourtesy  {get;set;} 
	    public DateTime BirthDate  {get;set;} 
	    public DateTime HireDate  {get;set;} 
	    public string Address  {get;set;} 
	    public string City  {get;set;} 
	    public string Region  {get;set;} 
	    public string PostalCode  {get;set;} 
	    public string Country  {get;set;} 
	    public string HomePhone  {get;set;} 
	    public string Extension  {get;set;} 
	    public byte[] Photo  {get;set;} 
	    public string Notes  {get;set;} 
	    public int ReportsTo  {get;set;} 
	    public string PhotoPath  {get;set;} 
	}

	public class Order_Detail
	{
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public decimal UnitPrice  {get;set;} // not null
	    public short Quantity  {get;set;} // not null
	    public float Discount  {get;set;} // not null
	}

	public class Order
	{
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public string CustomerID  {get;set;} 
	    public int EmployeeID  {get;set;} 
	    public DateTime OrderDate  {get;set;} 
	    public DateTime RequiredDate  {get;set;} 
	    public DateTime ShippedDate  {get;set;} 
	    public int ShipVia  {get;set;} 
	    public decimal Freight  {get;set;} 
	    public string ShipName  {get;set;} 
	    public string ShipAddress  {get;set;} 
	    public string ShipCity  {get;set;} 
	    public string ShipRegion  {get;set;} 
	    public string ShipPostalCode  {get;set;} 
	    public string ShipCountry  {get;set;} 
	}

	public class Product
	{
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} // not null
	    public int SupplierID  {get;set;} 
	    public int CategoryID  {get;set;} 
	    public string QuantityPerUnit  {get;set;} 
	    public decimal UnitPrice  {get;set;} 
	    public short UnitsInStock  {get;set;} 
	    public short UnitsOnOrder  {get;set;} 
	    public short ReorderLevel  {get;set;} 
	    public bool Discontinued  {get;set;} // not null
	}

	public class Region
	{
	    public int RegionID  {get;set;} //PrimaryKey not null
	    public string RegionDescription  {get;set;} // not null
	}

	public class Shipper
	{
	    public int ShipperID  {get;set;} //PrimaryKey not null
	    public string CompanyName  {get;set;} // not null
	    public string Phone  {get;set;} 
	}

	public class Supplier
	{
	    public int SupplierID  {get;set;} //PrimaryKey not null
	    public string CompanyName  {get;set;} // not null
	    public string ContactName  {get;set;} 
	    public string ContactTitle  {get;set;} 
	    public string Address  {get;set;} 
	    public string City  {get;set;} 
	    public string Region  {get;set;} 
	    public string PostalCode  {get;set;} 
	    public string Country  {get;set;} 
	    public string Phone  {get;set;} 
	    public string Fax  {get;set;} 
	    public string HomePage  {get;set;} 
	}

	public class Territory
	{
	    public string TerritoryID  {get;set;} //PrimaryKey not null
	    public string TerritoryDescription  {get;set;} // not null
	    public int RegionID  {get;set;} // not null
	}

	public class Alphabetical_list_of_product
	{
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public int SupplierID  {get;set;} 
	    public int CategoryID  {get;set;} 
	    public string QuantityPerUnit  {get;set;} 
	    public decimal UnitPrice  {get;set;} 
	    public short UnitsInStock  {get;set;} 
	    public short UnitsOnOrder  {get;set;} 
	    public short ReorderLevel  {get;set;} 
	    public bool Discontinued  {get;set;} //PrimaryKey not null
	    public string CategoryName  {get;set;} //PrimaryKey not null
	}

	public class Category_Sales_for_1997
	{
	    public string CategoryName  {get;set;} //PrimaryKey not null
	    public decimal CategorySales  {get;set;} 
	}

	public class Current_Product_List
	{
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	}

	public class Customer_and_Suppliers_by_City
	{
	    public string City  {get;set;} 
	    public string CompanyName  {get;set;} //PrimaryKey not null
	    public string ContactName  {get;set;} 
	    public string Relationship  {get;set;} //PrimaryKey not null
	}

	public class Invoice
	{
	    public string ShipName  {get;set;} 
	    public string ShipAddress  {get;set;} 
	    public string ShipCity  {get;set;} 
	    public string ShipRegion  {get;set;} 
	    public string ShipPostalCode  {get;set;} 
	    public string ShipCountry  {get;set;} 
	    public string CustomerID  {get;set;} 
	    public string CustomerName  {get;set;} //PrimaryKey not null
	    public string Address  {get;set;} 
	    public string City  {get;set;} 
	    public string Region  {get;set;} 
	    public string PostalCode  {get;set;} 
	    public string Country  {get;set;} 
	    public string Salesperson  {get;set;} //PrimaryKey not null
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public DateTime OrderDate  {get;set;} 
	    public DateTime RequiredDate  {get;set;} 
	    public DateTime ShippedDate  {get;set;} 
	    public string ShipperName  {get;set;} //PrimaryKey not null
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public decimal UnitPrice  {get;set;} //PrimaryKey not null
	    public short Quantity  {get;set;} //PrimaryKey not null
	    public float Discount  {get;set;} //PrimaryKey not null
	    public decimal ExtendedPrice  {get;set;} 
	    public decimal Freight  {get;set;} 
	}

	public class Order_Details_Extended
	{
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public int ProductID  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public decimal UnitPrice  {get;set;} //PrimaryKey not null
	    public short Quantity  {get;set;} //PrimaryKey not null
	    public float Discount  {get;set;} //PrimaryKey not null
	    public decimal ExtendedPrice  {get;set;} 
	}

	public class Order_Subtotal
	{
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public decimal Subtotal  {get;set;} 
	}

	public class Orders_Qry
	{
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public string CustomerID  {get;set;} 
	    public int EmployeeID  {get;set;} 
	    public DateTime OrderDate  {get;set;} 
	    public DateTime RequiredDate  {get;set;} 
	    public DateTime ShippedDate  {get;set;} 
	    public int ShipVia  {get;set;} 
	    public decimal Freight  {get;set;} 
	    public string ShipName  {get;set;} 
	    public string ShipAddress  {get;set;} 
	    public string ShipCity  {get;set;} 
	    public string ShipRegion  {get;set;} 
	    public string ShipPostalCode  {get;set;} 
	    public string ShipCountry  {get;set;} 
	    public string CompanyName  {get;set;} //PrimaryKey not null
	    public string Address  {get;set;} 
	    public string City  {get;set;} 
	    public string Region  {get;set;} 
	    public string PostalCode  {get;set;} 
	    public string Country  {get;set;} 
	}

	public class Product_Sales_for_1997
	{
	    public string CategoryName  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public decimal ProductSales  {get;set;} 
	}

	public class Products_Above_Average_Price
	{
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public decimal UnitPrice  {get;set;} 
	}

	public class Products_by_Category
	{
	    public string CategoryName  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public string QuantityPerUnit  {get;set;} 
	    public short UnitsInStock  {get;set;} 
	    public bool Discontinued  {get;set;} //PrimaryKey not null
	}

	public class Sales_by_Category
	{
	    public int CategoryID  {get;set;} //PrimaryKey not null
	    public string CategoryName  {get;set;} //PrimaryKey not null
	    public string ProductName  {get;set;} //PrimaryKey not null
	    public decimal ProductSales  {get;set;} 
	}

	public class Sales_Totals_by_Amount
	{
	    public decimal SaleAmount  {get;set;} 
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public string CompanyName  {get;set;} //PrimaryKey not null
	    public DateTime ShippedDate  {get;set;} 
	}

	public class Summary_of_Sales_by_Quarter
	{
	    public DateTime ShippedDate  {get;set;} 
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public decimal Subtotal  {get;set;} 
	}

	public class Summary_of_Sales_by_Year
	{
	    public DateTime ShippedDate  {get;set;} 
	    public int OrderID  {get;set;} //PrimaryKey not null
	    public decimal Subtotal  {get;set;} 
	}

}
