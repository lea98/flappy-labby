using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
	public GameObject pipe;
	public int spawnRate = 2;
	private float timer = 0;
	public float maxHeight = 3;
	public float minHeight = -3;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe, gameObject.transform.position, gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

	if (timer<spawnRate) {timer += Time.deltaTime;}
	else {Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minHeight,maxHeight),0), gameObject.transform.rotation); timer=0;}
	
        
    }
}
