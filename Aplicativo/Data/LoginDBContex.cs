using System;
using Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicativo.Data
{
	public class LoginDBContex: DbContext
	{
		public LoginDBContex(DbContextOptions<LoginDBContex> options)
			:base(options)
		{
		}

		public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}

