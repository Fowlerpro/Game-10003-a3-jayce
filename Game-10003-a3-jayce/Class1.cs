using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace MohawkGame2D
{
    public class Player
    {
        //player 
        float playSpeed = 150;
        float playY = 200;
        float circleX = 100;
        
    
      public void PlayerFunction()
        {


            //player
            Draw.Circle(circleX, playY, 10);
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

