
bool isValidInput = false;

while (!isValidInput) // Kullanıcıdan doğru formatta veri alana kadar sormak için while döngüsü kullanıldı.
{
    try // Hata alınabilecek yer try bloğuna konuldu
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        
        string input = Console.ReadLine(); 

        int number = Convert.ToInt16(input); // Girilen değer int türüne dönüştürülür

        Console.WriteLine($"Girdiğiniz sayının karesi -->{Math.Pow(number, 2)}"); // Hata alınmazsa konsola yazdırılacak metin

        isValidInput = true; // Yukarıda hatalara takılmazsa döngüden çıkacak koşul
    }
    catch(FormatException ex) // Format hatasının yakalandığı catch bloğu
    {
        Console.WriteLine("Yanlış formatta bir veri girdiniz.");
    }
    catch(Exception ex) // Genel hataların yakalandığı catch bloğu
    {
        Console.WriteLine("Bir hata oluştu");
    }
}

