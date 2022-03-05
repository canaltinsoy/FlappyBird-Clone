using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public Birdy birdyScript;

    public GameObject blocks;

    public float height;


    public void Start()
    {
        StartCoroutine(spawnObject());
    }
    public IEnumerator spawnObject()
    {
        while (!birdyScript.isDead)
        {
            
            Instantiate(blocks,new Vector3(3, Random.Range(-height,+height),0), Quaternion.identity);
            yield return new WaitForSeconds(1f); 
            
        }

    }
}
