// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class DestructableWalls
    {
        Player player;
        Life life;
        Game game;

       public float scaffoldDestructionX = 600;
        float scaffoldDestructionSpeed = 100;

        
        public void destructableWallsetup()
        {
            player = new Player();
            life = new Life();
            game = new Game();
        }
        public void render()
        {
            Draw.FillColor = Color.Blue;

            Draw.Rectangle(scaffoldDestructionX, 0, 40, 400);
            scaffoldDestructionX -= Time.DeltaTime * scaffoldDestructionSpeed;
        }
        public void destroyed()
        {

            if (scaffoldDestructionX < -10)
            {
                scaffoldDestructionX = 500;
            }
        }
    }
}
