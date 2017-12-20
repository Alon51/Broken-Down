using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submitButton : MonoBehaviour {

	public GameObject showInfoPanel;
	public Button infoButton;
	public Dropdown one;
	public Dropdown two;
	public Dropdown three;
	public Dropdown four;
	byte triels;
	public Text text;

	void Start()
	{
		triels = 0;
		showInfoPanel.SetActive(false);

		Button btn = infoButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		triels++;
		if (triels == 3) {
			text.text = "Set option one to: Will try to remain calm to be able to think clearly";
		}else if(triels == 5){
			text.text = "Set option two to: Find a safe zone to rest while I am trying to manage the situation";
		}else if(triels == 6){
			text.text = "Set option three to: If there are injured people I will call 911";
		}else if(triels == 7){
			text.text = "Set option four to: Let my insurance company know about the accident";
		}
			
		if(one.captionText.text.Equals("Will try to remain calm to be able to think clearly")){
			
			if (two.captionText.text.Equals ("Find a safe zone to rest while I am trying to manage the situation")) {
				
				if (three.captionText.text.Equals ("If there are injured people I will call 911")) {
					
					if (four.captionText.text.Equals ("Let my insurance company know about the accident")) {
						
						showInfoPanel.gameObject.SetActive (true);
					}
				}
			}
		}
	}
}
