using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraQMove : MonoBehaviour
{
    [SerializeField]    Transform alvo;
    void LateUpdate()
    {
        transform.position = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
    }

}
