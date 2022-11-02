using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadigScean : MonoBehaviour
{
	AsyncOperation asyncOperation;
	public Image LoadBar;
	public int ScenID;
	public TMP_Text BarText;

	void Start()
	{
		StartCoroutine(LoadSceneCor());
	}

	IEnumerator LoadSceneCor()
	{
		yield return new WaitForSeconds(1f);
		asyncOperation = SceneManager.LoadSceneAsync(ScenID);
		while(!asyncOperation.isDone)
		{
			float progress = asyncOperation.progress / 0.9f;
			LoadBar.fillAmount = progress;
			BarText.text = "" + string.Format("{0:0}%" , progress * 100f);
			yield return 0;
		}
	}
}