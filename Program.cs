// See https://aka.ms/new-console-template for more information
	namespace switchh
	{


   class Program
   
   {
     static void Main(string[] args){
     
     Console.Write("Lütfen bir sayı giriniz: ");
     int sayi= int.Parse(Console.ReadLine());
     int sayac = 1;
     int toplam = 0;
     while( sayac <= sayi)
     {
        toplam += sayac;
        sayac ++;

     }
     Console.WriteLine(toplam/sayi);


     // a dan z ye kadar olan tüm sayıları yazdır
     char character = 'a';
     while( character < 'z')

     {
        Console.WriteLine(character);
     character++;
            
     }

   }}

     }
