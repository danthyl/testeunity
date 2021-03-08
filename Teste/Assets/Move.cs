using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 goal = new Vector3(5,0,4);
    //Vector3 goal = new Vector3(5, 0, 4);

    // Start is called before the first frame update
    void Start()
    {
        goal = goal * 0.01f;
        //this.transform.Translate(goal);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(goal);
    }
}
