using UnityEngine;

public class Shooter : Placeable
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private float damage, attackRate;

    private float currentAttackTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate() {
        if(GameManager.instance.GameState == GameState.Game) {
            currentAttackTimer += Time.deltaTime;

            if(currentAttackTimer >= attackRate && HasEnemyInLane()) {
                Shoot();
                currentAttackTimer = 0f;
            }
        }
    }

    private bool HasEnemyInLane() {
        return true;
    }

    private void Shoot() {
        Vector2 position = transform.position;
        position.x += 1f;

        Vector2 velocity = transform.right * 10f;

        GameObject projectile = Instantiate(projectilePrefab, position, Quaternion.identity, transform);
        projectile.GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }
}
