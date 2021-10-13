using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Data.Migrations
{
    public partial class SeedTeachersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Teachers (FirstName, LastName, Address, Email, Grade, Class, TeachingFrom) Values ('Linkin', 'Park','Address 1', 'linkinpark@asdf.com', 'Grade1', 'Class1', '2021-08-13 10:30:13.877')");
            migrationBuilder
                .Sql("INSERT INTO Teachers (FirstName, LastName, Address, Email, Grade, Class, TeachingFrom) Values ('Iron', 'Maiden','Address 1', 'ironmaiden@asdf.com', 'Grade1', 'Class1', '2021-08-28 10:29:57.713')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Teachers");
        }
    }
}
