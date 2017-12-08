using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightColor : MonoBehaviour {
    public Text flashlightText;
    public Toggle flashlightToggle;

    public void OnFlashlightToggle() {
        if(flashlightToggle.isOn) {
            flashlightText.color = Color.green;
        } else {
            flashlightText.color = Color.red;
        }
    }
}