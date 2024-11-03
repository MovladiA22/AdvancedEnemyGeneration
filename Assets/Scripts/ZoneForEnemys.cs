using UnityEngine;

public class ZoneForEnemys : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
            Destroy(enemy.gameObject);
    }
}
