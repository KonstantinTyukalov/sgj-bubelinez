using SFML.Audio;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Entities
{
    internal interface IBaseEntity
    {
        public Vector2f Position { get; set; }
        public Vector2f Direction { get; set; }
        public Vector2f Rotation { get; set; }
        public Sprite Sprite { get; set; }
        public Sound[] Sounds { get; set; }
        public float Speed { get; set; }
    }

    internal abstract class BaseEntity : IBaseEntity
    {
        private const float DefaultSpeed = 1;
        public float Speed { get; set; }
        public Vector2f Position
        {
            get => Sprite.Position;
            set { if (Sprite != null) Sprite.Position = value; }
        }
        public Vector2f Direction { get; set; }
        public Vector2f Rotation { get; set; }
        public Sprite Sprite { get; set; }
        public Sound[] Sounds { get; set; }
        protected BaseEntity(
            Vector2f position, Vector2f direction, Vector2f rotation,
            Sprite sprite, Sound[] sounds, float? speed)
        {
            Position = position;
            Direction = direction;
            Rotation = rotation;
            Sprite = sprite;
            Sounds = sounds;
            Speed = speed ?? DefaultSpeed;
        }
    }
}
