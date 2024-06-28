namespace polimorfismo
{
    public class Workshop : Evento
    {
        public override void Cancelar()
        {
            Console.WriteLine("Workshop cancelado.");
        }

        public override void Concluir()
        {
            Console.WriteLine("Workshop concluído.");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Workshop iniciado.");
        }

        public override void Pausar()
        {
            Console.WriteLine("Workshop pausado.");
        }
    }
}
