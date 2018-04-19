using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderLoad : MonoBehaviour {

	public void LoadStage()
    {
        SceneManager.LoadScene("LeaderBoard");
    }
}
