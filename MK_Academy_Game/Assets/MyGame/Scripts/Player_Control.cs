using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    private Rigidbody rb;
    public float vertical;
    public float jump;
    public float horizontal;

    [Header("status")]
    public float puloforce;
    public float speed = 5f;
    public float speedi = 5f;
    public float speedrun = 10f;
    public bool isGrounder = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical"); // W = 1 | S = -1
        horizontal = Input.GetAxis("Horizontal"); // A = -1 | D = 1

        if(Input.GetKeyDown(KeyCode.Space) && isGrounder)
        {
        rb.AddForce(Vector3.up * puloforce, ForceMode.Impulse);
        isGrounder = false;
        }

        else if(Input.GetKey(KeyCode.LeftShift))
        {
        speed = speedrun;     
        }
        
        else
        {
        speed = speedi;
        }
    }

    void FixedUpdate()
    {
        //MOVIMENTAÇÃO PARA FRENTE
        Vector3 desiredVelocity = transform.forward * vertical * speed; // Velocidade final / Desejada
        Vector3 changedVelocity = desiredVelocity - rb.velocity; //Velocidade final - inicial
        changedVelocity.y = 0; //fez com que a gravidade afete o jogador

        //MOVIMENTAÇÃO PARA OS LADOS
        Vector3 desiredVelocityX = transform.right * horizontal * speed; //
        Vector3 changedVelocityX = desiredVelocityX - rb.velocity; //
        changedVelocityX.y = 0;

        rb.AddForce(changedVelocity, ForceMode.VelocityChange);
        rb.AddForce(changedVelocityX, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("chao"))
        {
        isGrounder = true;
        }
    }
}
