using Unity.Mathematics;
using UnityEngine;

public class WheelSpawner : MonoBehaviour
{
    public GameObject wheelPrefab;
    public Transform wheelSpawnPoint;

    //Called by the Animator - SpawnWheel.Spawn
    public void Spawn()
    {
        Instantiate(wheelPrefab, wheelSpawnPoint.position, quaternion.identity);
    }
}
