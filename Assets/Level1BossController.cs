using UnityEngine;
using UnityEngine.UI;

public class Level1BossController : MonoBehaviour
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

        if (Input.GetButtonDown("Fire1"))
        {
            

            /*RaycastHit hit;
            if (Physics.Raycast(ball.transform.position, ball.transform.forward, out hit, range))
            {
                //Debug.Log(hit.transform.name);
                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impact);
            }*/

        }

    }

    void TaskOnClick()
    {
        if (value >= 14 && value <= 16)
        {
            Killer();
        }
        else if (value > 16)
        {
            MissedUp();
        }
        else if (value < 14)
        {
            MissedDown();
        }
    }

    void Killer()
    {
        launchVelocity = 300f;
        GameObject ball = Instantiate(projectile, transform.position,
                                                      transform.rotation);

        ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                             (launchVelocity, launchVelocity, 0));
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
}
