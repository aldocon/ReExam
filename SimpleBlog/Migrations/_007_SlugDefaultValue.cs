using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using FluentMigrator;

namespace SimpleBlog.Migrations
{
    [Migration(7)]
    public class _007_SlugDefaultValue : Migration
    {
        public override void Up()
        {


            Create.Column("content").OnTable("posts").AsString(128).WithDefaultValue("");

            //Delete.Column("content").FromTable("posts");

            //Create.Column("content").OnTable("posts").AsString(9999).WithDefaultValue("");
            //Create.Column("title").OnTable("posts").AsString(128).WithDefaultValue("");

        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}