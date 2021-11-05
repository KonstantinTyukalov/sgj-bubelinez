using SFML.Audio;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Entities
{
    internal abstract class Entity
    {
        private const float DefaultSpeed = 1;
        public Vector2f Position
        {
            get => Sprite.Position;
            set { if (Sprite != null) Sprite.Position = value; }
        }
        public Vector2f Direction { get; set; }
        public Vector2f Rotation { get; set; }
        public string Name { get; set; }
        public Sprite Sprite { get; set; }
        public Sound[] Sounds { get; set; }
        public float Speed { get; set; }
        protected Entity(
            Vector2f position, Vector2f direction, Vector2f rotation,
            string name, Sprite sprite, Sound[] sounds, float? speed)
        {
            Position = position;
            Direction = direction;
            Rotation = rotation;
            Name = name;
            Sprite = sprite;
            Sounds = sounds;
            Speed = speed ?? DefaultSpeed;
        }
    }
}
