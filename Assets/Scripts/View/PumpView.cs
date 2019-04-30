using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpView : MonoBehaviour
{
    public GameObject cover;
	public Text aperturaLabel,caudalLabel;
	public GameObject bIncreaseCaudal, bDecreaseCaudal;
	public Bubbles burbujas;

	private PumpPresenter presenter;

	void Start(){
		presenter = new PumpPresenter (this,new PumpModel());
	}


	public void activateCavitation(){
		burbujas.activate ();
		//Debug.Log ("pepepepepepe");
	}
	public void deactivateCavitation(){
		burbujas.deactivate ();
	}

	public void onToggleCover(){
		presenter.toggleCover ();
	}
	public void activateCover(){
		cover.SetActive (true);
	}
	public void deactivateCover(){
		cover.SetActive (false);
	}


	public void increaseCaudal(){
		presenter.increaseCaudal ();
	}
	public void decreaseCaudal(){
		presenter.decreaseCaudal ();
	}


	public void updateCaudalLabel(int newCaudal){
		aperturaLabel.text = newCaudal + "%";
		bIncreaseCaudal.SetActive (true);
		bDecreaseCaudal.SetActive (true);
		string caudal = "Caudal: ";
		if (newCaudal == 25) {
			caudal += 20;
		} else if (newCaudal == 50) {
			caudal += 40;
		} else {
			caudal += 60;
		}
		caudal += " m3/h";
		caudalLabel.text = caudal;
	}
	public void gotUpperLimit(){
		bIncreaseCaudal.SetActive (false);
	}
	public void gotLowerLimit(){
		bDecreaseCaudal.SetActive (false);
	}

}
