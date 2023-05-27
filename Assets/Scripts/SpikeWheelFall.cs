using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeWheelFall : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D thebody;

    void Start()
    {
        thebody = GetComponent<Rigidbody2D>();
        thebody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartFall(){
        thebody.gravityScale = 1.5f;
    }

    public void RestarSpike() {
        StartCoroutine(RestarSpike2());
    }

    private IEnumerator RestarSpike2()
    {
        thebody.gravityScale = 0;
        yield return new WaitForSeconds(0.3f);
        Vector3 spikerPosition = new Vector3(2.67f, 7.4f, 0);
        this.transform.position = spikerPosition;
    }
}
