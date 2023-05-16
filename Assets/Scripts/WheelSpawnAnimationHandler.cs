using UnityEngine;

    public class WheelSpawnAnimationHandler : MonoBehaviour
    {
        public float spawnDelay;
        private float _spawnDelay;
        public Animator spawnerAnimator;

        private void Start()
        {
            _spawnDelay = spawnDelay;
        }

        private void Update()
        {
            _spawnDelay -= Time.deltaTime;
            if (_spawnDelay < 0)
            {
                //If in range? what criteria should we follow besides timing?
                spawnerAnimator.SetTrigger("Spawn");
                _spawnDelay = spawnDelay;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            //Punched.
            if (other.tag.Equals("Fist"))
            {
                spawnerAnimator.SetTrigger("Destroy");
            }
        }
    }
