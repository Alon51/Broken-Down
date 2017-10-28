using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseAirPressure : MonoBehaviour {
    public int num = 20;
    public Text airPressure;

    public void OnButtonClick() {
        num++;
        airPressure.text = num.ToString();
    }
}
