using UnityEngine;
using System.Collections;

public class KeAgDestroyByContact : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))

            other.gameObject.SetActive(false);


    }
}
