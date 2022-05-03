using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bouger la voiture à droite
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector2.right * Time.deltaTime * speed);
        }
        // Bouger la voiture à gauche
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector2.left * Time.deltaTime * speed);
        }
    }
}
