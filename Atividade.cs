using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Atividade
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusAtividade Status { get; set; }

        public enum StatusAtividade
        {
            Agendada,
            EmAndamento,
            Concluida,
            Cancelada
        }
    }
}
