using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyPickup : MonoBehaviour
{

    public GameObject door;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            door.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
