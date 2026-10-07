// See https://aka.ms/new-console-template for more information


using System.Globalization;

void Peça1()

{
    String códigoPeça1 = "1";
    double preçoPeça1 = 5.30;
}

  void Peça2()
{
    String códigoPeça2 = "2";
    double preçoPeça2 = 5.10;
}

Console.WriteLine("Insira o código da peça:");
  string OpcãoPeça1 = Console.ReadLine();

Console.WriteLine("Insira a quantidade desejada:");
string quantidadePeça1 = Console.ReadLine();

Console.WriteLine("Insira o código da segunda peça:");
string OpcãoPeça2 = Console.ReadLine();

Console.WriteLine("Insira a quantidade desejada da segunda peça:");
string quantidadePeça2 = Console.ReadLine();


switch (OpcãoPeça1)
{
      case "1":
            Peça1();
            break;
        case "2":
            Peça2();
            break;
        default:
            Console.WriteLine("Código de peça inválido.");
            break;
        }
    
switch (OpcãoPeça2)
{
    case "1":
        Peça1();
        break;
    case "2":
        Peça2();
        break;
    default:
        Console.WriteLine("Código de peça inválido.");
        break;
}






double preço1 = OpcãoPeça1 == "1" ? 5.30 : OpcãoPeça1 == "2" ? 5.10 : 0;
double preço2 = OpcãoPeça2 == "1" ? 5.30 : OpcãoPeça2 == "2" ? 5.10 : 0;

double valortotal = preço1 * int.Parse(quantidadePeça1) + preço2 * int.Parse(quantidadePeça2);

Console.WriteLine("Valor total: " + valortotal.ToString("F2", CultureInfo.InvariantCulture));






//Console.WriteLine("Insira o código da peça:");
//int códigoPeça1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Insira a quantidade desejada:");
//int quantidadePeça1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Insira o código da segunda peça:");  
//int códigoPeça2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Insira a quantidade desejada da segunda peça:");
//int quantidadePeça2 = int.Parse(Console.ReadLine());


//double preçoPeça1 = 5.30;
//double preçoPeça2 = 5.10;




//Console.WriteLine("Valor total: " + (quantidadePeça1 * preçoPeça1) + (quantidadePeça2 * preçoPeça2));



