// Базовый класс Animal
public class Animal
{
    public string Food { get; set; }
    public string Location { get; set; }

    public Animal(string food, string location)
    {
        Food = food;
        Location = location;
    }
    //virtual означает что метод переопределяется
    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное шумит");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Животное ест");
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

// Класс Dog расширяет Animal
public class Dog : Animal
{
    public string Name { get; set; } // Имя собаки

    public Dog(string food, string location, string name) : base(food, location)
    {
        Name = name;
    }

    // override означает что этот метод переопределяет методж из базового класса
    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака ест " + Food);
    }
}

// Класс Cat расширяет Animal
public class Cat : Animal
{
    public string Name { get; set; } // Имя кошки

    public Cat(string food, string location, string name) : base(food, location)
    {
        Name = name;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяукает");
    }

    public override void Eat()
    {
        Console.WriteLine("Кошка ест " + Food);
    }
}

// Класс Horse расширяет Animal
public class Horse : Animal
{
    public String Name { get; set; } // Имя лошади

    public Horse(string food, string location, String name) : base(food, location)
    {
        Name = name;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }

    public override void Eat()
    {
        Console.WriteLine("Лошадь ест " + Food);
    }
}

public class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Питание: {animal.Food}, Местоположение: {animal.Location}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Указываем информацию про животных
        Animal[] animals = new Animal[]
        {
            new Dog("Корм для собак", "Будка", "Бобик"),
            new Cat("Корм для кошек", "Дом", "Чудо"),
            new Horse("Сено", "Конюшня", "Сильван")
        };

        Veterinarian vet = new Veterinarian();

        //С помощью foreach проходим по всем животным и для каждого вызываем методы
        foreach (Animal animal in animals)
        {
            animal.MakeNoise();
            animal.Eat();
            vet.TreatAnimal(animal);
            Console.WriteLine("----------------------------------------");
        }
    }
}