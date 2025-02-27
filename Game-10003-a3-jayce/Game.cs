// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        ////player 
        float playY = 200;
        float circleX = 100;
        //missle
        float missleSpeed = 250;
        float missleX = 100;
        //Random scaffold walls
        float scaffoldSpeed = 100;
        float scaffoldX = 420;
        float scaffoldY = 0;
        float scaffoldDestructionX = 600;
        float scaffoldDestructionSpeed = 100;
        
        float lifeY = 20;
        float lifeX1 = 300;
        float lifeX2 = 330;
        float lifeX3 = 360;
        


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Tunnel Flyer");
            //walls = new Wall[100];
            //walls[0] = new Wall(scaffoldX,);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.DarkGray);
            lives();
            //gameover();
            Draw.FillColor = Color.Black;
            ////player
            //Draw.Circle(circleX, playY, 10);
            //if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && playY <= 300)
            //{
            //    playY += Time.DeltaTime * playSpeed;
            //}
            //if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && playY >= 100)
            //{
            //    playY -= Time.DeltaTime * playSpeed;
            //}
            //Missle
            Draw.FillColor = Color.Yellow;
            Draw.Circle(missleX, playY +20, 5);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                missleX += Time.DeltaTime * missleSpeed;
            }
            //or hitswall
            if (missleX > 500)
            {
                missleX = circleX;
            }
            //scaffold
            Draw.FillColor = Color.Black;
            Draw.Rectangle(scaffoldX, scaffoldY, 40, 200);
            scaffoldX -= Time.DeltaTime * scaffoldSpeed;
            if (scaffoldX < -5)
            {
                scaffoldX = 420;
            }
            else if (circleX >= scaffoldX && playY <= scaffoldY +200)
            {
                scaffoldX = 800;
                //lifeX1 = 800;
                lifeX1 += Time.DeltaTime * scaffoldSpeed;
                
            }
            //lives temp
            if (lifeX1 < 400)
            {
                life2();
            }
            void life2()
            {
                if (circleX >= scaffoldX && playY <= scaffoldY + 200)
                {
                    lifeX2 += Time.DeltaTime * scaffoldSpeed;

                }
            }
            //Make the speed over time
                //destrutable wall
                Draw.FillColor = Color.Blue;
            
            Draw.Rectangle(scaffoldDestructionX, 0, 40, 400);
            scaffoldDestructionX -= Time.DeltaTime * scaffoldDestructionSpeed;
            if (scaffoldDestructionX < -10)
            {
                scaffoldDestructionX = 500;
            }
            else if (missleX > scaffoldDestructionX)
            {
                scaffoldDestructionX = 700;
            }
        }
        //lives
        void lives()
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(300, lifeY, 10);
            Draw.Circle(330, lifeY, 10);
            Draw.Circle(360, lifeY, 10);
            Draw.FillColor = Color.Gray;
            Draw.Circle(300, lifeY, 9);
            Draw.Circle(330, lifeY, 9);
            Draw.Circle(360, lifeY, 9);
            Draw.FillColor = Color.Red;
            Draw.Circle(lifeX1, lifeY, 9);
            Draw.Circle(lifeX2, lifeY, 9);
            Draw.Circle(lifeX3, lifeY, 9);
            //    bool scaffoldhit()
            //    {
            //        float distance planeToScaffold = Vector2.Distance(position,)
            //    }
            //    if (scaffoldX = circleX)
            //    {
            //        life =  -= 1;
            //    }
            //    if (life <= 2)
            //    { 
            //        lifeX1 = -10;
            //    }
            //        if (life <= 1)
            //    {
            //        lifeX2 = -10;
            //    }
            //}
            //Gameover
            void gameover()
            {
                if (lifeX3 < 0)
                {
                    Draw.Rectangle(0, 0, 400, 400);
                }
            }
        }

    }
}
