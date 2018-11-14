using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {
    public GameObject theObj;

    public Transform genPoint;
    public float distanceBetween;
    public float distanceBetweenMin;
    public float distanceBetweenMax;
    private float platformWhith;
    //public GameObject[] theObjs;
    private int platfomrSelector;

    private float[] platformsWhith;

    public objectPuller[] theObjectPools;
    public generadorBotellas thebgen;
    private float minHight;
    public Transform maxHeightPoint;
    private float maxHight;
    public float maxHightChange;
    private float hightChange;
    // Use this for initialization
    void Start () {
        //platformWhith = theObj[0].GetComponent<BoxCollider2D>().size.x;
        platformsWhith = new float[theObjectPools.Length];
        for (int i = 0; i < theObjectPools.Length; i++){
            platformsWhith[i]= theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }
        minHight = transform.position.y;
        maxHight = maxHeightPoint.position.y;
        thebgen = FindObjectOfType<generadorBotellas>();
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < genPoint.position.x){
            distanceBetween = Random.Range(distanceBetweenMin,distanceBetweenMax);
            platfomrSelector = Random.Range(0, theObjectPools.Length);
            hightChange = transform.position.y + Random.Range(maxHightChange, -maxHightChange);

            if (hightChange > maxHight ){
                hightChange = maxHight;


            }else if (hightChange<minHight){
                hightChange = minHight;
            }
            transform.position = new Vector3(transform.position.x + (platformsWhith[platfomrSelector])/2 + distanceBetween, hightChange, transform.position.z);

           
           // Instantiate(theObjectPools[platfomrSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platfomrSelector].getPooledObject();
            newPlatform.transform.position = transform.position;
           newPlatform.transform.rotation = transform.rotation;
           newPlatform.SetActive(true);
            thebgen.SpawnCoins(new Vector3(transform.position.x, transform.position.y +1f, transform.position.z));
            transform.position = new Vector3(transform.position.x + (platformsWhith[platfomrSelector]) / 2 , transform.position.y, transform.position.z);


        }
    }
}
