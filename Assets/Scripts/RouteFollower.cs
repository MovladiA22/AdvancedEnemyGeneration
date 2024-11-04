using UnityEngine;

public class RouteFollower : MonoBehaviour
{
    [SerializeField] private Transform _secondRoutePoint;
    [SerializeField] private float _speed;

    private Vector3 _firstRoutePointPosition;
    private Vector3 _target;

    private void Awake()
    {
        _firstRoutePointPosition = transform.position;
        _target = _secondRoutePoint.position;
    }

    private void Update()
    {
        if (transform.position == _firstRoutePointPosition)
            _target = _secondRoutePoint.position;
        else if (Vector3.Distance(transform.position, _secondRoutePoint.position) < 0.1f)
            _target = _firstRoutePointPosition;

        transform.Translate((_target - transform.position).normalized * _speed);
    }
}
