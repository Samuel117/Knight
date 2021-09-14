using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool fGolpeado = false; 
    public static bool jGolpeado = false;
    public static bool jugadorGolpeado = false;
    public Jugador jugador;
    public GeneradorFlechas generador;
    public GameObject F, J;
  
    private void Start()
    {
       // generador.SetDebeDisparar(true);
    }

    private void Update()
    {
        if(fGolpeado && jGolpeado)
        {
            jugador.SetVelocidad(4.5f);
            jugador.GetComponent<Animator>().SetBool("isMoving", true);
            F.SetActive(false);
            J.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(FindObjectOfType<Player>().gameObject);
            SceneManager.LoadScene(0); 
        }

    }
}
