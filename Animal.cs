using System;

class Animal
{
    protected string name;
    protected int weight;

    public void SetMe(int weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }
}

class Lion : Animal
{
    public Lion(int weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public override void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }
}

class Tiger : Animal
{
    public Tiger(int weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }
    public override void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }
}