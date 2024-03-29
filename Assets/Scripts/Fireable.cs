﻿using UnityEngine;

namespace Asteroids
{
    public class Fireable : MonoBehaviour
    {
        [SerializeField] private MoverBase _mover;
        public void SetMovementDirection(Vector2 direction)
        {
            _mover.AddForce(direction);
        }
    }
}