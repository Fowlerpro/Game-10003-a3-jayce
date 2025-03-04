// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class DestructableWalls
    {
        Player player;
        Game game;
        float scaffoldDestructionX = 600;
        float scaffoldDestructionSpeed = 100;

        
        public void wallsetup()
        {
            player = new Player();
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
            else if (Game.missleX > scaffoldDestructionX)
            {
                scaffoldDestructionX = 700;
            }
        }
        public void lives()
        {
            if (player.circleX > scaffoldDestructionX)
            {
                game.islife1Cooldown = true;
            }
            else if (player.circleX > scaffoldDestructionX && game.islife1Gone == true)
            {
                game.islife2Cooldown = true;
            }
            else if (player.circleX > scaffoldDestructionX && game.islife2Gone == true)
            {
                game.islife3Cooldown = true;
            }
        }
    }
}
