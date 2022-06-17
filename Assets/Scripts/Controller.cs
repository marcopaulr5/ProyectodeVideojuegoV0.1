using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x,y;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x* Time.deltaTime * velocidadRotacion,0); // Rotacion
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov); // Mover

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);
    }
}
