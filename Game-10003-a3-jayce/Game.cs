// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Player player;
        DestructableWalls destructableWalls;
        Life life;
        Wall walls;
        //missle
        //float missleSpeed = 250;
        //public static float missleX = 100;       
        //working on a life cooldown 
        // need array of scaffolds
        //need end screen
        // need replay button


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Tunnel Flyer");
            player = new Player();
            destructableWalls = new DestructableWalls();
            life = new Life();
            walls = new Wall();
            destructableWalls.destructableWallsetup();
            walls.wallSetup();
            life.lifeSetup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.DarkGray);
            life.lives();
            life.livesRender();
            //gameover();
            Draw.FillColor = Color.Black;
            player.Render();
            player.PlayerFunction();
            destructableWalls.render();
            destructableWalls.destroyed();
            destructableWalls.lives();
            walls.render();
            walls.lives();
            //Missle
            //Draw.FillColor = Color.Yellow;
            //Draw.Circle(missleX, player.playY +20, 5);
            //if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            //{
            //    missleX += Time.DeltaTime * missleSpeed;
            //}
            ////or hitswall
            //if (missleX > 500)
            //{
            //    missleX = player.circleX;
            //}
            ////scaffold
            //Draw.FillColor = Color.Black;
            //Draw.Rectangle(scaffoldX, scaffoldY, 40, 200);
            //scaffoldX -= Time.DeltaTime * scaffoldSpeed;
            //if (scaffoldX < -5)
            //{
            //    scaffoldX = 420;
            //}
            //if (player.circleX >= scaffoldX && player.playY <= scaffoldY +200)
            //{
            //    if (life.islife1Gone == false)
            //    {
            //        scaffoldX = 800;
            //        life.islife1Cooldown = true;
            //    }
            //    if (life.islife1Gone == true)
            //    {
            //        scaffoldX = 800;
            //        life.islife2Cooldown = true;
            //    }
            //    if (life.islife2Gone == true)
            //    {
            //        scaffoldX = 800;
            //        life.islife3Cooldown = true; 
            //    }
            //}
            //lives temp
            //health gone
            //void lives()
            //{
            //    if (islife1Cooldown == true)
            //    {
            //        lifeX1 += Time.DeltaTime * scaffoldSpeed;
            //        if (lifeX1 >= Window.Width)
            //        {
            //            islife1Gone = true;
            //        }
            //    }
            //     if (islife2Cooldown == true)
            //    {
            //        lifeX2 += Time.DeltaTime * scaffoldSpeed;
            //        if (lifeX2 >= Window.Width)
            //        {
            //            islife2Gone = true;
            //        }
            //    }
            //     if (islife3Cooldown == true)
            //    {
            //        lifeX3 += Time.DeltaTime * scaffoldSpeed;
            //        if (lifeX3 >= Window.Width)
            //        {
            //            islife3Gone = true;
            //        }
            //    }
                 
            //};
           }
        //    //lives
        //    void livesRender()
        //{
        //    Draw.FillColor = Color.Black;
        //    Draw.Circle(300, lifeY, 10);
        //    Draw.Circle(330, lifeY, 10);
        //    Draw.Circle(360, lifeY, 10);
        //    Draw.FillColor = Color.Gray;
        //    Draw.Circle(300, lifeY, 9);
        //    Draw.Circle(330, lifeY, 9);
        //    Draw.Circle(360, lifeY, 9);
        //    Draw.FillColor = Color.Red;
        //    Draw.Circle(lifeX1, lifeY, 9);
        //    Draw.Circle(lifeX2, lifeY, 9);
        //    Draw.Circle(lifeX3, lifeY, 9);
        //    void gameover()
        //    {
        //        if (islife3Gone == true)
        //        {
        //            Draw.Rectangle(0, 0, 400, 400);
        //        }
        //    }
        //}

    }
}
