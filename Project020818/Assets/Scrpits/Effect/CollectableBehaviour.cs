using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{

    public PlatformMovement3D activePlayer;
    public Collider triggerArea;
    public readonly string containerName = "CollectableContainer";
    public readonly Vector3 idlePoint = new Vector3(0.5f, 0.75f, 0f);
    public readonly Vector3 center = new Vector3(0f, 0.75f, 0f);

    public string CollectableName;

    bool waitForNextAction = false;
    public bool isWaiting { get { return waitForNextAction; } }

    // Use this for initialization
    void Start() {
        if (!activePlayer)
        {
            triggerArea.enabled = true;
        }
    }

    public void AssignActivePlayer(PlatformMovement3D targetPlayer){
        activePlayer = targetPlayer;
        transform.SetParent(activePlayer.transform.Find(containerName));
        //transform.localPosition = idlePoint;
        transform.rotation = targetPlayer.transform.rotation;
        triggerArea.enabled = false;
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Damageable"))
        {
            Debug.Log(CollectableName.Replace("Collectable 1", ""));
            other.GetComponent<DamageableObject>().TakeDamage(CollectableName.Replace("Collectable 1", ""));
        }
    }
}