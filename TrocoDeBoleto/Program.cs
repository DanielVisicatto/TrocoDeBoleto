Console.Write("Informe o valor total do boleto: ");
double valorBoleto = double.Parse(Console.ReadLine());

Console.Write("Informe a quantia recebida em R$: ");
double valorRecebido = double.Parse(Console.ReadLine());

int nota100, nota50, nota20, nota10, nota5, nota2, moeda1;

double troco = (valorRecebido - valorBoleto) * 100;

nota100 = (int)troco / 10000;
troco = troco % 10000;
nota50 = (int)troco / 5000;
troco = troco % 5000;
nota20 = (int)troco / 2000;
troco = troco % 2000;
nota10 = (int)troco / 1000;
troco = troco % 1000;
nota5 = (int)troco / 500;
troco = troco % 500;
nota2 = (int)troco / 200;
troco = troco % 200;
moeda1 = (int)troco / 100;

Console.WriteLine("O troco deve ser voltado da seguinte maneira:\n" +
    "Quantia de notas de R$100,00: {0}\n" +
    "Quantia de notas de R$50,00: {1}\n" +
    "Quantia de notas de R$20,00: {2}\n" +
    "Quantia de notas de R$10,00: {3}\n" +
    "Quantia de notas de R$5,00: {4}\n" +
    "Quantia de notas de R$2,00: {5}\n" +
    "e {6} moedas de R$1,00", nota100, nota50, nota20, nota10, nota5, nota2, moeda1);