using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace SimpleBlog.Migrations
{
    [Migration(6)]
    public class _006_AddDeleteUpdate : Migration
    {
        public override void Up()
        {
            Create.Column("updated_at").OnTable("posts").AsDateTime().Nullable().WithDefaultValue(null);
            Create.Column("deleted_at").OnTable("posts").AsDateTime().Nullable().WithDefaultValue(null);
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}