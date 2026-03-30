//1-vazifa. Katta harf tekshiruvi (Char & Bool)
char harf;
Console.WriteLine("Tekshirmoqchi bolgan harfni kiriting: ");
harf = Convert.ToChar(Console.ReadLine());
if (char.IsUpper(harf))
    Console.WriteLine("Ha");
else Console.WriteLine("Yo'q");


//2-vazifa. Javobni aniqlash
Console.WriteLine("Dasturlash sizga yoqadimi? (H/Y)");
char javob = Convert.ToChar(Console.ReadLine());
if (javob == 'H')
    Console.WriteLine("Ajoyib!");
else
    Console.WriteLine("Afsus!");

//3-vazifa. Ismning birinchi harfini chiqarish
Console.WriteLine("Ismingizni kiriting: ");
string ism = Console.ReadLine();
Console.WriteLine(ism[0]);
