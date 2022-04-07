using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace I9site.Models
{

    public class OrcamentosRepository: DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
        
            optionsBuilder.UseMySql("Server=localhost;DataBase=Inove;Uid=root; Pwd=;");
        }

        public DbSet<Orcamento> Orcamentos {get; set;}

    }

}