using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionOneRedo : MonoBehaviour {
    public GameObject FirstCanvas;
    public GameObject thisCanvas;

    public void OnButtonClick() {
        FirstCanvas.SetActive(true);
        thisCanvas.SetActive(false);
    }
}
