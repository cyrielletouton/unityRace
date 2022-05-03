using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitThePoint : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(message: "Bien arrivé");
        Destroy(gameObject);
        SceneManager.LoadScene("SampleScene");
    }
}

