﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    public class Ball
    {
        private Texture2D _texture;
        private Vector2 _position;
        private Vector2 _velocity;
        private float _speed;
        private float _startspeed = 100f;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        /// <param name="velocity">Has to be normalized(components betweeg 0-1)</param>
        public Ball(Texture2D texture, Vector2 position, float startspeed)
        {
            this._texture = texture;
            this._position = position;
            this._startspeed = startspeed;

        }

        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)Position.X,
                    (int)Position.Y,
                    _texture.Width,
                    _texture.Height);
            }
        }

        public Texture2D Texture
        {
            get
            {
                return _texture;
            }

            set
            {
                _texture = value;
            }
        }

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public float Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        public float Startspeed
        {
            get { return _startspeed; }
            set { _startspeed = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }

        public void setToStartPosition(Player scorer)
        {
            this.Speed = this._startspeed;
            //this.Position = new Vector2(Game1.WIDTH/2-BoundingBox.Width/2,Game1.HEIGHT/2-BoundingBox.Height/2);
            if (scorer.Id == 1)
            {
                this.Velocity = new Vector2(-1 * Speed, 0);
            }
            else
            {
                this.Velocity = new Vector2(Speed, 0);
            }
        }
    }
}
