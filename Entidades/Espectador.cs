namespace polimorfismo.Entidades
{
    public class Espectador : Participante
    {
        public override void Participar(Evento evento)
        {
            Console.WriteLine($"{Nome} está assistindo o evento {evento.Nome}.");
        }
    }
}
