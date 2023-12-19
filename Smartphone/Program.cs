using Smartphone.Models;

Console.WriteLine("Smartphone Nokia:");
SmartphoneImp nokia = new Nokia(numero: "(81) 95534-2232", modelo: "Nokia G11", imei: "C23FGII90LLK34U", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
SmartphoneImp iphone = new Iphone(numero: "(81) 95534-2232", modelo: "iPhone 13 Pro Max", imei: "FUOF46PYR238KUP", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.ReadLine();

