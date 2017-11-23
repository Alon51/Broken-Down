using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JackColor : MonoBehaviour {
    public Text jackText;
    public Toggle jackToggle;

    public void OnJackToggle() {
        if(jackToggle.isOn) {
            jackText.color = Color.green;
        } else {
            jackText.color = Color.red;
        }
    }
}