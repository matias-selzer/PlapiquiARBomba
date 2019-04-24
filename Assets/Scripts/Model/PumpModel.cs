using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void CallBackFunction();
public delegate void CallBackFunctionWithParameter(int p);

public class PumpModel
{
	private CoverManager coverManager;
	private CaudalManager caudalManager;

	public PumpModel(){
		coverManager = new CoverManager ();
		caudalManager = new CaudalManager ();
	}

	public void toggleCover(CallBackFunction onActivateCover,CallBackFunction onDeactivateCover){
		coverManager.toggleCover ();
		if (coverManager.isCovered ()) {
			onActivateCover ();
		} else {
			onDeactivateCover ();
		}
	}

	public void increaseCaudal(CallBackFunctionWithParameter onUpdateLabel,CallBackFunction onUpperLimit,CallBackFunction onActivateCaviation){
		caudalManager.increase ();
		onUpdateLabel (caudalManager.getCaudal ());
		if (caudalManager.gotUpperLimit ()) {
			onUpperLimit ();
		}
		if (caudalManager.isCavitating ()) {
			Debug.Log ("Hooolaasdasdasdasdasdasda2");
			onActivateCaviation ();
		}
	}

	public void decreaseCaudal(CallBackFunctionWithParameter onUpdateLabe,CallBackFunction onLowerLimit,CallBackFunction onDeactivateCaviation){
		caudalManager.decrease ();
		onUpdateLabe (caudalManager.getCaudal ());
		if (caudalManager.gotLowerLimit ()) {
			onLowerLimit ();
		}
		if (!caudalManager.isCavitating ()) {
			onDeactivateCaviation ();
		}
	}

}
