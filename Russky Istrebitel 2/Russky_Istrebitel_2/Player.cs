﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Russky_Istrebitel_2
{
    public class Player
    {
        public Texture2D jetTexture, healthTexture, healthContainerTexture, shieldTexture;
        public Vector2 jetPosition;
        public Rectangle jetRectangle;
        public float speed;
        public int health;
        public int shieldHealth;
        public bool isColiding;
        public bool isAlive;
        //Constructor
        public Player()
        {
            health = 200;
            shieldHealth = 200;

        }
        //LoadContent
        public void LoadContent(ContentManager content)
        {

        }
        public void UnLoadContent(ContentManager content)
        {

        }
    }
}
