using System.Collections.Generic;
using System.IO;

namespace _MVC_Introducao.model
{
    public class ProdutoModel
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/DadosProduto.csv";

        public ProdutoModel(){

            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                
                Directory.CreateDirectory(pasta);

            }
            
            if(!File.Exists(PATH)){

                File.Create(PATH);

            }

        }

        public List<ProdutoModel> Ler(){

            string[] linhas = File.ReadAllLines(PATH);

            List<ProdutoModel> produtos = new List<ProdutoModel>();

            foreach (var linha in linhas)
            {
                
                string[] dados = linha.Split(";");

                ProdutoModel produto = new ProdutoModel();

                produto.ID = int.Parse( dados[0] );
                produto.Nome = dados[1];
                produto.Preco = float.Parse( dados[2] );

                produtos.Add(produto);

            }
                
                return produtos;

        } 
        
        
    }
}