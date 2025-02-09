using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parqueadero2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColorProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__TB_USUAR__3214EC27D597019F",
                table: "TB_USUARIOSS");

            migrationBuilder.RenameTable(
                name: "TB_USUARIOSS",
                newName: "TbUsuariosses");

            migrationBuilder.RenameColumn(
                name: "PRECIO",
                table: "TbUsuariosses",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "NOMBRE",
                table: "TbUsuariosses",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "DESCRIPCION",
                table: "TbUsuariosses",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "CANTIDAD",
                table: "TbUsuariosses",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TbUsuariosses",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "COLOR",
                table: "TB_USUARIOS",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "TbUsuariosses",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "TbUsuariosses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TbUsuariosses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbUsuariosses",
                table: "TbUsuariosses",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TbUsuariosses",
                table: "TbUsuariosses");

            migrationBuilder.RenameTable(
                name: "TbUsuariosses",
                newName: "TB_USUARIOSS");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "TB_USUARIOSS",
                newName: "PRECIO");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "TB_USUARIOSS",
                newName: "NOMBRE");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TB_USUARIOSS",
                newName: "DESCRIPCION");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "TB_USUARIOSS",
                newName: "CANTIDAD");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_USUARIOSS",
                newName: "ID");

            migrationBuilder.AlterColumn<decimal>(
                name: "COLOR",
                table: "TB_USUARIOS",
                type: "numeric(18,0)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PRECIO",
                table: "TB_USUARIOSS",
                type: "numeric(18,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOMBRE",
                table: "TB_USUARIOSS",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPCION",
                table: "TB_USUARIOSS",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__TB_USUAR__3214EC27D597019F",
                table: "TB_USUARIOSS",
                column: "ID");
        }
    }
}
