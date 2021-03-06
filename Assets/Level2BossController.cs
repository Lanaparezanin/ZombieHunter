using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2BossController : MonoBehaviour
{
    //public GameObject weapon;
    public Button button;

    public InputField inputField1;
    int value = 0;

    public GameObject projectile;
    public float launchVelocity;// = 700f;

    public float damage = 20f;
    public float range = 100f;
    public float impact = 30f;

    private void Start()
    {
        inputField1.ActivateInputField();
        button.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {
        if (inputField1.text != "")
        {
            value = int.Parse(inputField1.text);
            //check if number bigger or smaller than 360 and 0
        }

    }

    void TaskOnClick()
    {
        if (value >= 28 && value <= 32)
        {
            Killer();
        }
        else if (value > 32)
        {
            MissedUp();
        }
        else if (value < 28)
        {
            MissedDown();
        }
    }

    void Killer()
    {
        launchVelocity = 500f;
        GameObject ball = Instantiate(projectile, transform.position,
                                                      transform.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                             (launchVelocity, 300, 500));
        StartCoroutine(NextLevel());
    }

    void MissedUp()
    {
        launchVelocity = 900f;
        GameObject ball = Instantiate(projectile, transform.position,
                                                      transform.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                             (launchVelocity, launchVelocity, 0));
    }

    void MissedDown()
    {
        launchVelocity = 100f;

        GameObject ball = Instantiate(projectile, transform.position,
                                                      transform.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                             (launchVelocity, launchVelocity, 0));
    }

    private IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Nivo3");
    }
}
