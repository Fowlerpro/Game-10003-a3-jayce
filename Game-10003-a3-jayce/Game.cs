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
        Missle missle;
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
            missle = new Missle();
            life.lifeSetup();
            destructableWalls.destructableWallsetup();
            walls.wallSetup();
            missle.misslesetup();
            missle.missleWasShot();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.DarkGray);
            player.Render();
            player.PlayerFunction();
            missle.missleFunction();
            //life.lifeLost2();
            //gameover();
            missle.missleRender();
            destructableWalls.render();
            destructableWalls.destroyed();
            walls.render();
            life.livesRender();
            life.lives();
            missle.missleWasShot();
            wallWasHit();


        }
        //when the missle hits the wall
        public void wallWasHit()
        {
            if (missle.missleX > 500 || missle.missleX > destructableWalls.scaffoldDestructionX)
            {
                if (missle.missleX >= destructableWalls.scaffoldDestructionX && missle.missleShot == true)
                {
                    missle.wallhit = true;
                    if (missle.wallhit == true) {
                        Console.WriteLine("Missle hit wall");
                      }
                    missle.missleX = player.circleX;
                    missle.missleShot = false;
                    destructableWalls.scaffoldDestructionX = 700;

                }
                else if (missle.missleX >= 500)
                {
                    missle.missleX = player.circleX;
                    missle.missleShot = false;
                }
            }
        }
    }
}

