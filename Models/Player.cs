using ReactiveUI;
namespace Sample.Models
{
    public class Player : ReactiveObject
    {                    
        public string Name { get; set; }     
        public long Sales {get; set;}

        public Player()
        {            
        }

        public Player(string name, long sales = 0)
        {            
            Name = name;
            Sales = sales;            
        }
    }
}