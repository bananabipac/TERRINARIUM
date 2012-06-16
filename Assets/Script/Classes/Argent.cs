using UnityEngine;
using System.Collections;

public class Argent {
	public static float argent=10000;
	
	public static void PerdreArgent(float perte){
		argent-=perte;
		if(argent<0){
			argent=0; 
		}
	}	
	public static bool DepenseArgent(float depense){
		if(argent<depense){
			return false;
		}
		return true;
	}
	
	public static void GagnerArgent(float gains){
		argent+=gains;
	}
	
}
