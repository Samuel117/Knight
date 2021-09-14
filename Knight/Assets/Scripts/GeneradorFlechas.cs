using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorFlechas : MonoBehaviour
{
    [SerializeField] private GameObject Flecha;
    private float esperarDisparo = 0f;
    private bool debeDisparar = false;
    private int contador = 4;

    // Update is called once per frame
    void Update()
    {
        if (debeDisparar && contador > 0)
        {
            Disparar();
        }
        else
        {
            debeDisparar = false;
            contador = 5;
        }
    }

    private void Disparar()
    {
        if (PuedeDisparar(esperarDisparo))
        {
            Instantiate(this.Flecha, new Vector2(this.transform.position.x, this.transform.position.y), this.Flecha.transform.rotation);
            contador--;
            this.esperarDisparo = Time.time + 3f;
        }
    }

    protected bool PuedeDisparar(float tiempoEsperaDisparo)
    {
        //Establece si el jugador puede disparar o usar su habilidad especial. 
        return Time.time > tiempoEsperaDisparo;
    }

    public void SetDebeDisparar(bool _debeDisparar)
    {
        debeDisparar = _debeDisparar;
    }
}
