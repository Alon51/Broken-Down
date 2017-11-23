using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlankColor : MonoBehaviour {
    public Text plankText;
    public Toggle plankToggle;

    public void OnPlankToggle() {
        if(plankToggle.isOn) {
            plankText.color = Color.green;
        } else {
            plankText.color = Color.red;
        }
    }
}