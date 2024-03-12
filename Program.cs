namespace App4;

class Animal
{
    public string Name { get; private set; }    // 名前
    public int Age { get; private set; }        // 年齢

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Speak()
    {
        Console.WriteLine("......");
    }

    public void ShowProfile()
    {
        Console.WriteLine(Name + "," + Age + "歳");
    }
}
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {

    }
    public void Sleep()
    {
        Console.WriteLine("スースー");
    }
    public override void Speak()
    {
        Console.WriteLine("ニャー");
    }
}
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {

    }
    public void Run()
    {
        Console.WriteLine("トコトコ");
    }
    public override void Speak()
    {
        Console.WriteLine("ワンワン");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal[] animal = { new Cat("くわた", 24), new Dog("つばさ", 25), new Cat("くわた", 23), new Dog("つばさ", 26) };
        foreach (Animal a in animal)
        {
            a.ShowProfile();
            a.Speak();
        }
    }
}
