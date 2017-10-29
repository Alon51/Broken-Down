using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayValue : MonoBehaviour {
    public GameObject num;

    public void OnButtonClick() {
        num.SetActive(true);
    }
}
