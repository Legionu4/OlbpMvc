namespace Olbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Organisations", "ArmFieldNames_Id", "dbo.ArmFieldNames");
            DropForeignKey("dbo.Organisations", "description_ids_Id", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "description_ids1_Id", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "description_ids2_Id", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "description_ids3_Id", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "organisations2_Id", "dbo.Organisations");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id1", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id2", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id3", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id4", "dbo.DescriptionIds");
            DropForeignKey("dbo.Organisations", "DescriptionIds_Id5", "dbo.DescriptionIds");
            DropIndex("dbo.Organisations", new[] { "ArmFieldNames_Id" });
            DropIndex("dbo.Organisations", new[] { "description_ids_Id" });
            DropIndex("dbo.Organisations", new[] { "description_ids1_Id" });
            DropIndex("dbo.Organisations", new[] { "description_ids2_Id" });
            DropIndex("dbo.Organisations", new[] { "description_ids3_Id" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id" });
            DropIndex("dbo.Organisations", new[] { "organisations2_Id" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id1" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id2" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id3" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id4" });
            DropIndex("dbo.Organisations", new[] { "DescriptionIds_Id5" });
            RenameColumn(table: "dbo.Organisations", name: "Resendtype1_id", newName: "ResendType_id");
            RenameIndex(table: "dbo.Organisations", name: "IX_Resendtype1_id", newName: "IX_ResendType_id");
            DropColumn("dbo.Organisations", "ArmFieldNames_Id");
            DropColumn("dbo.Organisations", "description_ids_Id");
            DropColumn("dbo.Organisations", "description_ids1_Id");
            DropColumn("dbo.Organisations", "description_ids2_Id");
            DropColumn("dbo.Organisations", "description_ids3_Id");
            DropColumn("dbo.Organisations", "DescriptionIds_Id");
            DropColumn("dbo.Organisations", "organisations2_Id");
            DropColumn("dbo.Organisations", "DescriptionIds_Id1");
            DropColumn("dbo.Organisations", "DescriptionIds_Id2");
            DropColumn("dbo.Organisations", "DescriptionIds_Id3");
            DropColumn("dbo.Organisations", "DescriptionIds_Id4");
            DropColumn("dbo.Organisations", "DescriptionIds_Id5");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organisations", "DescriptionIds_Id5", c => c.Int());
            AddColumn("dbo.Organisations", "DescriptionIds_Id4", c => c.Int());
            AddColumn("dbo.Organisations", "DescriptionIds_Id3", c => c.Int());
            AddColumn("dbo.Organisations", "DescriptionIds_Id2", c => c.Int());
            AddColumn("dbo.Organisations", "DescriptionIds_Id1", c => c.Int());
            AddColumn("dbo.Organisations", "organisations2_Id", c => c.Int());
            AddColumn("dbo.Organisations", "DescriptionIds_Id", c => c.Int());
            AddColumn("dbo.Organisations", "description_ids3_Id", c => c.Int());
            AddColumn("dbo.Organisations", "description_ids2_Id", c => c.Int());
            AddColumn("dbo.Organisations", "description_ids1_Id", c => c.Int());
            AddColumn("dbo.Organisations", "description_ids_Id", c => c.Int());
            AddColumn("dbo.Organisations", "ArmFieldNames_Id", c => c.Int());
            RenameIndex(table: "dbo.Organisations", name: "IX_ResendType_id", newName: "IX_Resendtype1_id");
            RenameColumn(table: "dbo.Organisations", name: "ResendType_id", newName: "Resendtype1_id");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id5");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id4");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id3");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id2");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id1");
            CreateIndex("dbo.Organisations", "organisations2_Id");
            CreateIndex("dbo.Organisations", "DescriptionIds_Id");
            CreateIndex("dbo.Organisations", "description_ids3_Id");
            CreateIndex("dbo.Organisations", "description_ids2_Id");
            CreateIndex("dbo.Organisations", "description_ids1_Id");
            CreateIndex("dbo.Organisations", "description_ids_Id");
            CreateIndex("dbo.Organisations", "ArmFieldNames_Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id5", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id4", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id3", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id2", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id1", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "organisations2_Id", "dbo.Organisations", "Id");
            AddForeignKey("dbo.Organisations", "DescriptionIds_Id", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "description_ids3_Id", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "description_ids2_Id", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "description_ids1_Id", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "description_ids_Id", "dbo.DescriptionIds", "Id");
            AddForeignKey("dbo.Organisations", "ArmFieldNames_Id", "dbo.ArmFieldNames", "Id");
        }
    }
}
