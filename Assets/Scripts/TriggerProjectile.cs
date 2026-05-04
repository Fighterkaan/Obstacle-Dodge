using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;

    private void OnTriggerEnter (Collider other)

    {
        if ( other.gameObject.tag == "Player" )
        {
            projectile.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
        }
    }
}
