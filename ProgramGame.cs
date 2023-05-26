class Program
{
    static void Main(string[] args)
    {

        GameItem gameItem = new GameItem();
        gameItem.Name = "PUBG Mobile";
        gameItem.Level = "Cao Thu";
        gameItem.Score = "777";

        Weapon weapon = new Weapon();
        weapon.sword = "Fire sword";
        weapon.gun = "AK47 guns";

        Armor armor = new Armor();
        armor.Shield = "Ice shield";
        armor.cloak = "Night cloak";
        Console.WriteLine("Truong Cong Viet Top 1 Sever");

        Consumable comsumable = new Consumable
        {
            bomb = "Fire bomb"
        };
        Console.WriteLine(gameItem.Name);
        Console.WriteLine(gameItem.Level);
        Console.WriteLine(gameItem.Score);
        Console.WriteLine(weapon.sword);
        Console.WriteLine(armor.Shield);
        Console.WriteLine(comsumable.bomb);
    }
}