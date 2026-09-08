using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Sprite;
using SprintZero.Content.SpriteData;

namespace SprintZero.LoadCharacter
{
    internal static class Link
    {
         internal static IAnimation LoadAnimation(Texture2D characterTexture,ISpriteRenderer spriteBatch,float characterScale,float frameTime)
         {
            Dictionary<string, TextureClip> animationClips = new Dictionary<string, TextureClip>
            {
                { "IdleDown",new TextureClip(new TextureData(characterTexture,LinkSpriteData.MoveDown[0],scale:characterScale)) },
                { "IdleUp",new TextureClip(new TextureData(characterTexture,LinkSpriteData.MoveUp[0],scale:characterScale)) },
                { "IdleRight",new TextureClip(new TextureData(characterTexture,LinkSpriteData.MoveRight[0],scale:characterScale)) },
                { "IdleLeft",new TextureClip(new TextureData(characterTexture,LinkSpriteData.MoveRight[0], SpriteEffects.FlipHorizontally,scale:characterScale)) },
                
                { "MoveDown",TextureClip.CreateClip(characterTexture,LinkSpriteData.MoveDown,scale:characterScale) },
                { "MoveRight",TextureClip.CreateClip(characterTexture,LinkSpriteData.MoveRight,scale:characterScale) },
                { "MoveUp",TextureClip.CreateClip(characterTexture,LinkSpriteData.MoveUp,scale:characterScale) },
                { "MoveLeft",TextureClip.CreateClip(characterTexture,LinkSpriteData.MoveRight, SpriteEffects.FlipHorizontally,scale:characterScale) },
                
                { "AttackDown",TextureClip.CreateClip(characterTexture,LinkSpriteData.AttackDown,scale:characterScale) },
                { "AttackRight",TextureClip.CreateClip(characterTexture,LinkSpriteData.AttackRight,scale:characterScale) },
                { "AttackUp",TextureClip.CreateClip(characterTexture,LinkSpriteData.AttackUp,scale:characterScale) },
                { "AttackLeft",TextureClip.CreateClip(characterTexture,LinkSpriteData.AttackRight, SpriteEffects.FlipHorizontally,scale:characterScale) }
            };

            return new Animation(animationClips, spriteBatch, frameTime);
         }

    }
}
