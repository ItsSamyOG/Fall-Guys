using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XescMoviment : MonoBehaviour
{
    //Variables de velocidad
    public float speed = 1.0f; //Velocidad de movimiento de jugador.

    public float rotationSpeed = 1.0f; //Velocidad de movimiento de cámara.

    public float jumpForce = 1.0f; //Fuerza de salto.


    private Rigidbody Physics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
           
}

    // Update is called once per frame
    void Update()
    {
    //Movimiento 
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);

    //Giro de camara
        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * rotationSpeed, 0));
        
        //Salto

        if (Input.GetKeyDown(KeyCode.Space)) {
            Physics.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
