using DesafioPOO.Models;

Nokia celularNokia = new Nokia("123", "XPTO", "AAAA", 128);
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("App A");

Iphone celularIphone = new Iphone("456", "ZZZ", "BBB45898", 256);
celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("App B");