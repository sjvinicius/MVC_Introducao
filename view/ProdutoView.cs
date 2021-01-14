using System;
using System.Collections.Generic;
using _MVC_Introducao.model;

namespace _MVC_Introducao.view
{
    public class ProdutoView
    {
        
        public void ListarProdutos(List<ProdutoModel> produtos) {

            foreach (var produto in produtos)
            {
                
            Console.WriteLine($"Produto");
            Console.WriteLine($"Nome: {produto.Nome} -- Id: {produto.ID}");
            Console.WriteLine();
            
            
            }
            
        }

    }
}