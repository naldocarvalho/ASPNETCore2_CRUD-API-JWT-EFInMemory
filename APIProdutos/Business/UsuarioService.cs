﻿using APIProdutos.Data;
using APIProdutos.Models;
using System.Linq;

namespace APIProdutos.Business
{
    public class UsuarioService
    {
        private ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Usuario Obter(string id)
        {
            return _context.Usuarios.Where(
                u => u.ID == id).FirstOrDefault();
        }

        public void Incluir(Usuario dadosUsuario)
        {
            _context.Usuarios.Add(dadosUsuario);
            _context.SaveChanges();
        }
    }
}