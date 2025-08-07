namespace OnlineShoppingAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 10, unicode: false),
                        Password = c.String(maxLength: 30, unicode: false),
                        Role = c.String(maxLength: 30, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillItemNo = c.String(maxLength: 6, unicode: false),
                        Date = c.DateTime(nullable: false),
                        TaxOffice = c.String(maxLength: 60, unicode: false),
                        Hour = c.DateTime(nullable: false),
                        Deliverer = c.String(maxLength: 30, unicode: false),
                        Recipient = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        InvoiceItemId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 150, unicode: false),
                        Amount = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bill_BillId = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceItemId)
                .ForeignKey("dbo.Bills", t => t.Bill_BillId)
                .Index(t => t.Bill_BillId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 30, unicode: false),
                        Brand = c.String(maxLength: 30, unicode: false),
                        Stock = c.Short(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Boolean(nullable: false),
                        ProductImage = c.String(maxLength: 300, unicode: false),
                        Categoryid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.Categoryid, cascadeDelete: true)
                .Index(t => t.Categoryid);
            
            CreateTable(
                "dbo.SalesLogs",
                c => new
                    {
                        SalesId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Employee_EmployeeId = c.Int(),
                        Product_ProductId = c.Int(),
                        Seller_SellerId = c.Int(),
                    })
                .PrimaryKey(t => t.SalesId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .ForeignKey("dbo.Sellers", t => t.Seller_SellerId)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Seller_SellerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(maxLength: 30, unicode: false),
                        EmployeeSurname = c.String(),
                        EmployeeImage = c.String(maxLength: 30, unicode: false),
                        Department_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerId = c.Int(nullable: false, identity: true),
                        SellerName = c.String(maxLength: 30, unicode: false),
                        SellerSurname = c.String(maxLength: 30, unicode: false),
                        SellerCity = c.String(maxLength: 30, unicode: false),
                        SellerMail = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SellerId);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 150, unicode: false),
                        Date = c.DateTime(nullable: false),
                        SumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ExpenseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesLogs", "Seller_SellerId", "dbo.Sellers");
            DropForeignKey("dbo.SalesLogs", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.SalesLogs", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Products", "Categoryid", "dbo.Categories");
            DropForeignKey("dbo.InvoiceItems", "Bill_BillId", "dbo.Bills");
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropIndex("dbo.SalesLogs", new[] { "Seller_SellerId" });
            DropIndex("dbo.SalesLogs", new[] { "Product_ProductId" });
            DropIndex("dbo.SalesLogs", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Products", new[] { "Categoryid" });
            DropIndex("dbo.InvoiceItems", new[] { "Bill_BillId" });
            DropTable("dbo.Expenses");
            DropTable("dbo.Sellers");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.SalesLogs");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.InvoiceItems");
            DropTable("dbo.Bills");
            DropTable("dbo.Admins");
        }
    }
}
