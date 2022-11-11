using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("99999", "Tijolão", "123", 50);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Iphone iphone = new Iphone("123456", "Iphone-13", "123", 1000);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
