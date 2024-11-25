using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackController : HazardController
{
   public override void OnHit(ActorController act)
    {
        act.Health += 1; // to heal by 1 health
        Debug.Log("Hi");
    }

}
