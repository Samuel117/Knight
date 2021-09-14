using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    private float VELOCIDAD = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(VELOCIDAD * Time.deltaTime, 0, 0));
    }

    public void SetVelocidad(float velocidad)
    {
        VELOCIDAD = velocidad;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fire")
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collision.gameObject.tag == "Barril" && !collision.gameObject.GetComponent<Barril>().destruir)
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collision.gameObject.tag == "Carreta" && collision.gameObject.transform.position.y >= -0.14)
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
