using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTireCanvasSelector : MonoBehaviour {
    public GameObject mainCanvas;
    public GameObject firstQuestionCanvas;

    public void StartQuestions() {
        mainCanvas.SetActive(false);
        firstQuestionCanvas.SetActive(true);
    }
}