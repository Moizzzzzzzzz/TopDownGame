using UnityEngine;



public class TopDownController : MonoBehaviour
{


    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;
    public Weapon weapon;
    public float walkspeed;
    public float framerate;

    Vector2 direction;
    Vector2 mousePosition;


    protected void LookAt(Vector3 target)
    {
        // calculate angle between transform and target
        float lookAngle = AngleBetweenTwoPoints(transform.position, target) + 90;

        // assign the target rotation on the z axis
        transform.eulerAngles = new Vector3(0, 0, lookAngle);
    }
    private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }


    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        // get direction of input
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        // set walk based on direction
        body.velocity = direction * walkspeed;

        // Shooting gun input
        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
    }

}
