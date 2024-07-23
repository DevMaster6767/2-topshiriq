//1. Kalkulyator
Console.Write("birinchi sonni kiriting=> ");
double birinchison = Convert.ToDouble(Console.ReadLine());
Console.Write("ikinchi sonni kiriting=> ");
double ikkinchison = Convert.ToDouble(Console.ReadLine());
Console.Write("amalni kiriting=> ");
Console.Write("amalni kiriting=> ");
string amal = Console.ReadLine();
if (amal == "+")
    {
        Console.WriteLine($"yig'indi: {birinchison+ikkinchison}");
    }
else if (amal == "-")
    {
        Console.WriteLine($"ayirma: {birinchison-ikkinchison}");
    }
else if (amal == "*")
    {
        Console.WriteLine($"ko'paytma: {birinchison*ikkinchison}");
    }
else if (amal == "/")
    {
        Console.WriteLine($"bo'linma: {birinchison/ikkinchison}");
    }
else
    Console.WriteLine($"noto'g'ri amal kiritildi");

//2. Raqamlar qatorining yig‘indisini hisoblash:
Console.Write("N musbat sonni kiriting=> ");
int Nson = Convert.ToInt32(Console.ReadLine());
int s=0;
for(int i=0; i<=Nson; i++)
s=s+i;
Console.WriteLine($"yig'indi: {s}");

//3.  Paritet tekshiruvi:
Console.Write("N sonni kiriting=> ");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2==0)
Console.WriteLine("Juft son");
else if (N%2==1)
Console.WriteLine("toq son");
