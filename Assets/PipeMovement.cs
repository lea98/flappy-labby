using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
	public float movementSpeed = 5;
	public int deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	gameObject.transform.position =  gameObject.transform.position - (Vector3.right * movementSpeed) * Time.deltaTime;
	if (gameObject.transform.position.x < deadZone) {Destroy(gameObject);}
        
    }
}
