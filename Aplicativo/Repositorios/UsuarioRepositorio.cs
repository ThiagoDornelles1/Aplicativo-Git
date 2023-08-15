using System;
using Aplicativo.Data;
using Aplicativo.Models;
using Aplicativo.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aplicativo.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio

    {
        private readonly LoginDBContex _dbContext;

        public UsuarioRepositorio(LoginDBContex loginDBConteX)
        {
            _dbContext = loginDBConteX;
        }


        async Task<UsuarioModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        async Task<List<UsuarioModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        async Task<UsuarioModel> IUsuarioRepositorio.Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        //async Task<UsuarioModel> IUsuarioRepositorio.Atualizar(UsuarioModel usuario, int id)
        //{
        //    UsuarioModel usuarioPorId = await BuscarPorId(id);
        //    if (usuarioPorId == null)
        //    {   
        //        throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
        //    }

        //    usuarioPorId.Nome = usuario.Nome;
        //    usuarioPorId.Email = usuario.Email;

        //    _dbContext.Usuarios.Update(usuarioPorId);
        //    await _dbContext.SaveChangesAsync();

        //    return usuarioPorId;
        //}

   

        //async Task<bool> IUsuarioRepositorio.Apagar(int id)
        //{
        //    UsuarioModel usuarioPorId = await BuscarPorId(id);
        //    if (usuarioPorId == null)
        //    {
        //        throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
        //    }

        //    _dbContext.Usuarios.Remove(usuarioPorId);
        //    await _dbContext.SaveChangesAsync();
        //    return true; 

        }

    }
}

