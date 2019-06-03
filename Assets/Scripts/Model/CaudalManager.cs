using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CaudalManager
{
	public static int caudal=50;
	private const int min = 25;
	private const int max = 75;

    public void increase() {
        if (caudal < max) {
            caudal+=25;
        }
    }

    public void decrease() {
        if (caudal > min) {
            caudal -= 25;
        }
    }

	public bool gotUpperLimit(){
		return caudal == max;
	}

	public bool gotLowerLimit(){
		return caudal == min;
	}

	public int getCaudal(){
		if (caudal == 75)
			return 70;
		return caudal;
	}

	public bool isCavitating(){
		return caudal >= 70;
	}
}
