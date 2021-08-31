using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Child child;

    void Awake()
    {
        child = GameObject.Find("Child").GetComponent<Child>();
    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(child.transform.position.x * 0.6f, child.transform.position.y * 0.6f, this.transform.position.z);
    }
}
