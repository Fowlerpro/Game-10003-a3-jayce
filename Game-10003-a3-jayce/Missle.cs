// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Missle
    {
        Player player;
        public float missleX = 100;
        public float missleY = 220;
        public float missleSpeed = 250;
        public bool missleShot = false;
        public bool wallhit = false;
        public void misslesetup()
        {
            player = new Player();
        }
        public void missleRender()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Circle(missleX, missleY, 5);
        }
            //or hitswall
            public void missleWasShot()
        { 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && !missleShot && missleX <=200)
            {
                missleShot = true;
                Console.WriteLine("Missle fired");
            }
            if (missleShot == true)
            {
                missleX += Time.DeltaTime * missleSpeed;
            }
           }
            public void missleFunction()
        {
            if (missleX <= 125)
            {

                if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && missleY <= 395)
                {
                    missleY += Time.DeltaTime * player.playSpeed;
                }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && missleY >= 5)
                {
                    missleY -= Time.DeltaTime * player.playSpeed;

                }
            }
        }
       }
    }


