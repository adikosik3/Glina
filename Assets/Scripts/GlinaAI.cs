using UnityEngine;

public class GlinaAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public int damage = 10; 
    public float attackCooldown = 1.0f; 
    private float nextAttackTime = 0f; 

    void Update()
    {

        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            if (Time.time >= nextAttackTime)
            {

                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

                if (playerHealth != null)
                {

                    playerHealth.TakeDamage(damage);

                    nextAttackTime = Time.time + attackCooldown;
                }
            }
        }
    }
}
