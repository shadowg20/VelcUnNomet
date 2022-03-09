using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglaba ainava esoso kanvu
	public Canvas kanva;
	//GameObject kas uzglabas velkamnos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autoBus;

	//Uzglaba velkamo objektu sakotnejas atrasnasa vietas koordinates
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atrieKoord;
	[HideInInspector]
	public Vector2 busKoord;

	//Uzglabas audio avotu, kura atskanot attelu skanas efektus
	public AudioSource skanasAvots;
	//Masivs , kas uzglaba visas iespejama skanas
	public AudioClip[] skanaKoAtskanot;
	//Mainigais piefikse vai objekts nolikts istajavieta (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabas pedejo objektu kurs pakustinats
	public GameObject pedejaisVilktais = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
