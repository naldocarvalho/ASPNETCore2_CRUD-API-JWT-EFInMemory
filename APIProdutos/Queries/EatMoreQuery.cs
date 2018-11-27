using APIProdutos.Data;
using APIProdutos.Models.GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProdutos.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(ApplicationDbContext db)
        {

            Field<ListGraphType<ProdutoType>>(
                "produtos",
                resolve: context =>
                {
                    var produtos = db
                    .Produtos;
                    return produtos;
                });

        }
    }
}
