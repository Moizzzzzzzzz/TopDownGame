using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float bulletSpeed = 5.0f;
    public Vector3 mousePosition;

    float lifetime = 3.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Initialise()
    {
        // Get the mouse position in the world space
        mousePosition.z = 0f;

        // Calculate the direction from the current position to the mouse position
        Vector3 direction = (mousePosition - transform.position).normalized;

        // Move the bullet towards the mouse position
        GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        // Rotate the bullet so it is orneted to the mouse pointer
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        lifetime = 3.0f;
    }

    private void Update()
    {
        lifetime -= Time.deltaTime;

        if ( lifetime < 0.0f )
        {
            ObjectPooler.EnqueueObject(this, "Bullet");
        }
    }

}
