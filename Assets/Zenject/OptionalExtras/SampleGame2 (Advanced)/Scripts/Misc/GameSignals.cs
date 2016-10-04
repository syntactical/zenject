using System;
using UnityEngine;
using Zenject;

namespace Zenject.SpaceFighter
{
    // Triggered when the player explodes
    public class PlayerKilledSignal : Signal
    {
        public class Trigger : TriggerBase
        {
        }
    }

    // Triggered when the enemy explodes
    public class EnemyKilledSignal : Signal
    {
        public class Trigger : TriggerBase
        {
        }
    }
}
