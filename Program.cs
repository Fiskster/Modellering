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
                 Console.ReadLine();
              if (answer == "pistol")
              {
                handGun(firearm, pistol);
                Console.WriteLine("you currectly have "+ firearm.equipped + " equipped." );
                Console.ReadLine();
                // rad 32 är för debug
              }
                else if (answer == "AR")
                {
                
                }
               else{
                   System.Console.WriteLine("vad gör du idiot");
                }
               
                Console.ReadLine();
            }
           
       
        }
       static void handGun(Gun pistol, Gun firearm)
            {
                firearm.equipped = "pistol";
                  firearm.damage = pistol.damage;
                  firearm.accuracy = pistol.accuracy;
                  firearm.range = pistol.range;
            }   
    
    
    }
    
}
