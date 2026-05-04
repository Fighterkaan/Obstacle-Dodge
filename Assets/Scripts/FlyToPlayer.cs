using UnityEngine;

public class FlyToPlayer : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 0.01f;
    [SerializeField] Transform player;

    Vector3 playerPosition; 
    void Start()
    {
        playerPosition = player.transform.position ;
        
    }

  
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
       
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {

          Destroy(gameObject);
        }
    }
}
