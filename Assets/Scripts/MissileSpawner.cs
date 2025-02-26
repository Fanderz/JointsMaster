using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    [SerializeField] private Missile prefab;

    public void Spawn()
    {
        Instantiate(prefab);
    }
}
