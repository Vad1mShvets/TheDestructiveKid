using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiece : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 45);
    }
    void FixedUpdate()
    {
        this.transform.localScale *= 0.999f;
    }
}
