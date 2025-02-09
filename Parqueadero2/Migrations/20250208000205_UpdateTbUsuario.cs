using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTbUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_DE_PLACA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MODELO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COLOR = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TB_USUAR__3214EC2759DB2BE5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIOSS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANTIDAD = table.Column<int>(type: "int", nullable: true),
                    PRECIO = table.Column<decimal>(type: "numeric(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TB_USUAR__3214EC27D597019F", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOSS");
        }
    }
}
