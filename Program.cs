using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia MeuNokia = new Nokia("1321313","nokia 9","12345",78);

Console.WriteLine("Nokia");
MeuNokia.Ligar();
MeuNokia.ReceberLigacao();
MeuNokia.InstalarAplicativo("Zapzap");

Console.WriteLine("Informações do Nokia");
Console.WriteLine($"Número: {MeuNokia.Numero}");
Console.WriteLine($"Imai: {MeuNokia.Imai}");
Console.WriteLine($"Modelo: {MeuNokia.Modelo}");
Console.WriteLine($"Mémoria: {MeuNokia.Memoria} MB");

Console.WriteLine();

Iphone MeuIphone = new Iphone("7654321","iphone 8 plus","661236",4);
Console.WriteLine("Iphone");
MeuIphone.Ligar();
MeuIphone.ReceberLigacao();
MeuIphone.InstalarAplicativo("League of legends wild rift");

Console.WriteLine($"Número: {MeuIphone.Numero}");
Console.WriteLine($"Imai: {MeuIphone.Imai}");
Console.WriteLine($"Modelo: {MeuIphone.Modelo}");
Console.WriteLine($"Mémoria: {MeuIphone.Memoria} GB");