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

var pt = new System.Globalization.CultureInfo("pt-BR");
var en = new System.Globalization.CultureInfo("en-US");
var de = new CultureInfo("de-DE");


// Mostra no console a data completa em dinamarques
Console.WriteLine(DateTime.Now.ToString("D", de));


// Pegar a cultura atual da máquina do usuário
var atual = CultureInfo.CurrentCulture;
Console.WriteLine(DateTime.Now.ToString("D", atual));


Console.ReadKey();
Console.Clear();


Console.WriteLine("TimeZone");

// O TimeZone padroniza a hora no formato UTC, deixando assim a hora muito mais confiavél 
// devido a possível variação do servidor de acesso da aplicação ao redor do mundo. Deve ser 
// utilizado para caso sua aplicação seja globalizada.


var utcDate = DateTime.UtcNow;

// Horario atual no formato universal
Console.WriteLine($"Hora atual universal: {utcDate}");
Console.WriteLine($"Hora atual do sistema: {DateTime.Now}");

// Para converter a data universal para a data do usuário
Console.WriteLine($"Data universal convertida: {utcDate.ToLocalTime}");

// Processo para usar a hora local do usuário independente da hora da máquina utilizada
var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine($"Horario do país: {timezoneAustralia}");

var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
Console.WriteLine($"Horario na Australia: {horaAustralia}");


Console.ReadKey();
Console.Clear();

System.Console.WriteLine("Retorno das ID dos TimeZones\n");

var timezones = TimeZoneInfo.GetSystemTimeZones();

foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia));
    Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
}


Console.ReadKey();
Console.Clear();

Console.WriteLine("TimeSpan");

var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanoSegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanoSegundos);

var timeSpanHoraMinutosSegundos = new TimeSpan(8, 31, 23);
Console.WriteLine(timeSpanHoraMinutosSegundos);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(17, 8, 31, 23);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(17, 8, 31, 23, 150);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);


// O timeSpan é feito para a realização de calculos para horas..

Console.ReadKey();
Console.Clear();


Console.WriteLine("Métodos importantes para uso em datas");

// Quantos dias tem um mês

Console.WriteLine($"Quantos dias tem o mês de Fevereiro de 2020: {DateTime.DaysInMonth(2020, 2)}"); // Retorna 29 dias, ano bissesto

Console.WriteLine($"Quantos dias tem o mês de Fevereiro de 2021: {DateTime.DaysInMonth(2021, 2)}"); // Retorna 28 dias

// Como estar se é fim de semana?
static bool IsWeekDay(DayOfWeek today)
{
    return today == DayOfWeek.Sunday || today == DayOfWeek.Saturday;
}

var find = new DateTime(2026, 2, 14);

Console.WriteLine($"Fim de semana? {IsWeekDay(DateTime.Now.DayOfWeek)}");
Console.WriteLine($"Fim de semana? {IsWeekDay(find.DayOfWeek)}");

// Verifica se estamos no horario de verão, retorna um bool
Console.WriteLine($"Horario de verão: {DateTime.Now.IsDaylightSavingTime()}");