using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThieuNhiTT.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HiepDoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LienDoanId = table.Column<int>(type: "int", nullable: false),
                    TenHiepDoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaoHat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiepDoans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XuDoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HiepDoanId = table.Column<int>(type: "int", nullable: false),
                    TenXuDoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaoXu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuDoans", x => x.Id);
                });
            migrationBuilder.RenameTable(
                name: "HiepDoans",
                schema: "ngocngh1_tntt_admin",
                newName: "HiepDoan",
                newSchema: "ngocngh1_tntt_admin");
            migrationBuilder.RenameTable(
             name: "XuDoans",
             schema: "ngocngh1_tntt_admin",
             newName: "XuDoan",
             newSchema: "ngocngh1_tntt_admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HiepDoan");

            migrationBuilder.DropTable(
                name: "XuDoan");
        }
    }
}
