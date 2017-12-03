using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow_RedoScenario : MonoBehaviour {

    public GameObject scenarioCanvas;
    public GameObject incorrectCanvas;

    public void OnButtonClick()
    {
        scenarioCanvas.SetActive(true);
        incorrectCanvas.SetActive(false);
    }
}
