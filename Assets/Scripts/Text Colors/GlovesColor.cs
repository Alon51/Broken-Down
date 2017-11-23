using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlovesColor : MonoBehaviour {
    public Text glovesText;
    public Toggle glovesToggle;

    public void OnGlovesToggle() {
        if(glovesToggle.isOn) {
            glovesText.color = Color.green;
        } else {
            glovesText.color = Color.red;
        }
    }
}