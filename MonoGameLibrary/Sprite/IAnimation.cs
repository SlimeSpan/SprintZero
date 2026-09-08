using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Sprite
{
    public interface IAnimation
    {
        //public bool IsPaused
        //{
        //    get;
        //    set;
        //}
        bool HasPlayedOnce
        {
            get;
        }
        string[] GetStates();
        void Play(string stateName);
        void Update(GameTime gameTime);
        public void Draw(Vector2 targetPos, Color color);
        void AddAnimation(string stateName,TextureClip textureGroup);
        void RemoveAnimation(string stateName);

        bool ContainAnimation(string stateName);

       

    }
}
