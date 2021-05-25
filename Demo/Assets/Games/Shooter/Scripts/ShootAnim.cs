using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnim : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gun;
    public GameObject ammo4;
    public GameObject ammo3;
    public GameObject ammo2;
    public GameObject ammo1;
    public AudioSource ShootSound;
    public AudioSource ReloadSound;
    public bool NotAbleToShoot = false;
    public Animator animator;
    public float bullets = 4;
    public float ReloadSpeed;

    //metal hole
    public GameObject MetalHole;
    public float distance = 10f;
    public Camera cam;
    public LayerMask Floor;
    public LayerMask Wall;
    public LayerMask Roof;
    public bool hits = false;

    //targets
    public GameObject Target0;
    public LayerMask TargetZ;
    public GameObject Target1;
    public LayerMask TargetO;
    public GameObject Target2;
    public LayerMask TargetT;

    public bool hitting = false;
    void Start()
    {
        animator = Gun.GetComponent<Animator>();
        InvokeRepeating("Reload", ReloadSpeed, ReloadSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        //enables/disables user from pressing shoot
        if (Input.GetButtonDown("Fire1"))
        {
            if (NotAbleToShoot == false && bullets > -0)
            {
                StartCoroutine(Shooting());
            }

            if (bullets == 4)
            {
                ammo4.SetActive(true);
                ammo3.SetActive(false);
                ammo2.SetActive(false);
                ammo1.SetActive(false);
            }
            if (bullets == 3)
            {
                ammo4.SetActive(false);
                ammo3.SetActive(true);
                ammo2.SetActive(false);
                ammo1.SetActive(false);
            }
            if (bullets == 2)
            {
                ammo4.SetActive(false);
                ammo3.SetActive(false);
                ammo2.SetActive(true);
                ammo1.SetActive(false);
            }
            if (bullets == 1)
            {
                ammo4.SetActive(false);
                ammo3.SetActive(false);
                ammo2.SetActive(false);
                ammo1.SetActive(true);
            }
            if (bullets == 0)
            {
                ammo4.SetActive(false);
                ammo3.SetActive(false);
                ammo2.SetActive(false);
                ammo1.SetActive(false);
            }
        }
    }
    IEnumerator Shooting()
    {
        NotAbleToShoot = true;
        animator.SetBool("Shooting", true);
        Gun.GetComponent<Animator>().Play("shoot");
        bullets = bullets - 1;
        ShootSound.Play();

        RaycastHit hit;
        //hole
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, Floor))
        {
            GameObject bH = Instantiate(MetalHole, hit.point + new Vector3(0f, 0.01f, 0f), Quaternion.LookRotation(-hit.normal));
        }

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, Roof))
        {
            GameObject bH = Instantiate(MetalHole, hit.point + new Vector3(0f, -0.01f, 0f), Quaternion.LookRotation(-hit.normal));
        }

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, Wall))
        {
            GameObject bH = Instantiate(MetalHole, hit.point + new Vector3(0.002f, 0f, 0.002f), Quaternion.LookRotation(-hit.normal));
        }

        //hole

        //targets
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, TargetZ))
        {
            Target0.GetComponent<Target>().DoIt();
            hitting = true;
        }

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, TargetO))
        {
            Target1.GetComponent<Target>().DoIt();
            hitting = true;
        }

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance, TargetT))
        {
            Target2.GetComponent<Target>().DoIt();
            hitting = true;
        }
        //targets

        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Shooting", false);
        NotAbleToShoot = false;
    }

    void Reload()
    {
        bullets = 4;
        ammo4.SetActive(true);
        ammo3.SetActive(false);
        ammo2.SetActive(false);
        ammo1.SetActive(false);
        ReloadSound.Play();
    }

}
