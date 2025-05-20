using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //This is where we check to see if the bullet is hitting/damaging an enemy as well :P
    }
}
