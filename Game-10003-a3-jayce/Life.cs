// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Life
    {
        Player player;
        DestructableWalls destructableWalls;
        Texture2D helicopterLife = Graphics.LoadTexture("../../../assets/textures/helicopterlife.png");
        int lifeY = 20;
        float lifeX1 = 270;
        float lifeX2 = 300;
        float lifeX3 = 330;
        float lifeSpeed = 100;
       public  bool[] livesGone = [false, false, false];
       public  bool[] lifeCooldowns = [false, false, false];
        public void livesRender()
        {

                Draw.FillColor = Color.Red;
                Graphics.Draw(helicopterLife, lifeX1, lifeY);
                Graphics.Draw(helicopterLife, lifeX2, lifeY);
                Graphics.Draw(helicopterLife, lifeX3, lifeY);
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
