using UnityEngine;

public class CatapultaSpoon : MonoBehaviour
{
    [SerializeField] private MissileSpawner _spawner;
    [SerializeField] private float _spawnDelay;

    private float _maxSpringForce = 750f;
    private float _minSpringForce = 0f;
    private Quaternion _defaultRotation;
    
    private SpringJoint _spring;

    private void Awake()
    {
        _spring = GetComponent<SpringJoint>();
        _defaultRotation = transform.rotation;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            _spring.spring = _maxSpringForce;

        if(Input.GetKeyDown(KeyCode.R))
        {
            _spring.spring = _minSpringForce;
            transform.rotation = _defaultRotation;
            Invoke("SpawnMissile", _spawnDelay);
        }
    }

    private void SpawnMissile()
    {
        _spawner.Spawn();
    }
}
