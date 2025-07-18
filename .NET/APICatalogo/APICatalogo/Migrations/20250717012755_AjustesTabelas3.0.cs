using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class AjustesTabelas30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Produtos(Name,Descricao," +
                "Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Lanche de Atum','Lanche de Atum com Maionese'," +
                "8.50,'lanchedeatum.jpg',10,now(),2)");
            mb.Sql("insert into Produtos(Name,Descricao," +
                "Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('Pudim 100g','Pudim de leite condensado 100g'," +
                "6.75,'pudim.jpg',20,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
