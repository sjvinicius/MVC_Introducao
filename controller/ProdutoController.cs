using System.Collections.Generic;
using _MVC_Introducao.model;
using _MVC_Introducao.view;

namespace _MVC_Introducao.controller
{
    public class ProdutoController
    {
        ProdutoModel ProdutoModel = new ProdutoModel();
        
        ProdutoView ProdutoView = new ProdutoView();

        public void Listar(){

            List<ProdutoModel> produtos = ProdutoModel.Ler();
            ProdutoView.ListarProdutos(produtos); 

        }

        
    }
}