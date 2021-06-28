using Microsoft.EntityFrameworkCore.Migrations;

namespace TMSAPI1.Migrations
{
    public partial class aneesha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admininfo",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admininfo", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "allocatevehicle",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleallocationtopassenger = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allocatevehicle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "employeeinfo",
                columns: table => new
                {
                    employeeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeinfo", x => x.employeeid);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "modify",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    routeinfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "routeinformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rootnumber = table.Column<int>(type: "int", nullable: false),
                    vehiclenumber = table.Column<int>(type: "int", nullable: false),
                    stops = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routeinformation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "userregistration",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userregistration", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "vehicleinformation",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehiclenumber = table.Column<int>(type: "int", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    seat = table.Column<int>(type: "int", nullable: false),
                    operable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleinformation", x => x.VehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admininfo");

            migrationBuilder.DropTable(
                name: "allocatevehicle");

            migrationBuilder.DropTable(
                name: "employeeinfo");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "modify");

            migrationBuilder.DropTable(
                name: "routeinformation");

            migrationBuilder.DropTable(
                name: "userregistration");

            migrationBuilder.DropTable(
                name: "vehicleinformation");
        }
    }
}
