using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Linq;
using System.Collections;

namespace I9site.Models
{
    public class OrcamentoService
    {
        
        public void Inserir (Orcamento o)
        {
            using (OrcamentosRepository or = new OrcamentosRepository())
            {
                or.Orcamentos.Add(o);
                or.SaveChanges();
            }
        }

        /*public void Editar(Orcamentos o)
        {
            using(OrcamentosRepository or = new OrcamentosRepository())
            {
                Orcamento Orcamentos = or.Orcamentos.Find(o.Id);
                Orcamentos.Nome = o.Nome;
                Orcamentos.Telefone = o.Telefone;

                or.SaveChanges();
            }
        }
        
       public ICollection<Orcamento> ListarTodos(FiltrosOrcamentos filtro = null)
        {
            using(OrcamentosRepository or = new OrcamentosRepository())
            {
                IQueryable<Orcamento>query;

                if(filtro !=null)
                {
                    switch(filtro.TipoFiltro)
                    {
                        case "Nome": 
                            query = or.Orcamentos.Where (o => o.Nome.Contains(filtro.Filtro));
                        break;

                        case "Servico":
                            query = or.Orcamentos.Where(o => o.Servico.Contains(filtro.Filtro));
                        break;

                        default:
                            query = or.Orcamentos;
                        break;
                    }
                }
                else
                {
                    query = or.Orcamentos;
                }
            }
        }*/

    }
}