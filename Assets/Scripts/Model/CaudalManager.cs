using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CaudalManager
{
    private int caudal=40;
	private const int min = 20;
	private const int max = 90;

    public void increase() {
        if (caudal < max) {
            caudal+=10;
        }
    }

    public void decrease() {
        if (caudal > min) {
            caudal -= 10;
        }
    }

	public bool gotUpperLimit(){
		return caudal == max;
	}

	public bool gotLowerLimit(){
		return caudal == min;
	}

	public int getCaudal(){
		return caudal;
	}

	public bool isCavitating(){
		return caudal >= 70;
	}
}
