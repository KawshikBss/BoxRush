using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public bool isEnabled = true;
    public AudioSource bgMusic;
    public AudioSource collisionSound;
    public PlayerMovement movement;
    public float collisionForce = 200f;

    void OnCollisionEnter(Collision collisionInfo) {
        if (isEnabled) {
            if (collisionInfo.collider.tag == "Obsticle") {
                collisionSound.Play();
                bgMusic.Stop();
                movement.enabled = false;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Rigidbody>().AddForce(0, collisionForce * Time.deltaTime, 0);
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
