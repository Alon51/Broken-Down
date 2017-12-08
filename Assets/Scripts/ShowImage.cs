using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameObject : MonoBehaviour {
    public GameObject image;

    public void OnButtonClick() {
        image.SetActive(true);
    }
}
