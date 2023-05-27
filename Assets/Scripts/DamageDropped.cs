using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageDropped : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isAtack = false;

    private int health = 3;

    [SerializeField] private Camera cam;

    Canvas canvasPlayer;
    SpikeWheelFall spikeWheelFall;

    void Start()
    {
        canvasPlayer = GameObject.FindWithTag("uiCanvasPlayer").GetComponent<Canvas>();
        var go = GameObject.FindWithTag("SpikeWheelFall");
        if(go != null)
            spikeWheelFall = GameObject.FindWithTag("SpikeWheelFall").GetComponent<SpikeWheelFall>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("f"))
        {
            StartCoroutine(HitEnemies());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "drop")
        {
            Vector3 playerPosition = new Vector3(-6.3f, -2.97f, 0);
            this.transform.position = playerPosition;
            deleteLife();
        }

        if (other.gameObject.tag == "wheel")
        {
            if (isAtack)
            {
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
                deleteLife();
            }
        }
            Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "NextLevel"){
            SceneManager.LoadScene(1);
        }

        if(other.gameObject.tag == "FallSpikeAction"){

            spikeWheelFall.StartFall();
        }

        if(other.gameObject.tag == "SpikeWheelFall"){
            spikeWheelFall.RestarSpike();
            deleteLife();
            Vector3 playerPosition = new Vector3(-8.1f, 3f, 0);
            this.transform.position = playerPosition;
        } 

    }

    private void deleteLife()
    {
        health--;
        if (health == 0)
        {
            health = 3;
            Vector3 playerPosition = new Vector3(-6.3f, -2.97f, 0);
            this.transform.position = playerPosition;
        }
        canvasPlayer.TakeLife(health);
    }

    private IEnumerator HitEnemies()
    {
        isAtack = true;
        yield return new WaitForSeconds(0.4f);
        isAtack = false;

    }
}
