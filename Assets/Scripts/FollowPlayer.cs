using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("Player").transform.position + offset;
    }
}
