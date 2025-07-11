using DesafioPOO.Models;

Console.WriteLine("🔥 RUNNING Program.cs 🔥");

Nokia nokia = new Nokia("123456", "Modelo A", "111111", 64);
Iphone iphone = new Iphone("789012", "Modelo B", "222222", 128);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
