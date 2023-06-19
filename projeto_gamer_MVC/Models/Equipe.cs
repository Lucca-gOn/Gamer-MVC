
using System.ComponentModel.DataAnnotations;

namespace projeto_gamer_MVC.Models
{
    public class Equipe
    {
        [Key] // Data Annotation [Key] é usada para especificar a propriedade que atua como chave primária em uma entidade.
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public ICollection<Jogador> Jogador { get; set;} // Referencia que a classe equipe, vai ter acesso a collection "Jogador".
         
    }
}