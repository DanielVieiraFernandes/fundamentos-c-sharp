using System.Xml.Serialization;
using System.Text;
using System.Globalization;
namespace HelloWorld;

class Program
{
   static void Main()
    {
        
        // Tipos primitivos de dados em C#

        // Tipos numéricos

       sbyte numero1 = 10;// aceita números positivos e negativos, inteiro assinado de 8 bits
       byte numero4 = 7;// só aceita números positivos, inteiro não assinado de 8 bits
       short numero5 = 7;// aceita números positivos e negativos, inteiro assinado de 16 bits
       ushort numero6 = 7;// só aceita números positivos, inteiro não assinado de 16 
       int numero = 7;// aceita números positivos e negativos, inteiro assinado de 32 bits
       uint numero7 = 7;// só aceita números positivos, inteiro não assinado de 32 bits
       long numero2 = 7;// aceita números positivos e negativos, inteiro assinado de 64 bits
       ulong numero8 = 7;// só aceita números positivos, inteiro não assinado de 64 bits


       double dNumero = 3.14;//
       float fNumero = 3.14F;// o sufixo D é opcional, mas o F é obrigatório para indicar que é um float
       decimal decNumero = 3.14M;// o sufixo M é obrigatório para indicar que é um decimal

       // Tipo booleano

       bool ativo = false;//
       bool inativo = true;//

       // Tipos de texto 
       // char
       // string

       char letra = 'A';// aceita apenas um único caractere, é um tipo de dado de 16 bits
       char caracter = '1';// usamos aspas simples para definir um único caractere, é um tipo de dado de 16 bits

       string texto = "Este curso é muito bom!".Trim();// aceita uma sequência de caracteres, é um tipo de dado de 16 bits
                                                 //usamos aspas duplas para definir uma sequência de caracteres, é um tipo de dado de 16 bits
       char primeiraLetraDoTexto = texto[0];
       // Console.WriteLine(texto);
       // Console.WriteLine(primeiraLetraDoTexto);

       bool comecaComALetraW = texto.StartsWith("E");
       bool terminaComALetra = texto.EndsWith("!");
       // Console.WriteLine(comecaComALetraW);
       // Console.WriteLine(terminaComALetra);

       string textoAposReplace = texto.Replace('E', 'P');

       // Console.WriteLine(textoAposReplace);

       bool existe = texto.Contains("curso");
       bool igual = texto.Equals("Este curso é muito bom!");

       // Console.WriteLine(existe);
       // Console.WriteLine(igual);


       string texto1 = "A primeira frase.";
       string texto2 = "Segunda frase";


       // Console.WriteLine($"{texto1} {texto2}");

       string texto3 = @"C:\teste";// evita com que tenhamos que usar o caractere de escape \ para cada barra invertida

       // Console.WriteLine(texto3);

       string paragrafo2 = $"{texto1} {texto2}.";// Interpolação de strings, permite incluir variáveis dentro de uma string

        /*
         Utilizar este método para concatenar strings é mais eficiente do que usar o operador +, 
        porém, se você precisar concatenar muitas strings, isso pode gerar problemas de desempenho,
        pois cada concatenação cria uma nova string na memória. Nesse caso, é melhor usar a classe StringBuilder.
         */

       StringBuilder sb = new StringBuilder();

       sb.Append(texto1);
       sb.Append(texto2);

       string resultado = sb.ToString();

       // Console.WriteLine(resultado);

       string texto5 = "O usuário {0} gosta do número {1}";

       string resultado1 = string.Format(texto5, "João", 42);

       // Console.WriteLine(resultado1);

       DateOnly dia = new DateOnly(2023, 12, 1);

       string diaEmTexto = dia.ToShortDateString();// Converte a data para uma string no formato curto
       string diaEmTexto1 = dia.ToLongDateString();// Converte a data para uma string no formato longo

       string diaEmTexto2 = dia.ToString("D",new CultureInfo("pt-BR"));// Converte a data para uma string no formato personalizado

       // Console.WriteLine(dia);

       // Console.WriteLine(diaEmTexto);
       // Console.WriteLine(diaEmTexto1);
       // Console.WriteLine(diaEmTexto2);

        DateTime dataHoraAtual = DateTime.Now;// Obtém a data e hora atual do sistema
        DateTime dataHoraEspecifica = new DateTime(2023, 12, 1, 14, 30, 0);// Cria uma data e hora específica
        DateTime dataEspecifica = DateTime.Today;// Obtém a data atual sem a hora

       // Console.WriteLine(dataHoraAtual);

       DateTime dataHoraEmQualquerPais = DateTime.UtcNow;// Obtém a data e hora atual em UTC (Tempo Universal Coordenado)

       DateTime dataDeAmanha = dataHoraEmQualquerPais.AddDays(1); // Adiciona um dia à data atual 
    }

}

