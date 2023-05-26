using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;


class GameItem
{
    public string Name;
    public string Level;
    public string Score;
    private string gun;
    private string sword;
    private string bomb;

    public GameItem()
    {
    }

    public GameItem(string bomb)
    {
        this.bomb = bomb;
    }

    public GameItem(string gun, string sword)
    {
        this.gun = gun;
        this.sword = sword;
    }

    public GameItem(string Name, string level, string Score)
    {
        this.Name = Name;
        this.Level = level;
        this.Score = Score;
    }
    public override string ToString() { return Name + "\nName" + Level + "\nLevel" + Score + "\nScere"; }

}
class Weapon : GameItem
{
    public string gun;
    public string sword;

    public Weapon(string gun, string sword) : base(gun, sword)
    {
    }

    public Weapon()
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
class Armor : GameItem
{
    public string Shield;
    public string cloak;

    public Armor(string Shield, string cloak) : base(Shield, cloak)
    {
    }

    public Armor()
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
class Consumable : GameItem
{
    public string bomb;

    public Consumable(string bomb) : base(bomb)

    {
    }

    public Consumable()
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
