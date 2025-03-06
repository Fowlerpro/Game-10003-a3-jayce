// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Missle
    {
        Player player;
        float missleSpeed = 250;
        public static float missleX = 100;
        public void misslesetup()
        {
            player = new Player();
        }
        public void missleRender()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Circle(missleX, player.playY + 20, 5);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                missleX += Time.DeltaTime * missleSpeed;

                //or hitswall
                if (missleX > 500)
                {
                    missleX = player.circleX;
                }
            }
        }
    }
}

