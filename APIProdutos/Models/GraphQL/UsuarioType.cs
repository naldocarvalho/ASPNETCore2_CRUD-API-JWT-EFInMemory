using GraphQL.Types;

namespace APIProdutos.Models.GraphQL
{
    public class UsuarioType : ObjectGraphType<Usuario>
    {
        public UsuarioType()
        {
            Name = "Usuario";

            Field(x => x.ID).Description("Código do Usuário");

            Field(x => x.ChaveAcesso).Description("Chave de Acesso");
        }
    }
}