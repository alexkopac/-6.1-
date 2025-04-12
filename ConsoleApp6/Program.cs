using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class MusicalInstrument
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public string HistoryInfo { get; protected set; }

    public MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        HistoryInfo = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{Name} видає звук.");
    }

    public void Show()
    {
        Console.WriteLine($"Інструмент: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }

    public void History()
    {
        Console.WriteLine($"Історія: {HistoryInfo}");
    }
}

// Похідний клас "Скрипка"
public class Violin : MusicalInstrument
{
    public Violin()
        : base("Скрипка", "Струнний смичковий, високий тембр.", "З'явилася в Італії в XVI ст.")
    {

    }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: Ніжний, мелодійний звук.");
    }
}

// Похідний клас "Тромбон"
public class Trombone : MusicalInstrument
{
    public Trombone()
        : base("Тромбон", "Мідний духовий з кулісою.", "Походить від кулісної труби XV ст.")
    {

    }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: Потужний, величний звук.");
    }
}

// Похідний клас "Укулеле"
public class Ukulele : MusicalInstrument
{
    public Ukulele()
        : base("Укулеле", "Маленький 4-струнний щипковий з Гаваїв.", "Розроблено на Гаваях у 1880-х на основі португальських інструментів.")
    {

    }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: Дзвінкий, радісний звук.");
    }
}

// Похідний клас "Віолончель"
public class Cello : MusicalInstrument
{
    public Cello()
        : base("Віолончель", "Струнний смичковий басового та тенорового регістрів.", "З'явилася в XVI ст. як розвиток віоли да гамба.")
    {

    }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: Глибокий, співучий звук.");
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Violin violin = new Violin();
        Trombone trombone = new Trombone();
        Ukulele ukulele = new Ukulele();
        Cello cello = new Cello();

        violin.Show();
        violin.Desc();
        violin.Sound();
        violin.History();
        Console.WriteLine();

        trombone.Show();
        trombone.Desc();
        trombone.Sound();
        trombone.History();
        Console.WriteLine();

        ukulele.Show();
        ukulele.Desc();
        ukulele.Sound();
        ukulele.History();
        Console.WriteLine();

        cello.Show();
        cello.Desc();
        cello.Sound();
        cello.History();
        Console.WriteLine();
    }
}