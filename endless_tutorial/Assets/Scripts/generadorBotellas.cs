using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorBotellas : MonoBehaviour {
    public objectPuller objPool;
    public float distanceBetweenCoins;
    public void SpawnCoins(Vector3 startPosition){
        GameObject coin1 = objPool.getPooledObject();
        coin1.transform.position = startPosition;
        coin1.SetActive(true);
        GameObject coin2 = objPool.getPooledObject();
        coin2.transform.position = new Vector3(startPosition.x - distanceBetweenCoins, startPosition.y, startPosition.z);
        coin2.SetActive(true);
        GameObject coin3 = objPool.getPooledObject();
        coin3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
        coin3.SetActive(true);
    }


}
