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
        Player player;
        DestructableWalls destructableWalls;
        //missle
        float missleSpeed = 250;
        public static float missleX = 100;
        //Random scaffold walls
        float scaffoldSpeed = 100;
        float scaffoldX = 420;
        float scaffoldY = 0;
        
        float lifeY = 20;
        float lifeX1 = 300;
        float lifeX2 = 330;
        float lifeX3 = 360;
        float checkLifeX = 400;
        float emptyLifeX = 200;
       public bool islife1Gone = false;
       public bool islife2Gone = false;
       public bool islife3Gone = false;
       public bool islife1Cooldown = false;
       public bool islife2Cooldown = false;
       public bool islife3Cooldown = false;
        //working on a life cooldown 


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Tunnel Flyer");
            player = new Player();
            destructableWalls = new DestructableWalls();
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
            player.Render();
            player.PlayerFunction();
            destructableWalls.render();
            destructableWalls.destroyed();
            //player
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
            Draw.Circle(missleX, player.playY +20, 5);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                missleX += Time.DeltaTime * missleSpeed;
            }
            //or hitswall
            if (missleX > 500)
            {
                missleX = player.circleX;
            }
            //scaffold
            Draw.FillColor = Color.Black;
            Draw.Rectangle(scaffoldX, scaffoldY, 40, 200);
            scaffoldX -= Time.DeltaTime * scaffoldSpeed;
            if (scaffoldX < -5)
            {
                scaffoldX = 420;
            }
            else if (player.circleX >= scaffoldX && player.playY <= scaffoldY +200)
            {
                scaffoldX = 800;
                //lifeX1 = emptyLifeX;
                islife1Gone = true;


            }
            //lives temp
            if (lifeX1 < checkLifeX)
            {
                life2();
            }
            void life2()
            {
                if (player.circleX >= scaffoldX && player.playY <= scaffoldY + 200)
                {
                    islife2Gone = true;

                }
            }
            //health gone
            if (islife1Gone == true)
            {
                lifeX1 += Time.DeltaTime * scaffoldSpeed;
            }
            if (islife2Gone == true)
            {
                lifeX2 += Time.DeltaTime * scaffoldSpeed;
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
