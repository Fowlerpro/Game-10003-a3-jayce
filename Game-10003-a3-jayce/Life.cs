// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Life
    {
        Player player;
        int lifeY = 20;
        float lifeX1 = 300;
        float lifeX2 = 330;
        float lifeX3 = 360;
        int lifeX = 270 + 30;
        float emptyLifeX = 200;
        float lifeSpeed = 100;
        bool islife2Gone = false;
        bool[] livesGone = [false, false, false];
        bool[] lifeCooldowns = [false, false, false];
        float[] livesArray;
        public void lifeSetup()
        {
            player = new Player();
            livesArray = new float[3];
        }
        public void livesRender()
        {
            //Draw.FillColor = Color.Black;
            //Draw.Circle(300, lifeY, 10);
            //Draw.Circle(330, lifeY, 10);
            //Draw.Circle(360, lifeY, 10);
            for (int i = 0; i <3; i++)
            {
                Draw.FillColor = Color.Black;
                Draw.Circle(x, lifeY, 10);
            }
            Draw.FillColor = Color.Gray;
            Draw.Circle(300, lifeY, 9);
            Draw.Circle(330, lifeY, 9);
            Draw.Circle(360, lifeY, 9);
            Draw.FillColor = Color.Red;
            Draw.Circle(lifeX1, lifeY, 9);
            Draw.Circle(lifeX2, lifeY, 9);
            Draw.Circle(lifeX3, lifeY, 9);
        }
        public void lifeLost(float walltouching)
        {  if (walltouching >= -10)
            {
                lifeCooldowns[1] = true;
            }
            if (livesGone[1] == true && walltouching >= -10)
            {
                lifeCooldowns[2] = true;
            }
            if (islife2Gone == true)
            {
                lifeCooldowns[3] = true;
            }
        }
        public void lives()
        {
            if (lifeCooldowns[1] == true)
            {
                lifeX1 += Time.DeltaTime * lifeSpeed;
                if (lifeX1 >= Window.Width)
                {
                    livesGone[1] = true;
                }
            }
            if (lifeCooldowns[2] == true)
            {
                lifeX2 += Time.DeltaTime * lifeSpeed;
                if (lifeX2 >= Window.Width)
                {
                    livesGone[2] = true;
                }
            }
            if (lifeCooldowns[3] == true)
            {
                lifeX3 += Time.DeltaTime * lifeSpeed;
                if (lifeX3 >= Window.Width)
                {
                    livesGone[3] = true;
                }
            }

        }
    }
}
