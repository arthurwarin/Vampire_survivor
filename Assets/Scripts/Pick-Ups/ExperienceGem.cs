using UnityEngine;
using UnityEngine.EventSystems;

public class ExperienceGem : MonoBehaviour, ICollectible
{
    public int experienceGranted;
    
    public void Collect()
    {
        PlayerStats player = FindAnyObjectByType<PlayerStats>();
        player.IncreaseExperience(experienceGranted);
        Destroy(gameObject);
    }
}
