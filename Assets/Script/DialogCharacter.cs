using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCharacter : MonoBehaviour
{
	[SerializeField]
	private List<string> Read = new List<string> ();
    
	public int GetReadCount()
    {
		return Read.Count;
    }

    
	public string GetReadStringIndex(int i)
    {
		return Read [i];
    }
}
