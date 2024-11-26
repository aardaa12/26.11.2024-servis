List <string> ogrencilist = new List<string>(); 

while (true)
{
    int ogrencisayı= 0;
    Console.WriteLine("girmek istediğiniz öğrencileri yazın.");
    ogrencilist.Add(Console.ReadLine());

    int kararver = 0;
    Console.WriteLine("Lütfen eklemek istiyorsanız 1 istemiyorsanız 2ye basın.");
    kararver= Convert.ToInt32(Console.ReadLine());  
    if (kararver== 1)
    {
        Console.WriteLine("öğrenci eklendi. devam için 1 iptal için 2 " );
        ogrencisayı++;
        
    }
    else if (kararver == 2) {
        Console.WriteLine( "işlem tamamlandı toplam öğrenci sayısı" +ogrencisayı );
        
    }
    else
    {
        Console.WriteLine(  "geçersiz");
        
    }

    Console.WriteLine(" kaç servisiniz var");
    int servis=Convert.ToInt32(Console.ReadLine()) ;
    if (servis < ogrencisayı)
    {
        Console.WriteLine("servis yetersiz.");
    }
    else
    {
        Console.WriteLine("Geziye gidebliriz");
    }




}   


