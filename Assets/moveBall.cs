﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform mazeObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,3);
		}
		
		if (Input.GetKey("s"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,-3);
		}
		if (Input.GetKey("a"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-3,0);
		}
		if (Input.GetKey("d"))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (3,0);
		}
    }
}
