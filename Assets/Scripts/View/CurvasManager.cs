using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurvasManager : MonoBehaviour
{

	public GameObject panelCurvas;

	public void showPanel(){
		panelCurvas.SetActive (true);
	}

	public void hidePanel(){
		panelCurvas.SetActive (false);
	}
}
