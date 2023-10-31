using System.ComponentModel;

namespace ControleFinanceiro.Models
{
    public class Departamento
    {
        [DisplayName("Código")]
        public long? DepartamentoId { get; set; }
        public string Nome { get; set; }
    }
}
