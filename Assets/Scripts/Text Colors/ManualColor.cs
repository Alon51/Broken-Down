using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualColor : MonoBehaviour {
    public Text manualText;
    public Toggle manualToggle;

    public void OnManualToggle() {
        if(manualToggle.isOn) {
            manualText.color = Color.green;
        } else {
            manualText.color = Color.red;
        }
    }
}