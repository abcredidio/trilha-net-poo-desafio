using DesafioPOO.Models;

Iphone iphone = new Iphone("8199999-7979", "iphone15", "897979456464646", 256);
Nokia nokia = new Nokia("8199999-7978", "Nokia 1300", "1231564897434", 16);

Console.WriteLine("Testando Nokia:");
nokia.InfosAparelho();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("----------------------------");
Console.WriteLine("Testando Iphone");
iphone.InfosAparelho();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");