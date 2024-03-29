﻿using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IProdutoRepository produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Carrossel() 
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

    }
}
