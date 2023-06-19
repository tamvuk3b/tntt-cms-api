using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThieuNhiTT.Api.Migrations
{
    /// <inheritdoc />
    public partial class renametable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        }
    }
}
