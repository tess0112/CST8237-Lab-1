using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour
{
    // Value given by editer.
    public GameObject prefabToSpawn = null;
    GameObject _spawnedObject = null;
    Vector3 _startPoint = new Vector3(0, 0, 0);
    float _distanceFromStart = 0;
    public float distanceForSpawn = 5;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(_startPoint, transform.position) > distanceForSpawn)
        {
            _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
            _spawnedObject.name = "Spawned Child";
            // Setting ourselves to be the parent
            _spawnedObject.transform.parent = transform;
            _startPoint = transform.position;
        }
	}
}
