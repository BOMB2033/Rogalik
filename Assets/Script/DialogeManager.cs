using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogeManager : MonoBehaviour
{
/*	public Button buttonUse;
	public List<GameObject> Character = new List<GameObject> ();
	public Text Textout;
	int IndexCharacter = 0;
	int IndexText = 0;
	DialogCharacter dialogCharacter;


    void Start()
    {
		WriteDialog ();
		IndexCharacter++;
    }

	private void WriteDialog()
	{
		if (Character.Count < IndexCharacter) 
		{
			if (Character [IndexCharacter].GetComponent<DialogCharacter> () != null) 
			{
				dialogCharacter = Character [IndexCharacter].GetComponent<DialogCharacter> ();
				if (IndexText >= dialogCharacter.GetReadCount ()) 
				{
					TextDialog("Диалог завершен");
				}
				else 
				{
					string text = dialogCharacter.GetReadStringIndex (IndexText);
					TextDialog (text);
				}
			}
		}
		else TextDialog("Диалог завершен");
	}
	private void TextDialog(string text)
	{
		Textout.text = text;
	}
	private void NextIndex()
	{
		for (int i = IndexCharacter; i < Character.Count; i++) 
		{
			WriteDialog ();
			IndexCharacter++;
			return;
		}
		if (IndexCharacter >= Character.Count) 
		{
			IndexCharacter = 0;
			IndexText++;
			WriteDialog();
		}
	}
    void Update()
    {
		if (buttonUse.onClick.AddListener(ClickUseButton));
		{
			NextIndex ();
			IndexCharacter++;
		}
    }
*/}
