using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTireInfo : MonoBehaviour {

    public void LoadTireInfoScene() {
        SceneManager.LoadScene("LowTireInfo");
    }
}
