namespace HHSLVS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeerlingTabelToegevoegd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leerlings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        StudentNummer = c.Int(nullable: false),
                        JaarVanInschrijving = c.Int(nullable: false),
                        Studie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Studies", t => t.Studie_Id)
                .Index(t => t.Studie_Id);
            
            CreateTable(
                "dbo.Studies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leerlings", "Studie_Id", "dbo.Studies");
            DropIndex("dbo.Leerlings", new[] { "Studie_Id" });
            DropTable("dbo.Studies");
            DropTable("dbo.Leerlings");
        }
    }
}
