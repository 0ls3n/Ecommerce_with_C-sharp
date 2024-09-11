using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce_Project.Migrations.ProductDb
{
    /// <inheritdoc />
    public partial class ProductsInDifferentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessory_Gender",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Accessory_Material",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Clothing_Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Clothing_Gender",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Clothing_Material",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Clothing_Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsWaterproof",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Accessory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessory_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clothing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothing_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Footwear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWaterproof = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footwear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Footwear_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessory");

            migrationBuilder.DropTable(
                name: "Clothing");

            migrationBuilder.DropTable(
                name: "Footwear");

            migrationBuilder.AddColumn<int>(
                name: "Accessory_Gender",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Accessory_Material",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clothing_Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Clothing_Gender",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clothing_Material",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clothing_Size",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsWaterproof",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
