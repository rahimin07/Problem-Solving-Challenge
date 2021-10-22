using UnityEngine;

    public class SegienamIsEnemy : MonoBehaviour
    {     
        public GameObject segienam;                
        public float xMin, xMax, yMin, yMax;        

        void Start ()
        {
            Spawn();
        }
        void Spawn ()
        {
            int spawnEnemy = Random.Range (4, 12);
            for (int i =0; i < spawnEnemy; i++)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);
                Instantiate(segienam, new Vector2(randomX, randomY), Quaternion.identity);
            }
            
        }
    }
