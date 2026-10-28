Console.WriteLine("Hello, World!");

Account bando = new("ACC01", "Bando Mega", 5000000);

Console.WriteLine("========================");
Console.WriteLine("KODA BANKING APP");
Console.WriteLine("========================");

Console.WriteLine($"Account Number\t: {bando.AccountNumber}");
Console.WriteLine($"Name\t: {bando.OwnerName}");
Console.WriteLine($"Balance\t: {bando.Balance}");

Console.WriteLine(bando.GetInformation());

Console.WriteLine("========================");
