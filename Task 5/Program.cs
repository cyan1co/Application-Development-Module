DateTime bday =  new DateTime(2006, 1, 30);
DateTime now =  DateTime.Now;

DateTime newDate = bday.AddDays(10);

TimeSpan ts = now - bday;
int age = (int)(ts.TotalDays / 365.2422);

Console.WriteLine($"Birthday : {bday}");
Console.WriteLine($"Current Date : {now}");
Console.WriteLine($"Age in years : {age}");
Console.WriteLine($"Birthday after 10 days : {newDate}");