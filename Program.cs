using DesafioPOO.Models;

Console.Write("Smartphone Samsung: ");
Smartphone samsung = new Samsung(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
samsung.Ligar();
samsung.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 2", imei:"22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");