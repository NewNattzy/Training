using GameObjects;
using GameObjectGenerator;

namespace ConsoleGame
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            // TODO: Довести до ума генератор игрока, пока что-то странное
            Object player = PlayerGenerator.PlayerCreate();
            
            Console.ReadKey();
            
        }
        
    }
    
}
