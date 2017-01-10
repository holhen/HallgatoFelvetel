namespace HallgatoFelvetel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Hallgatok", newName: "StudentEntities");
            RenameTable(name: "dbo.Idopontok", newName: "AppointmentEntities");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AppointmentEntities", newName: "Idopontok");
            RenameTable(name: "dbo.StudentEntities", newName: "Hallgatok");
        }
    }
}
