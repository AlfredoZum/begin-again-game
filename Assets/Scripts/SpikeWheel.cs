using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeWheel : MonoBehaviour
{
   
    public float speed;

    public bool isRight;

    public float countTime;

    public float timeForChange = 4f;

    void Start()
    {
        countTime = timeForChange;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRight == true){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if(isRight == false){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        transform.Rotate(new Vector3(0f, 0f, 75f) * Time.deltaTime);
        // transform.eulerAngles = Vector3.forward * degrees;

        // transform.eulerAngles = new Vector3 (0, 0, 50);

        // countTime -= Time.deltaTime;
        // if(countTime <= 0){
        //     isRight = !isRight;
        //     countTime = timeForChange;
            
        // }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.tag == "wallLeft"){
            isRight = true;
        }
        if(other.gameObject.tag == "wallRight"){
            isRight = false;
        }
    }

}
