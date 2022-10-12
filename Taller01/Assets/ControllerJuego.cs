using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJuego : MonoBehaviour
{
    public GameObject[] enemigos;
    public Transform[] posiciones;
    public List<int> PosicionRandom;
    [SerializeField]
    [Range(1, 3)]
    public int dificultad = 1;




    private void Start()
    {
        //enemigos[0].transform.position = new Vector3(0,0,0);//posiciones[0].position;
        //enemigos[0].transform.position = posiciones[0].position;


        PosicionRandom = new List<int>();
        for (int i = 0; i < posiciones.Length; i++)
        {
            int r = Random.Range(0, 3);

            while (PosicionRandom.IndexOf(r) > -1)
            {
                r = Random.Range(0, 3);
            }
            PosicionRandom.Add(r);
        }

        foreach (var item in PosicionRandom)
        {
            Debug.Log(item);
        }

        for (int i = 0; i < 3; i++)
        {
            enemigos[i].transform.position = posiciones[i].position;
        }


    
}


}
