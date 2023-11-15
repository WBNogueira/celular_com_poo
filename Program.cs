// TODO: Realizar os testes com as classes Nokia e Iphone
using celular_com_poo.models;

Console.WriteLine("Utilizando o smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "984579999", modelo: "XP Turbo", imei: "123456789", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("");
Console.WriteLine("===================================");
Console.WriteLine("");

Console.WriteLine("Utilizando o smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "993669999", modelo: "Advanced", imei: "789456123", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Santander");