using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whatToDoScript : MonoBehaviour {

	public GameObject showInfoPanel;
	public Button infoButton;

	void Start()
	{
		showInfoPanel.SetActive(false);

		Button btn = infoButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		if (showInfoPanel.gameObject.activeInHierarchy.Equals(false)) {
			
			showInfoPanel.gameObject.SetActive (true);
		}
	}
}
