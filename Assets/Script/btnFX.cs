using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
	public AudioSource myFX;
	public AudioClip clickFx;

	public void ClickSound()
	{
		myFX.PlayOneShot(clickFx);
	}
}