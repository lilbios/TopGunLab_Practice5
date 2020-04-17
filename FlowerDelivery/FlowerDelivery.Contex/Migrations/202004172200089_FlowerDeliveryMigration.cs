﻿namespace FlowerDelivery.Contex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlowerDeliveryMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        LatinNaming = c.String(),
                        Class = c.String(nullable: false),
                        Family = c.String(nullable: false),
                        ShortDescripton = c.String(nullable: false, maxLength: 100),
                        Photo = c.String(),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlantationFlowers",
                c => new
                    {
                        PlantationId = c.Guid(nullable: false),
                        FlowerId = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlantationId, t.FlowerId })
                .ForeignKey("dbo.Flowers", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("dbo.Plantations", t => t.PlantationId, cascadeDelete: true)
                .Index(t => t.PlantationId)
                .Index(t => t.FlowerId);
            
            CreateTable(
                "dbo.Plantations",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Adress = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplies",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ScheduledDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        PlantationId = c.Guid(nullable: false),
                        Warehouser = c.Guid(nullable: false),
                        Warehouse_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plantations", t => t.PlantationId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.Warehouse_Id)
                .Index(t => t.PlantationId)
                .Index(t => t.Warehouse_Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Adress = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WarehouseFlowers",
                c => new
                    {
                        WarehouseId = c.Guid(nullable: false),
                        FlowerId = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WarehouseId, t.FlowerId })
                .ForeignKey("dbo.Flowers", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.WarehouseId)
                .Index(t => t.FlowerId);
            
            CreateTable(
                "dbo.SupplyFlowers",
                c => new
                    {
                        SupplyId = c.Guid(nullable: false),
                        FlowerId = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SupplyId, t.FlowerId })
                .ForeignKey("dbo.Flowers", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("dbo.Supplies", t => t.SupplyId, cascadeDelete: true)
                .Index(t => t.SupplyId)
                .Index(t => t.FlowerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplyFlowers", "SupplyId", "dbo.Supplies");
            DropForeignKey("dbo.SupplyFlowers", "FlowerId", "dbo.Flowers");
            DropForeignKey("dbo.PlantationFlowers", "PlantationId", "dbo.Plantations");
            DropForeignKey("dbo.WarehouseFlowers", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.WarehouseFlowers", "FlowerId", "dbo.Flowers");
            DropForeignKey("dbo.Supplies", "Warehouse_Id", "dbo.Warehouses");
            DropForeignKey("dbo.Supplies", "PlantationId", "dbo.Plantations");
            DropForeignKey("dbo.PlantationFlowers", "FlowerId", "dbo.Flowers");
            DropIndex("dbo.SupplyFlowers", new[] { "FlowerId" });
            DropIndex("dbo.SupplyFlowers", new[] { "SupplyId" });
            DropIndex("dbo.WarehouseFlowers", new[] { "FlowerId" });
            DropIndex("dbo.WarehouseFlowers", new[] { "WarehouseId" });
            DropIndex("dbo.Supplies", new[] { "Warehouse_Id" });
            DropIndex("dbo.Supplies", new[] { "PlantationId" });
            DropIndex("dbo.PlantationFlowers", new[] { "FlowerId" });
            DropIndex("dbo.PlantationFlowers", new[] { "PlantationId" });
            DropTable("dbo.SupplyFlowers");
            DropTable("dbo.WarehouseFlowers");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Supplies");
            DropTable("dbo.Plantations");
            DropTable("dbo.PlantationFlowers");
            DropTable("dbo.Flowers");
        }
    }
}
