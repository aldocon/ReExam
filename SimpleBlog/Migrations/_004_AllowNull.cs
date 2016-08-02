using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;
using NHibernate.Mapping;

namespace SimpleBlog.Migrations
{
    [Migration(4)]
    public class _004_AllowNull : Migration
    {
        public override void Up()
        {
            Delete.Column("updated_at").FromTable("posts");
            Delete.Column("deleted_at").FromTable("posts");

            
        }

        public override void Down()
        {
           

        }
    }
}


           