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
        Life life;
        Wall walls;
        Missle missle;
        //working on a life cooldown 
        // need array of scaffolds
        //need end screen
        // need replay button


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Tunnel Flyer");
            player = new Player();
            destructableWalls = new DestructableWalls();
            life = new Life();
            walls = new Wall();
            missle = new Missle();
            destructableWalls.destructableWallsetup();
            walls.wallSetup();
            life.lifeSetup();
            missle.misslesetup();
            life.lifeLost(800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color: Color.DarkGray);
            life.lives();
            //gameover();
            Draw.FillColor = Color.Black;
            player.Render();
            player.PlayerFunction();
            missle.missleRender();
            destructableWalls.render();
            destructableWalls.destroyed();
            destructableWalls.lives();
            walls.render();
            walls.lives();
            life.livesRender();
            
        }
    }
}
