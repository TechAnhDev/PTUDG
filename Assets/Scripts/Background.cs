using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float yMax = 40f;
    public float yMin = -20f;
    public float moveSpeed = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed*Time.deltaTime, 0);
        if(transform.position.y <= yMin){
            transform.Translate(0, yMax, 0);
        }
    }
}
