using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDataMovemet : MonoBehaviour
{
    
    public Transform end;
    public float speed;
    // Start is called before the first frame update
    
    public void OnButtonPressed()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, end.position, speed * Time.deltaTime);
    }
}
