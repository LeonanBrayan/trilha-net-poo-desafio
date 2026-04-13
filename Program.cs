using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "888888", memoria: 64);
nokia.InformaSmartphoneUtilizado("Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "282828", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.InformaSmartphoneUtilizado("iPhone");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");