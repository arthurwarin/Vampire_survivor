using UnityEngine;

public class GarlicController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        base.Attack();
        GameObject spawnedGarlic = Instantiate(prefab);
        spawnedGarlic.transform.position = transform.position;
        spawnedGarlic.transform.parent = transform;
    }
}
