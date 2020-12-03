using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDamageHandler : vp_DamageHandler
{
    //public Animator myAnimator;

    public override void Damage(float damage)
    {
        base.Damage(damage);

        //myAnimator.Play("BulletHit");
    }
}
