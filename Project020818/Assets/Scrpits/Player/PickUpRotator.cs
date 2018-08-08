using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotator : MonoBehaviour
{
    public string PickUpName;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 39, 45) * Time.deltaTime);
    }
}
