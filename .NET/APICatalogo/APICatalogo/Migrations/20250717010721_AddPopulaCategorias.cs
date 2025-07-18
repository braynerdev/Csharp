using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class AddPopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Bebida','bebida.jpg')");
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Lanches','lanches.jpg')");
            mb.Sql("insert into Categorias(Nome,ImagemUrl) Values('Sobremesa','sobremesa.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
