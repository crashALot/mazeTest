using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
	
	public void Start()
	{
		
	}
	
	public void Update()
	{
		
	}
	
	public void NextScene()
    {
        SceneManager.LoadScene("play_game");
    }
}
