using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public Vector3 goal = new Vector3(0,0,0);
    
    // Start is called before the first frame update
    void Start()
    {
        goal = goal * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(goal);
    }
}

