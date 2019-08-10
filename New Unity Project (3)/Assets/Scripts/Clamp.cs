using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clamp : MonoBehaviour
{
    public TextMesh nameLabel;
    public Transform end;
    public float speed;
    void Update()
    {
        //Vector3 namePos = gameObject.transform.position;
        Debug.Log(this.transform.position);
        nameLabel.transform.position = Vector3.MoveTowards(this.transform.position, end.position, speed * Time.deltaTime);
        //nameLabel.transform.position = namePos;
    }
}
