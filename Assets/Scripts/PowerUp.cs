using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject particleEffect;
    public float duration = 2f;
    public bool slowTime = false;
    public bool phase = false;
    public bool shrink = false;
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(PickUp(other));
        }
    }

    IEnumerator PickUp(Collider other) {
        Instantiate(particleEffect, transform.position, transform.rotation);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        if (slowTime)
            SlowTime();
        else if (phase)
            Phase(other);
        else if (shrink)
            Shrink(other);
        yield return new WaitForSeconds(duration);
        if (slowTime)
            RevertTime();
        else if (phase)
            RevertPhase(other);
        else if (shrink)
            RevertShrink(other);
        Destroy(gameObject);
    }
    void SlowTime() {
        Time.timeScale *= 0.5f;
    }

    void RevertTime() {
        Time.timeScale *= 2f;
    }
    void Phase(Collider player) {
        PlayerCollision playerCol =  player.GetComponent<PlayerCollision>();
        Rigidbody playerRigid = player.GetComponent<Rigidbody>();
        playerRigid.useGravity = false;
        player.isTrigger = true;
        playerCol.isEnabled = false;
    }
    void RevertPhase(Collider player) {
        PlayerCollision playerCol =  player.GetComponent<PlayerCollision>();
        Rigidbody playerRigid = player.GetComponent<Rigidbody>();
        playerRigid.useGravity = true;
        player.isTrigger = false;
        playerCol.isEnabled = true;
    }
    void Shrink(Collider player) {
        player.transform.localScale *= 0.5f;
    }
    void RevertShrink(Collider player) {
        player.transform.localScale *=  2f;
    }
}
