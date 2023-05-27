using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float distance;
    [SerializeField] private Transform player;

    public Vector3 initPoint;

    void Start()
    {
        initPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);
    }

    public void Girar(Vector3 objetivo) {
        if(transform.position.x < objetivo.x) {
            
        }
    }
}
