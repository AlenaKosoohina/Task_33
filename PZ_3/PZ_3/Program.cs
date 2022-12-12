int chislo = int.Parse(Console.ReadLine());
if ((chislo / 10000) == (chislo % 10))
{
    if (((chislo/1000)%10) ==((chislo%100)/10))
    { Console.WriteLine("да"); }
    else { Console.WriteLine("нет"); }
}
else { Console.WriteLine("нет"); }
