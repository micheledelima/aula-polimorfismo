using polimorfismo;
using polimorfismo.Entidades;
using static polimorfismo.Entidades.Atividade;

Console.WriteLine("Cadastro de Evento");

Console.WriteLine("Digite seu nome: ");
var nome = Console.ReadLine();
Console.WriteLine($"Bem vindo {nome}");

Console.WriteLine("Se você é palestrante digite: 1." +
    " Ou espectador digite: 2?");
var tipoParticipante = int.Parse(Console.ReadLine());
var palestrante = new Palestrante();
var espectador = new Espectador();

if (tipoParticipante == 1)
{
    palestrante.Nome = nome;
    Console.WriteLine("Deseja cadatrar um workshop digite: 1 ou conferencia digite: 2? ");
    var tipoEvento = int.Parse(Console.ReadLine());
    if (tipoEvento == 1)
    {
        Console.WriteLine("Digite o nome do workshop: ");
        var nomeWorkshop = Console.ReadLine();
        Console.WriteLine("Digite o descrição do workshop: ");
        var descricao = Console.ReadLine();

        var evento = new Evento()
        {
            Atividades = new List<Atividade>()
            {
                new Atividade
                {
                    Nome = nomeWorkshop,
                    Descricao = descricao,
                    Status = Atividade.StatusAtividade.Agendada
                }
            }
        };
        Console.WriteLine($"Cadastro Realizado com sucesso!{evento}");
    }
    else
    {
        Console.WriteLine("Digite o nome da Conferencia: ");
        var nomeConferencia = Console.ReadLine();
        Console.WriteLine("Digite o descrição do Conferencia: ");
        var descricao = Console.ReadLine();

        var evento = new Evento()
        {
            Atividades = new List<Atividade>()
            {
                new Atividade
                {
                    Nome = nomeConferencia,
                    Descricao = descricao,
                    Status = Atividade.StatusAtividade.Agendada
                }
            }
        };
        Console.WriteLine($"Cadastro Realizado com sucesso!{evento}");
    }
}
else
{
    espectador.Nome = nome;
    var lista = ListarAtividades();
    foreach ( var item in lista)
    {
        Console.WriteLine($"Atividade: {item.Nome} - {item.Descricao} - ID: {item.Id} - {item.Tipo}");
    }
}

static List<Atividade> ListarAtividades()
{
    var eventos = new Evento()
    {

        Atividades = new List<Atividade>()
            {
                new Atividade
                {
                    Tipo = TipoEvento.Conferencia,
                    Id = 1,
                    Nome = "ahuahauhau",
                    Descricao = "ahuahauhau",
                    Status = Atividade.StatusAtividade.Agendada
                },
                new Atividade
                {
                    Tipo = TipoEvento.Wokrshop,
                    Id = 2,
                    Nome = "ahuahauhau",
                    Descricao = "ahuahauhau",
                    Status = Atividade.StatusAtividade.Agendada
                }
            }
    };
    return eventos.Atividades;
}

Console.WriteLine("Pressione qualquer tecla para finalizar...");
Console.ReadKey();