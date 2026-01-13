using UnityEngine;

public class ProjectileWeaponBehavior : MonoBehaviour
{
    protected Vector3 direction;
    public float destoryAfterSeconds;
    
    protected virtual void Start()
    {
        Destroy(gameObject, destoryAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        float dirx;
        float diry;
        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;
        
        direction = dir;
        dirx = direction.x;
        diry = direction.y;

        if (dirx < 0 && diry == 0) //left
        {
            scale.x *= -1;
            scale.y *= -1;
        }
        else if (dirx == 0 && diry < 0) //down
        {
            scale.y *= -1;
        }
        else if (dirx == 0 && diry > 0) // up
        {
            scale.x *= -1;
        }
        else if (dir.x > 0 && dir.y > 0) //right up
        {
            rotation.z = 0f;
        }
        else if (dir.x > 0 && dir.y < 0) //right down
        {
            rotation.z = -90f;
        }
        else if (dir.x < 0 && dir.y > 0)
        {
            scale.x *= -1;
            scale.y *= -1;
            rotation.z = -90f;
        }
        else if (dir.x < 0 && dir.y < 0)
        {
            scale.x *= -1;
            scale.y *= -1;
            rotation.z = 0f;
        }
        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
