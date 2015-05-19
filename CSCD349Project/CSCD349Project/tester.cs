using System;
namespace CSCD349Project
{
    public class tester
    {
        public static void Main(string[] args)
        {
            Map thisMap = new Map(new int[] {10,10});
            Party thisParty = new Party("party one", thisMap.GetCellAt(3,3));

            Cell thisCell = thisMap.GetCellAt(1, 1);
            GameCharacter warrior1 = new Warrior();
            GameCharacter warrior2 = new Warrior();
            warrior1.SetCell(thisCell);
            warrior2.SetCell(thisCell);

            //Test Warrior toString()
            //Console.WriteLine(warrior);

            //Test WarriorSlash and WarriorLiftShield
            OffensiveAbility attackAbility = new WarriorSlash();
            DefensiveAbility defenseAbility = new WarriorLiftShield();

            warrior1.getAttributes().SetActiveAttack(warrior1.getAttributes()._Attacks[0]);
            warrior2.getAttributes().SetActiveDefense(warrior2.getAttributes()._Defenses[0]);

            
            Console.WriteLine("BEFORE WARRIOR 1 ATTACKS WARRIOR 2");
            Console.WriteLine(warrior1);
            Console.WriteLine(warrior2);

            try
            {
                warrior1.getAttributes().GetActiveAttack().attack(warrior1, warrior2);
            }
            catch()

            Console.WriteLine("AFTER WARRIOR 1 ATTACKS WARRIOR 2");
            Console.WriteLine(warrior1);
            Console.WriteLine(warrior2);

            /*
            Console.WriteLine(warrior1.getAttributes().GetActiveAttack()._successRate);
            Console.WriteLine(warrior2.getAttributes().GetActiveDefense()._successRate);
            */

            // Wait for the user to type something...
            Console.ReadLine();

        }
    }
}