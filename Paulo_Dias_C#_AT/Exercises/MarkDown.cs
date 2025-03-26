
namespace AT
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            
            foreach (var contato in contatos)
            {
                Console.WriteLine($"- Nome: {contato.Nome}");
                Console.WriteLine($"- Telefone: {contato.Telefone}");
                Console.WriteLine($"- Email: {contato.Email}");
                Console.WriteLine();
            }
        }
    }
}