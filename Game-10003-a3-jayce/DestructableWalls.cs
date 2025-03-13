// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class DestructableWalls
    {
        Texture2D wallChain = Graphics.LoadTexture("../../../assets/textures/chainwall.png");
       public float scaffoldDestructionX = 600;
        float scaffoldDestructionSpeed = 100;

        
        public void destructableWallsetup()
        {
        }
        public void render()
        {
            Draw.FillColor = Color.Blue;

            Graphics.Draw(wallChain,scaffoldDestructionX, 0);
            scaffoldDestructionX -= Time.DeltaTime * scaffoldDestructionSpeed;
        }

        public void destroyed()
        {

            if (scaffoldDestructionX < -10)
            {
                scaffoldDestructionX = 500;
            }
        }
    }
}
