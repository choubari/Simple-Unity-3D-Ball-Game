using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleurJoueur : MonoBehaviour
{
	public float vitesse;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(mouvement*vitesse);

    }
}
