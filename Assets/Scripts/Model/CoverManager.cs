using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverManager 
{
	private bool covered;

	public CoverManager(){
		covered = false;
	}

	public void toggleCover(){
		covered = !covered;
	}

	public bool isCovered(){
		return covered;
	}
}
