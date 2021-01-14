using System;
using _MVC_Introducao.controller;
using _MVC_Introducao.model;

namespace _MVC_Introducao
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoController prod = new ProdutoController();
            
            prod.Listar();


        }
    }
}
