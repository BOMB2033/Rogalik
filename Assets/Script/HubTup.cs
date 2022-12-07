using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HubTup : MonoBehaviour
{

	public Button buttonHubTup;
	private float dist;


	// Start is called before the first frame update
	void Start()
	{
		buttonHubTup.onClick.AddListener(ClickChestButton);
	}

	// Update is called once per frame

	public void ClickChestButton ()
	{
		buttonHubTup.gameObject.SetActive(false);
		SceneManager.LoadScene(3);
	}

	void Update()
	{

		dist = Vector2.Distance(transform.position, GameObject.FindWithTag("Player").transform.position);

		if (dist < 1f)
		{
			buttonHubTup.gameObject.SetActive(true);
		}
		else
		{
			buttonHubTup.gameObject.SetActive(false);
		}

	}
}
