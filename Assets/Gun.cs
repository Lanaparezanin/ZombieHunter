using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;
    public float impact = 30f;

    //public GameObject gunSound;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            AudioSource audio = gameObject.AddComponent<AudioSource>();
            audio.PlayOneShot(Resources.Load<AudioClip>("Sounds/bullet"));
            //Resources.Load<AudioClip>("Audio/audioClip01");
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
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
        }
    }
}
