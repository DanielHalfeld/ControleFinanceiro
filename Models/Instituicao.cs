using System.ComponentModel;

namespace ControleFinanceiro.Models
{
    public class Instituicao
    {
        [DisplayName("Código")]
        public long? InstituicaoId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
