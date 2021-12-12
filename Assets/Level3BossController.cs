using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level3BossController : MonoBehaviour
{
    public Button button;

    public GameObject ZombiStoji;
    public GameObject ZombiPada;

    public GameObject ZombieShotRedDot;
    public GameObject MissedShotUp;
    public GameObject MissedShotDown;

    public GameObject WinScreen;
    public GameObject TryAgainScreen;

    public InputField inputField1;
    int value = 0;


    // Start is called before the first frame update
    void Start()
    {
        inputField1.ActivateInputField();
        button.onClick.AddListener(TaskOnClick);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputField1.text != "")
        {
            value = int.Parse(inputField1.text);
            //check if number bigger or smaller than 360 and 0
        }
    }

    void TaskOnClick()
    {
        if (value == 60)
        {
            Killer();
        }
        else if (value > 60)
        {
            MissedUp();
        }
        else if (value < 60)
        {
            MissedDown();
        }
    }

    void Killer()
    {
        //make zombie fall
        ZombiStoji.SetActive(false);
        ZombiPada.SetActive(true);

        //put red on zombie and make win screen
        StartCoroutine(ZombieShot());
    }

    void MissedUp()
    {
        //make zombie fall
        ZombiStoji.SetActive(false);
        ZombiPada.SetActive(true);

        MissedShotUp.SetActive(true);
        StartCoroutine(TryAgain());

    }

    void MissedDown()
    {
        //make zombie fall
        ZombiStoji.SetActive(false);
        ZombiPada.SetActive(true);

        MissedShotDown.SetActive(true);
        StartCoroutine(TryAgain());
    }

    private IEnumerator ZombieShot()
    {
        yield return new WaitForSeconds(0.1f);
        ZombieShotRedDot.SetActive(true);
        yield return new WaitForSeconds(1);
        WinScreen.SetActive(true);
    }

    private IEnumerator TryAgain()
    {
        yield return new WaitForSeconds(0.5f);
        TryAgainScreen.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
