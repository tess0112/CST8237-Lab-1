using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour {

    public float speed = 0.5f;
    public float minDistance = 5.5f;
    public float maxDistance = 20.0f;
    bool _isFarEnough = false;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Sets a flag when the object passes the min or max distance.
        if (transform.localPosition.x >= maxDistance)
            _isFarEnough = true;
        else if (transform.localPosition.x <= minDistance)
            _isFarEnough = false;

        // Checks the flag and moves appropriately.
        if (_isFarEnough)
            transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
        else if (!_isFarEnough)
            transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
    }
}
