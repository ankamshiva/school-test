using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Data.Migrations
{
    public partial class SeedStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Students (FirstName, LastName, Address, Email, Grade, Class) Values ('Linkin', 'Park','Address 1', 'linkinpark@asdf.com', 'Grade1', 'Class1')");
            migrationBuilder
                .Sql("INSERT INTO Students (FirstName, LastName, Address, Email, Grade, Class) Values ('Iron', 'Maiden','Address 1', 'ironmaiden@asdf.com', 'Grade1', 'Class1')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Students");
        }
    }
}
