namespace polimorfismo.Entidades
{
    public class Evento
    {
        public string? Nome { get; set; }
        public DateTime Data { get; set; }
        public string? Local { get; set; }
        public int CapacidadeMaxima { get; set; }
        public List<Atividade> Atividades { get; set; } = [];
        public List<Participante> Participantes { get; set; } = [];



        public void Iniciar() { }
        public void Pausar() { }
        public void Concluir() { }
        public void Cancelar() { }

        public void ValidarCapcidadeParticipante(Participante participante)
        {
            if (Participantes.Count < CapacidadeMaxima)
            {
                Participantes.Add(participante);
            }
            else
            {
                Console.WriteLine("Capacidade máxima alcançada.");
            }
        }

        public void MostrarPalestrantes()
        {
            Console.WriteLine($"Palestrantes do evento {Nome}:");
            foreach (var participante in Participantes)
            {
                if (participante is Palestrante)
                {
                    Console.WriteLine(participante.Nome);
                }
            }
        }

        public void MostrarEspectadores()
        {
            Console.WriteLine($"Espectadores do evento {Nome}:");
            foreach (var participante in Participantes)
            {
                if (participante is Espectador)
                {
                    Console.WriteLine(participante.Nome);
                }
            }
        }
    }
}
