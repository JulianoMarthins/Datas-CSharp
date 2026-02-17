Console.Clear();

Console.WriteLine("Desenvolvido por Juliano Martins\n\n");

// Criação de um objeto para representação de datas, o argumento recebe ano, mês, dia, hora, minuto e segundo.
DateTime nascimento = new DateTime(2025, 8, 17, 8, 31, 17);

// Abaixo pegamos a hora atual do sistema operacional
DateTime agora = DateTime.Now;

Console.WriteLine($"Momento atual: {agora}");
Console.WriteLine($"Nascimento do meu filho: {nascimento} no dia {nascimento.DayOfWeek}");


// Formatar data e hora
DateTime data = new DateTime(1982, 6, 4);
string dataFormatada = String.Format("{0:D}", data);
Console.WriteLine($"Meu aniversário: {dataFormatada}");

Console.ReadKey();
