using UnityEngine;

public class KnifeBehavior : ProjectileWeaponBehavior
{
    KnifeController kc;
    
    protected override void Start()
    {
        base.Start();
        kc = FindAnyObjectByType<KnifeController>();
    }

    void Update()
    {
        transform.position += direction * kc.speed * Time.deltaTime;
    }
}
