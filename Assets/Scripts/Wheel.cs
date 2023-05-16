using UnityEngine;

public class Wheel : MonoBehaviour
{
    public Vector2 direction;
    private Rigidbody2D _rigidbody;
    public float speed;
    private void Start()
    {
        //Find Direction based on player.
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = direction * speed;
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
    }
}
