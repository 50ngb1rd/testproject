using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dataPacket;
    public Transform end;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        dataPacket.transform.position = Vector3.MoveTowards(this.transform.position, end.position, speed * Time.deltaTime);
    }
}
