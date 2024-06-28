using polimorfismo;

var conferencia = 
    new Conferencia
    {
        Nome = "Conferência dev's .Net",
        Data = new DateTime(2024, 10, 15),
        Local = "Ambevtech",
        CapacidadeMaxima = 200
    };

var workshop = 
    new Workshop
    {
        Nome = "Workshop de Teste de Unidade",
        Data = new DateTime(2024, 11, 20),
        Local = "Ambevtech",
        CapacidadeMaxima = 50
    };

var palestrante = 
    new Palestrante 
    { 
        Nome = "Talita" 
    };

var espectador = 
    new Espectador 
    { 
        Nome = "Jenny" 
    };

var espectador1 =
    new Espectador
    {
        Nome = "Mi"
    };



var palestra = 
    new Atividade
    {
        Nome = "Fundamentos POO",
        Descricao = "Fundamentos da programação orientada a objetos",
        Status = Atividade.StatusAtividade.Agendada
    };

conferencia.Atividades.Add(palestra);

conferencia.ValidarCapcidadeParticipante(palestrante);
conferencia.ValidarCapcidadeParticipante(espectador);
conferencia.ValidarCapcidadeParticipante(espectador1);

//depois de validar add
palestrante.Participar(conferencia);
espectador.Participar(workshop);

conferencia.Iniciar();
conferencia.Pausar();
workshop.Iniciar();

workshop.Concluir();

Console.WriteLine("Pressione qualquer tecla para finalizar...");
Console.ReadKey();