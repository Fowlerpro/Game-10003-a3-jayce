// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Player
    {
        //player 
        public float playSpeed = 150;
        public float playY = 200;
        public float circleX = 100;
        //jet
        public void Render()
        {
            Draw.Circle(circleX, playY, 10);
        }
        //player movement
        public void PlayerFunction()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && playY <= 300)
            {
                playY += Time.DeltaTime * playSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && playY >= 100)
            {
                playY -= Time.DeltaTime * playSpeed;
            }
        }
    }
}

