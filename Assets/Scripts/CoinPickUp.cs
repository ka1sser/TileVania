using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{

    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] GameObject coinPickUpVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject coinPickUpVFXObject = Instantiate(coinPickUpVFX, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
        Destroy(coinPickUpVFXObject, 0.3f);
    }
}
