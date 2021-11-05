using System.Collections.Generic;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;

namespace Bubelinez.Entities
{
    enum PlayerState { Move, Attack }

    class Player : Entity
    {
        public Dictionary<PlayerState, bool> State;

        public Player(
            Vector2f position, Vector2f direction, Vector2f rotation,
            string name, Sprite sprite, Sound[] sounds, float? speed)
            : base(
                position, direction, rotation,
                name, sprite, sounds, speed)
        {
            State = new Dictionary<PlayerState, bool>()
            {
                { PlayerState.Move, false },
                { PlayerState.Attack, false }
            };
        }
    }
}
