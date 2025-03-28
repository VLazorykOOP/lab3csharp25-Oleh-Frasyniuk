using System;

public class Person
{
    // Поля базового класу
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Метод для виведення даних про об'єкт
    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
    }
}

public class Employee : Person
{
    // Поле для класу Службовець
    public string Position { get; set; }

    // Конструктор
    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    // Перевизначення методу Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Посада: {Position}");
    }
}

public class Worker : Person
{
    // Поле для класу Робітник
    public string Specialty { get; set; }

    // Конструктор
    public Worker(string name, int age, string specialty) : base(name, age)
    {
        Specialty = specialty;
    }

    // Перевизначення методу Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціальність: {Specialty}");
    }
}

public class Engineer : Person
{
    // Поле для класу Інженер
    public string AreaOfWork { get; set; }

    // Конструктор
    public Engineer(string name, int age, string areaOfWork) : base(name, age)
    {
        AreaOfWork = areaOfWork;
    }

    // Перевизначення методу Show()
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Область роботи: {AreaOfWork}");
    }
}

class Program
{
    // Функція для заповнення масиву різними об'єктами
    public static Person[] FillArray()
    {
        Person[] people = new Person[5];

        // Створення об'єктів різних типів
        people[0] = new Employee("Іван Петренко", 35, "Менеджер");
        people[1] = new Worker("Олексій Сидоренко", 40, "Слюсар");
        people[2] = new Engineer("Марина Коваль", 30, "Програміст");
        people[3] = new Employee("Аліна Кравченко", 28, "Бухгалтер");
        people[4] = new Worker("Петро Іванов", 45, "Електрик");

        return people;
    }

    // Функція для впорядкування масиву за віком
    public static void SortByAge(Person[] people)
    {
        Array.Sort(people, (x, y) => x.Age.CompareTo(y.Age));
    }

    static void Main()
    {
        // Заповнення масиву
        Person[] people = FillArray();

        // Виведення початкового масиву
        Console.WriteLine("До сортування:");
        foreach (var person in people)
        {
            person.Show();
            Console.WriteLine();
        }

        // Сортуємо масив за віком
        SortByAge(people);

        // Виведення відсортованого масиву
        Console.WriteLine("Після сортування за віком:");
        foreach (var person in people)
        {
            person.Show();
            Console.WriteLine();
        }
    }
}
