using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "31998332926", modelo: "modelo 2", imei: "2222222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "3196834578", modelo: "modelo 4",  imei: "44444444444", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
    
