
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_gamer_MVC.Models
{
    public class Jogador
    {
        [Key] // Data Annotation [Key] é usada para especificar a propriedade que atua como chave primária.
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        [ForeignKey("Equipe")] // A Data Annotation [ForeignKey("Equipe")] é usada para definir um relacionamento de chave estrangeira em uma entidade. Ela indica qual propriedade da entidade representa a chave estrangeira para uma outra entidade relacionada. Ou seja ela esta se relacionando com o IdEquipe.
        public int IdEquipe { get; set; }
        
        public Equipe Equipe {get; set;}
        
    }
}