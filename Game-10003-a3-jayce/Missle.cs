// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Missle
    {
        Player player;
        Texture2D missleTexture = Graphics.LoadTexture("../../../assets/textures/missle.png");
        Texture2D missleTexture1 = Graphics.LoadTexture("../../../assets/textures/missle.png");
        Texture2D missleTextureFlying = Graphics.LoadTexture("../../../assets/textures/misslemoving.png");
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
            
            Graphics.Draw(missleTexture,missleX, missleY);
        }
            //or hitswall
            public void missleWasShot()
        { 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && !missleShot && missleX <=200)
            {
                missleShot = true;
                missleTexture = missleTextureFlying;
                Console.WriteLine("Missle fired");
            }
            if (missleShot == true)
            {
                missleX += Time.DeltaTime * missleSpeed;
            }
            if (missleShot == false)
            {
                missleTexture = missleTexture1;
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


