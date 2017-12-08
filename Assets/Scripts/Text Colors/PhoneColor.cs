using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneColor : MonoBehaviour {
    public Text phoneText;
    public Toggle phoneToggle;

    public void OnPhoneToggle() {
        if(phoneToggle.isOn) {
            phoneText.color = Color.green;
        } else {
            phoneText.color = Color.red;
        }
    }
}