using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    public Collider2D meleeHitbox;
    public GameObject projectilePrefab;
    public Transform spawnProjectile;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        meleeHitbox.enabled =false;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("MeleeAttack");
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("RangeAttack");
        }
    }

    public void SpawnProjectile()
    {
        GameObject bullet = Instantiate(projectilePrefab, spawnProjectile.position, spawnProjectile.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = spawnProjectile.right * 10;
    }

    public void meleeHitbox_Enabled()
    {
        meleeHitbox.enabled = true;
    }

     public void meleeHitbox_Disabled()
    {
        meleeHitbox.enabled = false;
    }
}
