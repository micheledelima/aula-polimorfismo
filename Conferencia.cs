namespace polimorfismo
{
    public class Conferencia : Evento
    {
        public override void Cancelar()
        {
            Console.WriteLine("Conferência cancelada.");
        }

        public override void Concluir()
        {
            Console.WriteLine("Conferência concluída.");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Conferência iniciada.");
        }

        public override void Pausar()
        {
            Console.WriteLine("Conferência pausada.");
        }
    }
}
