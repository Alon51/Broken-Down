using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImage : MonoBehaviour {
    public GameObject image;

    public void OnButtonClick() {
        image.SetActive(true);
    }
}
