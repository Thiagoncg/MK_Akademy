using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control1 : MonoBehaviour
{
    public Transform cameratransform;
    public Vector2 rotacaomouse;
    public int sensibilidade;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 controleMouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        rotacaomouse = new Vector2(rotacaomouse.x + controleMouse.x * sensibilidade * Time.deltaTime, rotacaomouse.y + controleMouse.y * sensibilidade * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotacaomouse.x, transform.eulerAngles.z);
        rotacaomouse.y = Mathf.Clamp(rotacaomouse.y, -80, 80);
        cameratransform.localEulerAngles = new Vector3(-rotacaomouse.y, cameratransform.localEulerAngles.y, cameratransform.localEulerAngles.z);

        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        transform.LookAt(target, Vector3.left);
    }
}
