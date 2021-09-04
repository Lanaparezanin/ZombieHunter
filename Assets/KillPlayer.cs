using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public GameObject deathScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            deathScreen.SetActive(true);
            StartCoroutine(ReloadLevel());
            //Debug.Log("Entered collider");
        }
    }

    private IEnumerator ReloadLevel()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
