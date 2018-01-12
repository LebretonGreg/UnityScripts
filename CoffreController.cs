using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreController : MonoBehaviour {

	private bool isOpened;
	private GameObject ceCoffre; 
	public Animator anim; 

	// Use this for initialization
	void Start () {
		isOpened = false;
		ceCoffre = GameObject.FindGameObjectWithTag("Coffre");
		anim = ceCoffre.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if(col.gameObject.tag == "Player") {
			isOpened = true;
			anim.Play ("CoffreOuvert");
		}
	}
}
