using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public CharacterController player;
    public float velocidad;
    public float velocidadRotacion = 180;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
      //  player.Move(new Vector3(horizontal,0,vertical)*velocidad*Time.deltaTime);

        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * velocidadRotacion * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        player.Move(move * velocidad);
        this.transform.Rotate(this.rotation);

    }
}
