using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Sprite;

namespace MonoGameLibrary.Sprite
{
    public class Animation :IAnimation
    {

        ISpriteRenderer spriteRenderer;

        private readonly Dictionary<string, TextureClip> animations;

        TextureClip currentTextureClip;
        
        private int frameIndex;        
        private float totalElapsed;
        private float frameTime;


       
        private string currentState;

        //public bool IsPaused
        //{ 
        //    get; 
        //    set; 
        //}

        public bool HasPlayedOnce
        {
            get;
            private set;    
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spriteGroups"></param>
        /// <param name="spriteRenderer">"Brush" to draw sprites</param>
        public Animation(Dictionary<string,TextureClip> spriteGroups,ISpriteRenderer spriteRenderer,float frameTime)
        {
            this.spriteRenderer = spriteRenderer;
            this.animations = new Dictionary<string,TextureClip>(spriteGroups);
            this.frameTime = frameTime;
        }

        public void Update(GameTime gameTime)
        {
            //if (IsPaused)
            //{
            //    return;
            //}

            totalElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (totalElapsed >= frameTime)
            {
                frameIndex++;
                totalElapsed -= frameTime;

                HasPlayedOnce = frameIndex >= currentTextureClip.Length;
                
            }
        }
        
        public void Draw(Vector2 targetPos, Color color)
        {
            frameIndex %= currentTextureClip.Length;
            
            TextureData region = currentTextureClip[frameIndex];
            Texture2D texture = region.Texture;
            Rectangle sourceRectangle = region.Rectangle;
            SpriteEffects effect = region.Effect;
            float Scale = region.Scale;
            
            //only allow use the center of sprite as origin for now.
            Vector2 origin = new Vector2(sourceRectangle.Width / 2, sourceRectangle.Height / 2);
            
            spriteRenderer.Draw(texture:texture,targetPos:targetPos,sourceRectangle:sourceRectangle,color: color,origin:origin,spriteEffect:effect, scale: Scale);
        }
     
        public string[] GetStates()
        {

            return animations.Keys.ToArray();
        }

        public bool ContainAnimation(string stateName)
        {
            return animations.ContainsKey(stateName);
        }
        public void Play(string nextAction)
        {
            
            if(!animations.TryGetValue(nextAction, out currentTextureClip))
            {
                throw new KeyNotFoundException($"Can not found action named :{nextAction}");
            }

            if(nextAction==currentState) 
            {
                return;
            }

            //start play new animation, reset frame
            frameIndex = 0;
            totalElapsed = 0f;
            currentState = nextAction;
            HasPlayedOnce = false;
        }

      

        public void AddAnimation(string stateName, TextureClip textureGroup)
        {
            animations.Add(stateName, textureGroup);
        }

        public void RemoveAnimation(string stateName)
        {
            animations.Remove(stateName);
        }
    }
}
