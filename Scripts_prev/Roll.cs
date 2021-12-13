using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {
//	public Animator anim;
//	// Use this for initialization
//	void Start () {
//		anim = GetComponent<Animator> ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown ("1"));
//		{
//			anim.Play ("roll");
//		}
//	}
//}
	public bool roll;


	void Start()
	{
		roll = false;
	}

	void Update()
	{
		if (Input.GetButton("1"))
		{
			roll = true;
		}
		else
		{
			roll = false;
		}
	}
}