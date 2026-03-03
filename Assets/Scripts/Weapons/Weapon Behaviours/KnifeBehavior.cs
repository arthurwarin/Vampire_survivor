using UnityEngine;

public class KnifeBehavior : ProjectileWeaponBehavior
{
    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        transform.position += direction * currentSpeed * Time.deltaTime;
    }
}
