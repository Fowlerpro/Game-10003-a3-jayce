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
        Game game;
        //Random scaffold walls
        int wall1Y = 0;
        int wall2Y = 300;
        float scaffoldSpeed = 100;
        public float scaffoldX = 420;
        float scaffoldY = 0;
        int wallcount = 9;
        Vector2[] wallposition1;
        Vector2[] wallposition2; 
        public void wallSetup()
        {
            player = new Player();
            life = new Life();
            game = new Game();
        }
        public void render()
        {
            //scaffold
            // only activate when scaffold hits half way or space them out far enough
            //if (scaffoldX < -5)
            //{
            //    scaffoldX = 420;
            //}
            wallposition1 = new Vector2[wallcount];
            wallposition2 = new Vector2[wallcount];
            for (int i = 0; i < wallcount; i++)
            {
                wallposition1[i].Y = Random.Integer(Window.Height, Window.Height +200);
                wallposition2[i].Y = Random.Integer(Window.Height +300, Window.Height +400);
            }
            for (int i = 0; i < wallcount; i++)
            {
                if (scaffoldX < -5)
                {
                    scaffoldX = 420;
                }
                scaffoldX -= Time.DeltaTime * scaffoldSpeed;
                Draw.FillColor = Color.Black;
                Draw.Rectangle(scaffoldX, wallposition1[i].Y, 40, 200);
                Draw.Rectangle(scaffoldX, wallposition2[i].Y, 40, 200);
            }
            //public void lives()
            //{
            //    if (player.circleX >= scaffoldX && player.playY >= walls1[] + 200  || walls2[] +200)
            //    {
            //        game.lifeLost(scaffoldX);
            //    }
            //}
        }
    }
}
