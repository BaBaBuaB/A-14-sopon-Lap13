using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreghtPowerUp : PowerUp
{
    float stregthMultiplier = 2f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(stregthMultiplier);
    }
}
