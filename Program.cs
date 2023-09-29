using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);

nokia.InstalarAplicativo("Snake");
nokia.Ligar();
nokia.ReceberLigacao();


Iphone iphone = new Iphone("987654321", "iPhone 11", "987654321", 64);

iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();