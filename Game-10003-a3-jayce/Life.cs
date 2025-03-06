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
            for (int i = 0; i <3; i++)
            {
                int lifeX = 300 + i * 30;
                Draw.FillColor = Color.Black;
                Draw.Circle(lifeX, lifeY, 10);
            }
            for (int i = 0; i < 3; i++)
            {
                int lifeX = 300 + i * 30;
                Draw.FillColor = Color.Gray;
                Draw.Circle(lifeX, lifeY, 9);
            }
            for (int i = 0;i < 3; i++)
            {
                int lifeX = 300 + i * 30;
                Draw.FillColor = Color.Red;
                Draw.Circle(lifeX, lifeY, 9);
            }
        }
        public void lifeLost(float walltouching)
        {  if (walltouching >= player.circleX)
            {
                lifeCooldowns[0] = true;
            }
            else if (livesGone[0] == true && walltouching >= player.circleX)
            {
                lifeCooldowns[1] = true;
            }
            else if (islife2Gone == true && walltouching >= player.circleX)
            {
                lifeCooldowns[2] = true;
            }
            walltouching = 800;
        }
        public void lives()
        {
            if (lifeCooldowns[0] == true)
            {
                lifeX1 += Time.DeltaTime * lifeSpeed;
                if (lifeX1 >= Window.Width)
                {
                    livesGone[0] = true;
                }
            }
            if (lifeCooldowns[1] == true)
            {
                lifeX2 += Time.DeltaTime * lifeSpeed;
                if (lifeX2 >= Window.Width)
                {
                    livesGone[1] = true;
                }
            }
            if (lifeCooldowns[2] == true)
            {
                lifeX3 += Time.DeltaTime * lifeSpeed;
                if (lifeX3 >= Window.Width)
                {
                    livesGone[2] = true;
                }
            }

        }
    }
}
