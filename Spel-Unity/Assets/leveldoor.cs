using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveldoor : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "NextLevel");
	{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		if (collision.tag == "PreviousLevel");
	{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		}
	}

}
