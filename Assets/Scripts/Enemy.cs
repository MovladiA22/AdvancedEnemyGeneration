using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void Update()
    {
        FollowTarget();
    }

    public void Init(Transform target)
    {
        _target = target;
    }

    private void FollowTarget()
    {
        if (_target != null)
        {
            var direction = (_target.position - transform.position).normalized;
            transform.Translate(direction * _speed);
        }
    }
}
