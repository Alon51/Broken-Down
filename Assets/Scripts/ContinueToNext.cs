using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToNext : MonoBehaviour {

    public void LoadTireScene() {
        SceneManager.LoadScene("LowTireScene");
    }
}
