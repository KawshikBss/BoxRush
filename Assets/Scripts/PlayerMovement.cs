using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float fwrForce = 1000f;
    public float sideForce = 5f;
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, fwrForce * Time.deltaTime);
        Vector3 pos = transform.position;
        float h = Input.acceleration.x;
        pos.x += h * sideForce * Time.deltaTime;
        fwrForce += 5;
        if (Input.GetKey("d"))
            GetComponent<Rigidbody>().AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        if (Input.GetKey("a"))
            GetComponent<Rigidbody>().AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        transform.position = pos;
        if (pos.y <= -1) {
            GameObject.FindObjectOfType<GameManager>().EndGame();
        }
    }
}
