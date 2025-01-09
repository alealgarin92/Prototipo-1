using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables privadas 
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed;
     private float horizontalInput;
     private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Aqui se obtienen los input del jugador
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Movemos el vehiculo hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Giramos el vehiculo 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
