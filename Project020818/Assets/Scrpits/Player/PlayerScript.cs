using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float maxHP = 1f;
    public float currentHP;
    public PowerBallBehaviour currentPower;
    public PickUpRotator Pick;

    public float normalizedHP { get { return currentHP / maxHP; } }


    public void ModifyHP(float addValue)
    {
        currentHP = Mathf.Clamp(currentHP + addValue, 0, maxHP);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Gate1"));
        }

        if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("PickUp2"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Gate2"));
        }

        if (other.gameObject.CompareTag("PickUp3"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("PickUp3"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Gate3"));
        }

        /*if (other.gameObject.CompareTag("CamChange"))
        {
            other.gameObject.camera(true);*/
    }
    }
