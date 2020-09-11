using System;

namespace Modellering
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int [] enemyHP = {30,44, 78, 95};
             Gun AR = new Gun();
              Gun pistol = new Gun();

             Gun firearm = new Gun();
            
           
            firearm.equipped = "no gun";
            
           
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
         // shoot(firearm);
          Console.WriteLine(shoot(firearm));
          Console.ReadLine();

        }
       static void handGun(Gun pistol, Gun firearm)
            {
                firearm.equipped = "pistol";
                  firearm.damage = pistol.pistoldmg;
                  firearm.accuracy = pistol.pistolAccuracy;
                  firearm.range = pistol.pistolRange;
            }   
      static float shoot( Gun firearm)
      {
       float dmg = firearm.range * firearm.accuracy / firearm.damage;
       return dmg;
      }
    
    }
    
}
