using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class RandomEnemyProb9 : MonoBehaviour
    {     
        public GameObject segienam;                
        public float xMin, xMax, yMin, yMax;        

        void Start ()
        {
            Spawn();
            StartCoroutine(SpawnSegienam());
        }
        void Spawn ()
        {
            int spawnEnemy = Random.Range (7, 14);
            for (int i =0; i < spawnEnemy; i++)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);
                Instantiate(segienam, new Vector2(randomX, randomY), Quaternion.identity);
            }           
        }
        IEnumerator SpawnSegienam()
        {
            if (transform.childCount < 12)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);
                Instantiate(segienam, new Vector2(randomX, randomY), Quaternion.identity);
            }
            yield return new WaitForSeconds(1);
            StartCoroutine(SpawnSegienam());
        }
    }
