using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpPresenter 
{
	private PumpView view;
	private PumpModel model;

	public PumpPresenter(PumpView view,PumpModel model){
		this.model = model;
		this.view = view;
	}

	public void toggleCover(){
		model.toggleCover (onActivateCover, onDeactivateCover);
	}
	public void onActivateCover(){
		view.activateCover ();
	}
	public void onDeactivateCover(){
		view.deactivateCover ();
	}

	public void increaseCaudal(){
		model.increaseCaudal (onUpdateLabel,onUpperLimit,onActivateCavitation);
	}
	public void decreaseCaudal(){
		model.decreaseCaudal (onUpdateLabel, onLowerLimit,onDeactivateCavitation);
	}
	public void onUpdateLabel(int newCaudal){
		view.updateCaudalLabel (newCaudal);
	}
	public void onUpperLimit(){
		view.gotUpperLimit ();
	}
	public void onLowerLimit(){
		view.gotLowerLimit();
	}

	public void onActivateCavitation(){
		view.activateCavitation ();
	}
	public void onDeactivateCavitation(){
		view.deactivateCavitation ();
	}

}
