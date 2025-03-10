// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Missle
    {
        Player player;
        DestructableWalls destrutableWalls;
        public float missleX = 100;
        public float missleY = 220;
        public float missleSpeed = 250;
        public bool missleShot = false;
        public bool wallhit = false;
        public void misslesetup()
        {
            player = new Player();
            destrutableWalls = new DestructableWalls();
        }
        public void missleRender()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Circle(missleX, missleY, 5);
        }
            //or hitswall
            public void missleWasShot()
        { 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && !missleShot)
            {
                missleShot = true;
                Console.WriteLine("Missle fired");
            }
            if (missleShot == true)
            {
                missleX += Time.DeltaTime * missleSpeed;
            }
                    //if (missleX > 500 || missleX > destrutableWalls.scaffoldDestructionX)
                    //{
                    //    if (missleX >= destrutableWalls.scaffoldDestructionX && missleShot == true)
                    //    {
                    //        wallhit = true;
                    //        Console.WriteLine(wallhit);
                    //        missleX = player.circleX;
                    //        missleShot = false;
                    //    }
                    //    else if (missleX > 500)
                    //    {
                    //        missleX = player.circleX;
                    //        missleShot = false;
                    //    }
                    //}
            }
            public void missleFunction()
        {
            if (missleX <= 200)
            {

                if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && missleY <= 350)
                {
                    missleY += Time.DeltaTime * player.playSpeed;
                }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && missleY >= 50)
                {
                    missleY -= Time.DeltaTime * player.playSpeed;

                }
            }
        }
       }
    }


