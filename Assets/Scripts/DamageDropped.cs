using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDropped : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Camera cam;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.tag == "drop"){
            // Vector3 campPosition = new Vector3(6.3f, 2, -10);
            // cam.transform.position = campPosition;

            Vector3 playerPosition = new Vector3(-6.3f, -2.97f, 0);
            this.transform.position = playerPosition;
        }
    }
}
