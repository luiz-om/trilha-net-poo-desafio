using DesafioPOO.Models;



var nokia = new Nokia("123", "mp34", "222555", 64);
var iphone = new Iphone("5588", "11 pro", "111555", 128, 1);

nokia.Ligar();

nokia.InstalarAplicativo("telegram");



Thread.Sleep(2000);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
