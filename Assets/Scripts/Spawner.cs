using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GameObject[] _spawnPoints;
    [SerializeField] private float _repeatRate;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0.0f, _repeatRate);
    }

    private void Spawn()
    {
        int minValue = 0;
        int maxValue = _spawnPoints.Length;
        float divider = 100f;

        Enemy enemy = Instantiate(_enemy, _spawnPoints[Random.Range(minValue, maxValue)].transform.position, Quaternion.identity);
        enemy.Init(new Vector3(Random.value / divider, 0f, Random.value / divider));
    }
}
