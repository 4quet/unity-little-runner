using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSol : MonoBehaviour {

    public float vitesse = 0.5f;

    private float position_x;
    private float position_depart;

	void Start () {
        position_depart = transform.position.x;
        position_x = position_depart;
	}
	
	void Update () {

        transform.position = new Vector3(position_x, transform.position.y, transform.position.z);

        position_x -= vitesse;

        if (position_x <= position_depart - 16.0f)
        {
            position_x = position_depart;
        }


    }
}
