using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaimporte, vai lietotu visus I interfesus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IDragHandler,IEndDragHandler {
	//Velkamajam aobjektam piestiprina konponentu
	private CanvasGroup kanvasGrupa;
	//Prieks parvietojama objekta atrasanas vietas uzglabasanos
	private RectTransform velkObjRectTransf;
	//Norda uz objektu skriptu
	public Objekti objektuSkripts;
	// Use this for initialization
	void Start () {
		//Pieklust ibjekta piestripinajusi CanvasGroup komponente
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Pisklust objekta recttransform komenentu
		velkObjRectTransf = GetComponent<RectTransform>();

	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikskinats uz velkama objekta");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta vilksana");
		//Vwelkot objektu tas palike caurspidigs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektu velkot iet carui rajcasts start
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek vilksana");
		//Maina objekta x,y koodrinates
		velkObjRectTransf.anchoredPosition+=notikums.delta / objektuSkripts.kanva.scaleFactor;
		//Lai objektu velkot iet carui rajcasts start
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta objekta vilksana");
		kanvasGrupa.alpha = 1f;

		//Ja objekts nebija nolikts istaja vieta
		if(objektuSkripts.vaiIstajaVieta == false){
			//Tad to atkal var vilk
			kanvasGrupa.blocksRaycasts = true;
			//Ja nolikts istaja vieta
		} else {
			//Aizmirst pedejo objektu, kas vilkts
			objektuSkripts.pedejaisVilktais = null;
	}
		//Ja viens objekts nolikts istaja vieta, tad lai varetu turpinat vilkt parejos
		//iestata uz false
		objektuSkripts.vaiIstajaVieta=false;
	}
}