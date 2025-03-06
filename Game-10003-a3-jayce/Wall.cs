// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Wall
    {
        Player player;
        Life life;
        //Random scaffold walls
        float scaffoldSpeed = 100;
        float scaffoldX = 420;
        float scaffoldY = 0;
        public void wallSetup()
        {
            player = new Player();
            life = new Life();
        }
        public void render()
        {
            //scaffold
            Draw.FillColor = Color.Black;
            Draw.Rectangle(scaffoldX, scaffoldY, 40, 200);
            scaffoldX -= Time.DeltaTime * scaffoldSpeed;
            if (scaffoldX < -5)
            {
                scaffoldX = 420;
            }
        }
        public void lives()
        {
            if (player.circleX >= scaffoldX && player.playY <= scaffoldY)
            {
                life.lifeLost(scaffoldX);
                scaffoldX = 700;
            }
        }
    }
}
