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
        Texture2D Background = Graphics.LoadTexture("../../../assets/textures/background.png");
        float backgroundX = 0;
        float backgroundSpeed = 10;
        bool walltouching = false;
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
            BackgroundMoving();
            player.Render();
            player.PlayerFunction();
            missle.missleFunction();
            lifeLost();
            //gameover();
            missle.missleRender();
            destructableWalls.render();
            destructableWalls.destroyed();
            walls.render();
            life.livesRender();
            life.lives();
            missle.missleWasShot();
            wallWasHit();
            scaffoldCollision();

        }
        void BackgroundMoving()
        {
            backgroundX -= Time.DeltaTime * backgroundSpeed;
            Graphics.Draw(Background, backgroundX, 0);
            if (backgroundX > 0)
            {
                backgroundX = 0;
            }
        }
        //when the missle hits the wall
        public void wallWasHit()
        {
            if (missle.missleX > Window.Width || missle.missleX > destructableWalls.scaffoldDestructionX)
            {
                if (missle.missleX >= destructableWalls.scaffoldDestructionX && missle.missleShot == true)
                {
                    missle.wallhit = true;
                    if (missle.wallhit == true)
                    {
                        Console.WriteLine("Missle hit wall");
                        destructableWalls.scaffoldDestructionX = 700;
                    }
                    missle.missleX = player.circleX;
                    missle.missleY = player.playY + 5;
                    missle.missleShot = false;
                }
                else if (missle.missleX >= Window.Width)
                {
                    missle.missleX = player.circleX;
                    missle.missleY = player.playY + 5;
                    missle.missleShot = false;
                }
                //need to add a cooldown in missle.cs
            }
        }
        //Missle collision with wall
        public void scaffoldCollision()
        {
            for (int i = 0; i < walls.wallcount; i++)
            {
                if (missle.missleX >= walls.scaffoldX1[i] && missle.missleX <= walls.scaffoldX1[i] + 60 && missle.missleShot == true && missle.missleY <= walls.wallposition1[i] + 400)
                {
                        missle.missleX = player.circleX;
                    missle.missleY = player.playY + 5;
                    missle.missleShot = false;
                }
                else if (missle.missleX >= walls.scaffoldX2[i] && missle.missleX <= walls.scaffoldX2[i]+60 && missle.missleShot == true && missle.missleY >= walls.wallposition2[i])
                {
                        missle.missleX = player.circleX;
                    missle.missleY = player.playY + 5;
                    missle.missleShot = false;
                }
                //lives lost if player hits a wall
                //if (player.circleX >= walls.scaffoldX1[i] && player.circleX <= walls.scaffoldX1[i] + 70 && player.playY <= walls.wallposition1[i] + 400 || player.circleX >= walls.scaffoldX2[i] && player.circleX <= walls.scaffoldX2[i] + 70 && player.playY >= walls.wallposition2[i] + 400)
                //{

                //    life.lifeCooldowns[0] = true;
                //}
                //if (life.livesGone[0] == true && player.circleX >= walls.scaffoldX1[i] && player.circleX <= walls.scaffoldX1[i] + 70 && player.playY <= walls.wallposition1[i] + 400 || life.livesGone[0] == true && player.circleX >= walls.scaffoldX2[i] && player.circleX >= walls.scaffoldX2[i] + 70 && player.playY <= walls.wallposition2[i] + 400)
                //{
                //    life.lifeCooldowns[1] = true;
                //}
                //if (life.livesGone[1] == true && player.circleX >= walls.scaffoldX1[i] && player.circleX <= walls.scaffoldX1[i] +70 && player.playY <= walls.wallposition1[i] + 400 || life.livesGone[1] == true&& player.circleX >= walls.scaffoldX2[i] && player.circleX >= walls.scaffoldX2[i] + 70 && player.playY <= walls.wallposition2[i] + 400)
                //{
                //    life.lifeCooldowns[2] = true;
                //}
            }
        }
        public void lifeLost()
        {
            if (player.circleX +30 >= destructableWalls.scaffoldDestructionX && player.circleX >= destructableWalls.scaffoldDestructionX + 30)
            {

                life.lifeCooldowns[0] = true;
            }
            if (life.livesGone[0] == true && player.circleX +30 >= destructableWalls.scaffoldDestructionX && player.circleX >= destructableWalls.scaffoldDestructionX + 30)
            {
                life.lifeCooldowns[1] = true;
            }
            if (life.livesGone[1] == true && player.circleX +30 >= destructableWalls.scaffoldDestructionX && player.circleX >= destructableWalls.scaffoldDestructionX + 30)
            {
                life.lifeCooldowns[2] = true;
            }
        }
    }
}


