
namespace Protect_yourself.script.simulated.protect.boost
{
    internal class health
    {
       public int health_point { get; set; }
        public bool isScan = false;
        public bool Freeze = false;
        public bool isOnFireWall = false;
        public health() { 
            health_point = 100;
        }
    }
}
