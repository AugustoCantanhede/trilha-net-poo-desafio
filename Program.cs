using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("---");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new IPhone(numero: "654321", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");