using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace SimpleBlog.Migrations
{
    [Migration(5)]
    public class _005_DeleteCreatedDeletedAgain : Migration
    {
        public override void Up()
        {
            Delete.Column("updated_at").FromTable("posts");
            Delete.Column("deleted_at").FromTable("posts");
            
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}

        //Create.Column("updated_at").OnTable("posts").AsDateTime().Nullable().WithDefaultValue(null);
        //Create.Column("deleted_at").OnTable("posts").AsDateTime().Nullable().WithDefaultValue(null);