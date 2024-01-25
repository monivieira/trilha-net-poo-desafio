using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1020", modelo: "Modelo 1", imei: "1456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "3040", modelo: "Modelo 2", imei: "1230", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");