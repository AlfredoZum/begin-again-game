using UnityEngine;

public class Wheel : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D _rigidbody;
    public float speed;

    private bool startMovement = false;
    private void Start()
    {
        startMovement = false;
        //Find Direction based on player.
        // _rigidbody = GetComponent<Rigidbody2D>();
        // _rigidbody.velocity = direction * speed;
    }

    private void Update() {
        transform.Rotate(new Vector3(0f, 0f, 75f) * Time.deltaTime);
        StartMovementWheel();
    }

    private void StartMovementWheel() {
        if(startMovement){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            //if hit player, damage.
        }
        if (other.tag.Equals("Fist"))
        {
            //if hit by player? destroy?
        }
        if (other.tag.Equals("floorWheel"))
        {
            startMovement = true;
        }
        if (other.tag.Equals("drop") || other.tag.Equals("attackCollider"))
        {
            startMovement = false;
            Destroy(gameObject);
        }
    }
}
