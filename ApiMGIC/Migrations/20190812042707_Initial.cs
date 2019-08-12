using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiMGIC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assigne",
                columns: table => new
                {
                    idS = table.Column<string>(nullable: false),
                    numero = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: false),
                    idpuesto = table.Column<string>(nullable: false),
                    cvepuesto = table.Column<string>(nullable: false),
                    puesto = table.Column<string>(nullable: false),
                    unidadorg = table.Column<string>(nullable: false),
                    subdiv = table.Column<string>(nullable: false),
                    nivel = table.Column<string>(nullable: false),
                    site = table.Column<string>(nullable: false),
                    jefeinm = table.Column<string>(nullable: false),
                    nombre_ji = table.Column<string>(nullable: false),
                    fialfa = table.Column<string>(nullable: false),
                    fipuesto = table.Column<string>(nullable: false),
                    celula = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assigne", x => x.idS);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    idS = table.Column<string>(nullable: false),
                    customernumber = table.Column<string>(nullable: false),
                    RutaSOL = table.Column<string>(nullable: false),
                    OficinadeVentas = table.Column<string>(nullable: false),
                    name1 = table.Column<string>(nullable: false),
                    name2 = table.Column<string>(nullable: false),
                    Poblacion = table.Column<string>(nullable: false),
                    zipcode = table.Column<string>(nullable: false),
                    streetandnumber = table.Column<string>(nullable: false),
                    Dirección = table.Column<string>(nullable: false),
                    salesorganization = table.Column<string>(nullable: false),
                    distributionchannel = table.Column<string>(nullable: false),
                    Sector = table.Column<string>(nullable: false),
                    Gpoclientes = table.Column<string>(nullable: false),
                    Zonadeventas = table.Column<string>(nullable: false),
                    region = table.Column<string>(nullable: false),
                    latitud = table.Column<string>(nullable: false),
                    longitud = table.Column<string>(nullable: false),
                    Interlocutor = table.Column<string>(nullable: false),
                    Segment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.idS);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "assigne");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}
