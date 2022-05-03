namespace Sapt1
{
    class Program
    {
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }

        // value passed by value
        static void ChangeValueOfValueTypeFieldPassedByValue(Weapon weapon)
        {
            weapon.name = "new name";
        }

        // value passed by reference
        static void ChangeValueOfValueTypeFieldPassedByReference(ref Weapon weapon)
        {
            weapon.name = "new name";
        }

        // raference passed by value
        static void ChangeValueOfReferenceTypeFieldPassedByValue(Monster monster)
        {
            monster.Damage = 300;
        }

        // reference passed by value
        static void ChangeValueOfReferenceTypePassedByValue(Monster monster)
        {
            monster = new Monster(300, 300);
        }

        // reference passed by reference
        static void ChangeValueOfReferenceTypePassedByReference(ref Monster monster)
        {
            monster = new Monster(300, 300);
        }


        static void Main(string[] args)
        {
            // List<int> numsList = new List<>() ...
            var numsList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // var evensList = numsList.Where(isEven).ToList();
            var evensList = numsList.Where(n => n % 2 == 0).ToList();
            for (int i = 0; i < evensList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {evensList[i]}");
            }
            foreach (var n in evensList)
            {
                Console.WriteLine($"{n}");
            }

            Console.WriteLine("==========================");

            Monster m1 = new Monster();
            Console.WriteLine($"m1.Health: {m1.Health}, m1.Damage: {m1.Damage}");

            Monster m2 = new Monster(100, 10);
            Console.WriteLine($"m2.Health: {m2.Health}, m2.Damage: {m2.Damage}");
            // Console.WriteLine($"m1 == m2: {m1 == m2}");

            Console.WriteLine("==========================");
            Weapon w1 = new Weapon();
            ChangeValueOfValueTypeFieldPassedByValue(w1);
            Console.WriteLine($"w1.name: {w1.name}"); // Sword

            Weapon w2 = new Weapon();
            ChangeValueOfValueTypeFieldPassedByReference(ref w2);
            Console.WriteLine($"w2.name: {w2.name}"); // new name

            Monster m3 = new Monster();
            ChangeValueOfReferenceTypeFieldPassedByValue(m3);
            Console.WriteLine($"m3.Damage: {m3.Damage}"); // 300

            Monster m4 = new Monster();
            ChangeValueOfReferenceTypePassedByValue(m4);
            Console.WriteLine($"m4.Damage: {m4.Damage}"); // 10

            Monster m5 = new Monster();
            ChangeValueOfReferenceTypePassedByReference(ref m5);
            Console.WriteLine($"m5.Damage: {m5.Damage}"); // 300

            // Console.WriteLine("Hello World!");
        }
    }
}