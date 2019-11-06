using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random(); 
            int speltal = slumpat.Next(1,21); 
         
            bool spela = true; 

            while (spela)
            {
               
                    
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                string stringTal = Console.ReadLine();
                //int tal = Convert.ToInt32(Console.ReadLine());
              
               

                  switch(Int32.TryParse(stringTal,out int tal))
                  {
                      case true:
                            SwitchCase(tal);
                          break;




                      
                 
                         default:
                         if(stringTal=="q".ToUpper()||stringTal=="Q".ToLower())
                         {
                               spela = false;
                               Console.WriteLine("\tDu valde att avsluta spelet!");
                         }
                         else
                         {
                              Console.WriteLine("\tSkriv in en siffra pöjk!");
                         }
               
                        
                         break;
                           
                         
                  }
                  
               

               
                
                

            }
            void SwitchCase(int tal)
            {
               
                    
               
                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
              
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                   
                }

                if (tal == speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                   
                    spela = false;
                }
             
             
            }
            

        }
      }
    
}
