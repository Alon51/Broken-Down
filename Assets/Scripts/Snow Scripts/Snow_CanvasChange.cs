using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow_CanvasChange : MonoBehaviour {

    public GameObject mainCanvas;
    public GameObject snowScenarioCanvas;

    public void StartQuestions()
    {
        mainCanvas.SetActive(false);
        snowScenarioCanvas.SetActive(true);
    }
}
