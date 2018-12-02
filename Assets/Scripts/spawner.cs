using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
// using CenterSpace.NMath.Core;

public class spawner : MonoBehaviour {
  private float lastSpawnTimeDelta;
  private List<GameObject> GameObjectList = new List<GameObject>();
  public Transform[] spawnLocations;
  public GameObject[] whatToSpawnPrefab;
  public GameObject[] whatToSpawnClone;
  System.Random rnd;
  // Use this for initialization
	void Start () {
    rnd = new System.Random();
    // spawnSomethingAwesomePlease();
    lastSpawnTimeDelta = Time.fixedUnscaledTime;
    // freezeRotation = true;
	}
  // void spawnSomethingAwesomePlease(){
  //   for ( int i = 0; i < 5; i++ ){
  //     whatToSpawnClone[i] = Instantiate(whatToSpawnPrefab[i], spawnLocations[i].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
  //     whatToSpawnClone[i].GetComponent<Rigidbody>().velocity = new Vector3(0f,
  //                                                                          0f,
  //                                                                          -1f);
  //   }
  //   // whatToSpawnClone[0].transform.position = new Vector3(0,0,0);
  //   // whatToSpawnClone[0].GetComponent<Rigidbody>().velocity =  new Vector3(1,0,0);
  // }

  void randomSpawn(){
    int i = rnd.Next(0, 5);
    GameObject go = Instantiate(whatToSpawnPrefab[i], spawnLocations[i].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
    whatToSpawnClone[i] = go;
    GameObjectList.Add(go);
    whatToSpawnClone[i].GetComponent<Rigidbody>().velocity = new Vector3(0f,
                                                                         0f,
                                                                         -3f);
  }
	
	// Update is called once per frame
	void Update () {
    if (lastSpawnTimeDelta + 1 < Time.fixedUnscaledTime){
      randomSpawn();
      lastSpawnTimeDelta = Time.fixedUnscaledTime;
      // print("lastSpawnTimeDelta = " + lastSpawnTimeDelta);
      print("whatToSpawnClone.Length = " + whatToSpawnClone.Length);
      // foreach ( GameObject go in GameObjectList ) {
      //   if ( GameObjectList[go].transform.position.y < -10f ) {
      //     print("delete object");
      //     GameObject delGo = GameObjectList[go];
      //     GameObjectList.Remove(GameObjectList[go]);
      //   }
      // }
    }
	}
}
