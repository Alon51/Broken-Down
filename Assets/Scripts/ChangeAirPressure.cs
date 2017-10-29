using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAirPressure : MonoBehaviour {
    public Text airPressure;
    public GameObject air;
    public GameObject airText;

    public void AddAir() {
        airText.SetActive(false);
        int num = System.Convert.ToInt32(air.GetComponent<Text>().text);
        num++;
        airPressure.text = num.ToString();
    }

    public void RemoveAir() {
        airText.SetActive(false);
        int num = System.Convert.ToInt32(air.GetComponent<Text>().text);
        num--;
        airPressure.text = num.ToString();
    }
}
