using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedestroyer : MonoBehaviour
{
    public float aliveTimer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, aliveTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
