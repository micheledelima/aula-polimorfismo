namespace polimorfismo
{
    public class Palestrante : Participante
    {
        public override void Participar(Evento evento)
        {
            Console.WriteLine($"{Nome} está palestrando no evento {evento.Nome}.");
        }
    }
}
