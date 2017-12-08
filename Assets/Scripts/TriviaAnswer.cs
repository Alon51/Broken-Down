using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriviaAnswer : MonoBehaviour {
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;
    public GameObject correctText;
    public GameObject incorrectText;
    public GameObject nextSceneButton;
    
    public void OnCorrectAnswer() {
        Destroy(buttonA);
        Destroy(buttonB);
        Destroy(buttonC);

        correctText.SetActive(true);
        nextSceneButton.SetActive(true);
    }
    
    public void OnIncorrectAnswer() {
        Destroy(buttonA);
        Destroy(buttonB);
        Destroy(buttonC);

        incorrectText.SetActive(true);
        nextSceneButton.SetActive(true);
    }
}
