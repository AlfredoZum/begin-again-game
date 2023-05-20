using Unity.Mathematics;
using UnityEngine;

public class WheelSpawner : MonoBehaviour
{
    public GameObject wheelPrefab;
    public Transform wheelSpawnPoint;
    public AudioClip[] spawnClips;

    //Called by the Animator - SpawnWheel.Spawn
    public void Spawn()
    {
        SoundManager.Instance.PlaySfx(spawnClips);
        Instantiate(wheelPrefab, wheelSpawnPoint.position, quaternion.identity);
    }
}
