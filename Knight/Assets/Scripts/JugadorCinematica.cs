using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugadorCinematica : MonoBehaviour
{
    public float VELOCIDAD = 0f;
    public Animator animator;
    public GameObject scroll;
    private bool hasArrived = false;
    public AudioClip paper,sparkle;
    public AudioSource audio;
    // Update is called once per frame

    [SerializeField] GameObject Fade;
    private void Start()
    {
        Invoke("Iniciar", 2f);
    }

    void Update()
    {
        transform.Translate(new Vector3(VELOCIDAD * Time.deltaTime, 0, 0));
        if (hasArrived)
        {
            Invoke("Mostrar", 1);
            Invoke("NoMostrar", 5);
            hasArrived = false;
            Invoke("Fadear", 8);
            Invoke("CambioEscena", 10);
        }
    }

    private void NoMostrar()
    {
        scroll.SetActive(false);
        animator.SetBool("timePassed", true);
        audio.PlayOneShot(sparkle, .3f);
    }

    private void Mostrar()
    {
        scroll.SetActive(true);
        audio.PlayOneShot(paper, .3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isMoving",false);
        VELOCIDAD = 0;
        hasArrived = true;
    }

    private void CambioEscena()
    {
        SceneManager.LoadScene(2);
    }

    private void Iniciar()
    {
        VELOCIDAD = 3.5f;
    }

    private void Fadear()
    {
        Fade.gameObject.SetActive(true);
    }
}
