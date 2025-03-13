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
        public float circleX = 25;
        bool helicopterDown = false;
        bool helicopterUp = false;

        Texture2D helicopter1 = Graphics.LoadTexture("../../../assets/textures/helicopter.png");
        Texture2D helicopter = Graphics.LoadTexture("../../../assets/textures/helicopter.png");
        Texture2D helicopterAngledDown = Graphics.LoadTexture("../../../assets/textures/helicopterangled.png");
        Texture2D helicopterAngledUp = Graphics.LoadTexture("../../../assets/textures/helicopterangledup.png");
        //jet
        public void Render()
        {
            Draw.FillColor = Color.Black;
            Graphics.Draw(helicopter,circleX, playY);
        }
        //player movement
        public void PlayerFunction()
        {
            if (helicopterDown == false && helicopterUp == false)
            {
                helicopter = helicopter1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && playY <= 375)
            {
                playY += Time.DeltaTime * playSpeed;
                helicopterDown = true;
            }
            if (helicopterDown)
            {
                helicopter = helicopterAngledDown;
                helicopterDown = false;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && playY >= 25)
            {
                playY -= Time.DeltaTime * playSpeed;
                helicopterUp = true;

            }
            if (helicopterUp)
            {
                helicopter = helicopterAngledUp;
                helicopterUp= false;
            }
        }
    }
}

