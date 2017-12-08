using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour {
    public GameObject image;    

    public void OnButtonClick() {
        image.SetActive(false);
    }
}
