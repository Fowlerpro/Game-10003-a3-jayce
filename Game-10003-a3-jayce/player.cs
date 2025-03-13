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
        Texture2D helicopter = Graphics.LoadTexture("../../../assets/textures/helicopter.png");
        //jet
        public void Render()
        {
            Draw.FillColor = Color.Black;
            Graphics.Draw(helicopter,circleX, playY);
        }
        //player movement
        public void PlayerFunction()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && playY <= 375)
            {
                playY += Time.DeltaTime * playSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && playY >= 25)
            {
                playY -= Time.DeltaTime * playSpeed;

            }
        }
    }
}

