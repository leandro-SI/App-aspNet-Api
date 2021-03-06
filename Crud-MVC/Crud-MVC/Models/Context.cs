using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_MVC.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6CICVVM\sqlexpress;Database=Crudmvc;Integrated Security=True");
        }

        public virtual void SetModified(object entity) // Para utilizar o PUT
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
