using UnityEngine;

public class KnifeBehavior : ProjectileWeaponBehavior
{
    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        transform.position += direction * weaponData.Speed * Time.deltaTime;
    }
}
