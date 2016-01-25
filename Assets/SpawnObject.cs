using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {
    // Value given by editer.
    public GameObject prefabToSpawn = null;
    GameObject _spawnedObject = null;

	// Use this for initialization
	void Start () {
        _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
        _spawnedObject.name = "No Doge, No";
        // Setting ourselves to be the parent
        _spawnedObject.transform.parent = transform;
        _spawnedObject.transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
