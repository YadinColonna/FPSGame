using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamageHandler : vp_DamageHandler
{
    public Animator myAnimator;

    public override void Damage(vp_DamageInfo damageInfo)
    {
        base.Damage(damageInfo);

        myAnimator.Play("BulletHit");
    }

    public override void Die()
    {
        //empieza animacion de esconder
        myAnimator.Play("Hidding");
        //Llama al metodo Revive luego de 5 segundos
        Invoke("Revive", 5f);
    }

    private void Revive()
    {
        //animacion de mostrar
        myAnimator.Play("Showing");
        //Cambia la vida del personaje a la original
        CurrentHealth = MaxHealth;
    }
}
