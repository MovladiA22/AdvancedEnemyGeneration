using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;
    [SerializeField] private float _repeatRate;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0.0f, _repeatRate);
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }
}
