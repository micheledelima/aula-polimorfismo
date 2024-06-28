using static polimorfismo.Entidades.Evento;

namespace polimorfismo.Entidades
{
    public class Atividade
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public TipoEvento Tipo { get; set; }
        public StatusAtividade Status { get; set; }

        public enum TipoEvento
        {
            Wokrshop,
            Conferencia
        }

        public enum StatusAtividade
        {
            Agendada,
            EmAndamento,
            Concluida,
            Cancelada
        }
    }
}