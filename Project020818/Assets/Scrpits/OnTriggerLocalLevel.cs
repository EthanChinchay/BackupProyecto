using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLocalLevel : MonoBehaviour {

    public GameObject gObject;
    public string levelToLoad;
        
	// Use this for initialization
	void Start () {
        gObject.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
        if (other.gameObject.tag == "Player") ;
        {
            gObject.SetActive(true);
            if(gObject.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
	}
    void OnTriggerExit()
    {
        gObject.SetActive(false);
    }
}
