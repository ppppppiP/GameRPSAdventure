Console.WriteLine("В игре можно использовать кнопки клавиатуры");
Console.WriteLine("II - посмотреть инвентарь");
Console.WriteLine("Выберете персонажа, которым вы хотите играть");
Console.WriteLine("Рыцарь/Маг Q/E");

Personage mag = new Magitian();
Personage knight = new Knight();
if (Console.ReadKey().Key == ConsoleKey.Q)
{
    Console.WriteLine("Вы выбрали рыцаря!, удачного вам путешествия");
    if (Console.ReadKey().Key == ConsoleKey.I)
    {
        Console.WriteLine();
        knight.Inventary();
    }

}

else if (Console.ReadKey().Key == ConsoleKey.E)
{
    Console.WriteLine("Вы выбрали рыцаря!, удачного вам путешествия");

}





class Personage
{
    public virtual int Helth( int helth) {
        helth = 0;
        return helth;
    }
   
    public virtual int Mana(int mana) {
        mana = 0;
        return mana;
    }
    public virtual int Money(int money)
    {
        money = 0;
        return money;
    }
    public virtual void Damage()
    {

    }
    public virtual void Inventary() 
    {
         
    }

}
class Knight: Personage
{
    public override int Helth(int helth)
    {
        helth = 150;
        return helth;
    }
    public override int Mana(int mana)
    {
        mana = 0;
        return mana;
    }
    public override int Money(int money)
    {
        money = 100;
        return money;
    }
    public override void Inventary()
    {
        string[] invt = new string[5]; int damage;
        invt[0] = "ржавый меч";
        if (invt.Length > 0)
        {
            for (int i = 0; i < invt.Length; i++)
            {
                if (invt[i] == "ржавый меч")
                {
                    damage = 5;
                    if (Console.ReadKey().Key == ConsoleKey.I)
                    {
                        string invShow = invt[i];
                        Console.WriteLine(invShow);
                    }
                }
            }

            }else
               {
                if (invt[0] == "ржавый меч")
                {
                    damage = 5;
                    if (Console.ReadKey().Key == ConsoleKey.I)
                    {
                        string invShow = invt[0];
                        Console.WriteLine(invShow);
                    }
                }
               }
        }
    }
     
    




class Magitian : Personage
{
    public override int Helth(int helth)
    {
        helth = 100;
        return helth;
    }
    public override int Mana(int mana)
    {
        mana = 200;
        return mana;
    }
    public override int Money(int money)
    {
        money = 100;
        return money;
    }
    public override void Inventary()
    {
        string[] invt = {}; int damage;
        invt[0] = "иссохшая волшебная палочка";
        for (int i = 0; i < invt.Length; i++)
        {
            if (invt[i] == "иссохшая волшебная палочка")
            {
                damage = 5;
            }
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                string invShow = invt[i];
                Console.WriteLine(invShow);
            }

        }
    }

}
