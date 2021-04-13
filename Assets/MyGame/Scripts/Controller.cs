using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

	public void ChangeScene01()
	{
		SceneManager.LoadScene("Szene2");
	}

    public void ChangeScene02()
	{
		SceneManager.LoadScene("Szene3");
	}

    public void ChangeScene03()
	{
		SceneManager.LoadScene("Szene1");
	}

    public Button A2;
    public Button A3;

    public void ChangeColor()
    {
    
    }

}
