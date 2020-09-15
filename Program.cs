using System;

namespace Modellering
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
             Gun AR = new Gun();
              Gun pistol = new Gun();
              Enemy mob = new Enemy();

             Gun firearm = new Gun();
            firearm.equipped = "no gun";

            Random generator = new Random();
            mob.hp = generator.Next(35,120);
            mob.armor = generator.Next(10,25);
            mob.dodge = generator.Next(1,10);
            
           
           System.Console.WriteLine("gun range time.");
           System.Console.WriteLine("you currectly have "+ firearm.equipped + " equipped." );
            System.Console.WriteLine("do you want to use the shop or enter the battlefeild?");
            System.Console.WriteLine("Please write shop or battle.");
            string answer = Console.ReadLine(); 

            if(answer == "shop")
            {
              System.Console.WriteLine("hello you want pistol or AR");
             string answer2 = Console.ReadLine(); 

              if (answer2 == "pistol")
              {
                handGun(pistol,firearm);
                Console.WriteLine("you currectly have "+ firearm.equipped + " equipped." );
                Console.ReadLine();
                
              }
                else if (answer2 == "AR")
                {
                 rifle(AR,firearm);
                Console.WriteLine("you currectly have "+ firearm.equipped + " equipped." );
                Console.ReadLine();
                }
               else{
                   System.Console.WriteLine("vad gör du idiot");
                }
               
                
            }
           Console.Clear();
          System.Console.WriteLine("okay cool now you are shooting enemy");
          System.Console.WriteLine("Press enter when you are ready.");
          Console.ReadLine();
          Console.Clear();
                   
          System.Console.WriteLine("An enemy appears, it has " + mob.hp + " HP");
          
          Console.WriteLine("You shoot the enemy for " + shoot(firearm, mob) + " Damage.");
          System.Console.WriteLine("The enemy has " + mob.hp + " HP left.");
          Console.ReadLine();
          

        }
       static void handGun(Gun pistol, Gun firearm)
            {
                firearm.equipped = "pistol";
                  firearm.damage = pistol.pistoldmg;
                  firearm.accuracy = pistol.pistolAccuracy;
                  firearm.range = pistol.pistolRange;
            }   
            static void rifle(Gun AR, Gun firearm)
            {
                firearm.equipped = "AR";
                  firearm.damage = AR.arDMG;
                  firearm.accuracy = AR.arAccuracy;
                  firearm.range = AR.arRange;
            }   
      static float shoot( Gun firearm, Enemy mob)
      {       
       float gunDmg = firearm.range * firearm.accuracy / firearm.damage;
       float enemyHP = mob.hp + mob.armor;
       
       if (mob.dodge <= 3)
       {
         gunDmg= 0;
       } 
       float dmg = enemyHP - gunDmg;
        mob.hp = enemyHP - dmg;
       return dmg;
      
       
      
      }
    
    }
    
}
