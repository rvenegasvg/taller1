using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Persecucion : MonoBehaviour
{
    public Transform objetivo;
    public UnityEngine.AI.NavMeshAgent agente;
    public ControllerJuego controller;
    // Start is called before the first frame update
    void Start()
    {
        
        agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agente.speed = controller.dificultad;
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;
    }
}
