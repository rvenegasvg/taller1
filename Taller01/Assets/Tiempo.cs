using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Tiempo : MonoBehaviour

{

    public int time = 1;

    //void Update()

    //{
    //    time = time + Time.deltaTime;
    //}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            Debug.Log("borrando los segundos");
            PlayerPrefs.DeleteKey("segundos");
        }
    }

    private void Awake()
    {
        if (PlayerPrefs.HasKey("segundos"))
        {
            Debug.Log("si hay tiempo registrado");
            Debug.Log("el tiempo es: " + PlayerPrefs.GetInt("segundos"));
        }
        else
        {
            Debug.Log("es la primera ejecucion, no hay registro de tiempo aun");
        }
       // Debug.Log("los segundos son: "+ PlayerPrefs.GetInt("segundos"));
        
    }
    private void Start()
    {

        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        PlayerPrefs.SetInt("segundos",time);
        yield return new WaitForSeconds(1);
        time++;
       // Debug.Log("el tiempo es: "+time);
        yield return timer();
    }

}