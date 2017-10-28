using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public void BackToMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadTireInfo() {
        SceneManager.LoadScene("LowTireInfo");
    }

    public void LoadTireScene() {
        SceneManager.LoadScene("LowTireScene");
    }

    public void LoadAirPressureTrivia() {
        SceneManager.LoadScene("AirPressureTrivia");
    }

    public void LoadRules() {
        SceneManager.LoadScene("Rules");
    }

    public void ExitApplication() {
        Application.Quit();
    }
}
