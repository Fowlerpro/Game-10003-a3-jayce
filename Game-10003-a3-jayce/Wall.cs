// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Wall
    {
        //Random scaffold walls
        public int wallcount = 200;
        public int[] wallposition1;
        public int[] wallposition2;
        public float[] scaffoldX1;
        public float[] scaffoldX2;
        Texture2D wallTexture1 = Graphics.LoadTexture("../../../assets/textures/wall.png");
        Texture2D wallTexture2 = Graphics.LoadTexture("../../../assets/textures/wall.png");
        public void wallSetup()
        {
            wallposition1 = new int[wallcount];
            wallposition2 = new int[wallcount];
            scaffoldX1 = new float[wallcount];
            scaffoldX2 = new float[wallcount];
            //creating the locations for the walls
            for (int i = 0; i < wallcount; i++) {
                wallposition1[i] = Random.Integer(-350,-150);
                wallposition2[i] = Random.Integer(300,400);
                //start position and speed
                scaffoldX1[i] = 420 + (i * 350);
                scaffoldX2[i] = 660 + (i * 350);
            }
        }
        public void render()
        {
            Draw.FillColor = Color.Black;
            for (int i = 0; i < wallcount; i++)
            {
                scaffoldX1[i] -= Time.DeltaTime * 100;
                scaffoldX2[i] -= Time.DeltaTime * 100;
                    Graphics.Draw(wallTexture1, scaffoldX1[i], wallposition1[i]);
                Graphics.Draw(wallTexture2, scaffoldX2[i], wallposition2[i]);
            }
           }
        }
}
