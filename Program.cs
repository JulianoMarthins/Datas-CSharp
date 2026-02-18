using System.Data;
using System.Globalization;
using Microsoft.VisualBasic;

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

// Podemos usar códigos para descrever o estilo de formatação pré definidos

// Somente a hora e minutos
Console.WriteLine(String.Format("{0:t}", nascimento));

// Horario completo com hora, minutos e segundos
Console.WriteLine(String.Format("{0:T}", nascimento));

// Data 
Console.WriteLine(String.Format("{0:d}", nascimento));

// Data completa com dia por extenso, número do dia mês por extenso e ano
Console.WriteLine(String.Format("{0:D}", nascimento));

// Data no padrão para uso do Json
Console.WriteLine(String.Format("{0:s}", nascimento));

// Padrão de data que muitos sistemas usam
Console.WriteLine(String.Format("{0:r}", nascimento));


Console.ReadKey();
Console.Clear();

Console.WriteLine("Soma de dias as datas: ");

var date = DateTime.Now;
Console.WriteLine($"Dia de hoje: {date}");

Console.WriteLine($"Acrescentado 12 dias: {date.AddDays(-12)}");

Console.WriteLine($"Acrescentado 2 messes: {date.AddMonths(2)}");

Console.WriteLine($"Acrescentado 4 anos: {date.AddYears(4)}");

Console.WriteLine($"Acrescentado 8 horas: {date.AddHours(8)}");


Console.ReadKey();
Console.Clear();

Console.WriteLine("Comparando datas");


DateTime data2 = DateTime.Now;

if (data2.Date == DateTime.Now.Date)
{
    Console.WriteLine("As datas são iguais");
}


Console.ReadKey();
Console.Clear();


Console.WriteLine("CultureInfo");

var pt = new System.Globalization.CultureInfo("pt=BR");
var en = new System.Globalization.CultureInfo("en-US");

Console.WriteLine(DateTime.Now.ToString("D"));

