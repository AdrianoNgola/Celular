//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Celular;


Smartphone Nokia = new Nokia(927599189, "Modelo 1", "12111", 64);


Console.WriteLine("======= Nokia ========");
Nokia.InstalarAplicativo("WhatsApp");
Nokia.Ligar();


Console.WriteLine("======= Iphone ========");

Smartphone Iphone = new Iphone(927599189, "Modelo 1", "12111", 64);

Iphone.InstalarAplicativo("Telegram");
Iphone.Ligar();
