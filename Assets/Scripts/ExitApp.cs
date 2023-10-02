using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public void ExitGame()
    {
        
        SaveProgress();

        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void SaveProgress()
    {
        //  progress saving logic 
        
    }
}
