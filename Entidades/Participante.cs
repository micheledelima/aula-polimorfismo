namespace polimorfismo.Entidades
{
    public abstract class Participante
    {
        public string? Nome { get; set; }
        public abstract void Participar(Evento evento);
    }
}
