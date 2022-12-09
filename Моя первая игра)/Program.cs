// See https://aka.ms/new-console-template for more information

//It's my first game)

// Меня зовут Борис, и я обьект Класса Человек! 

// Давайте разработаем класс врага! 

// 

public enum EnemyType { Tank, Archer, Wizard }


static class Fire
{
    private static double Damage = 1.5;

    public static void OnDamage(Enemy enemy)
    {
        enemy.Hurt(Damage);
    }
}

public class Enemy
{
    public string Name { get; set; }
    public string Description { get; set; }
    private double _health = 100.0;
    private double _armor = 100.0;
    private double _attack = 0.0;
    private EnemyType _enemyType;

    private const double MAX_HEALTH = 100.0;

    public static double MaxAttackLevel = 200.0;
    private readonly double _minimumHealth = 0.0;



    public double Health 
    {
        get
        {
            return _health;
        }
        private set
        {
            //if (value/)
        }
    }

    public double Armor
    {
        get { return _armor; } 
        set
        {
            if (_enemyType != EnemyType.Wizard)
            { 
            
            }
        }
    }
    public void Deconstructor (out double сurHealth, out double сurArbor)
    {
        сurHealth = this._health;
        сurArbor = this._armor;
    }

    
    public static void PrintDescription ()
    {

    }

    // паттерн синглтон
    public double GetHealth() { return _health; }
    public Enemy(double health, double armor, EnemyType enemyType)
    {
      this._armor = armor;
      this._health = health;
      this._enemyType = enemyType;
    }
    public void Hurt(double damage)
    {
        this._health -=  damage/ this._armor;
    }
    public Enemy(EnemyType enemyType)
    {
        _enemyType = enemyType;
        switch (enemyType)
        {
            case EnemyType.Tank: _attack = 10; break;
            case EnemyType.Archer: _attack= 3; break;
            case EnemyType.Wizard: _attack= 7; break;
        }
    }

    public void PrintState() => Console.WriteLine($"Здоровье {_health} \n Броня {_armor}");
    // The is very angry enemy
    // His name is Charly
}

class Program
{
    delegate T SomeDelegate<T,O>(O param1, O param2);
    static double CalcMult(int a, int b)
    {
        return a * b;
    }
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
    static void Main()
    {
        SomeDelegate <double,double> deleg = CalcMult;//?
        //Console.WriteLine();
        //Enemy enemy = new Enemy(EnemyType.Tank);
        //enemy.PrintState();
        //List<Player> players = new List<Player>() { tank, healer};// нет реализации класса игрока
        //любят использовать foreach больше чем for (int i = 0;...)
        //Add
        //Remove
        //RemoveAt - удаление по индексу
        //bool containsHealer = players.Exists(x => x.Type => PlayerType.Archer);
        //Queue<Player> queue = new Queue<Player>();
        //queue.Enqueue(tank);
        //queue.Enqueue(healer);
        //Console.WriteLine(queue Dequeue );
        //Peek - посмотреть то, что лежит в конце очереди, но не забрать из очереди
        //try - попытка забрать из очереди
        //Dictionary<PlayerType, Player> dict = new Dictionary<PlayerType, Player>();
        //Dictionary.Add(PlayerType.Tank, tank);
        //dict[PlayerType.Healer] = healer;

        // foreach(PlayerType p in dict.keys)
        //   {
        //    
        //   }
    }
}

class Player
{
}

//delegate void Printer();





