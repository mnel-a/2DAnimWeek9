using UnityEngine;

public class TestDummy : MonoBehaviour
{
    public int health = 100;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MeleeAttack"))
        {
            Debug.Log("Ouch!");
            health -= 5;
        }
    }
}
