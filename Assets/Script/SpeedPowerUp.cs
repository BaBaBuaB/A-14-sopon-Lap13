using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    public float speedMultiplier = 1.5f;
    public float duration = 5.0f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(speedMultiplier, duration);
    }
}
