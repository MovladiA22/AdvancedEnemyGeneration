using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction = new Vector3();

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.Translate(_direction);
    }
}
