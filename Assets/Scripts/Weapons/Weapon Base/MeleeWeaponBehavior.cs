using UnityEngine;

public class MeleeWeaponBehavior : MonoBehaviour
{
    public float destroyAfterSeconds;
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }
}
