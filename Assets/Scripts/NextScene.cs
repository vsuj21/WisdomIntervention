using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void ChangeScene(int k)
    {
        SceneManager.LoadScene(k);
    }
}
