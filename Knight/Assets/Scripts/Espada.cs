using UnityEngine;
using UnityEngine.SceneManagement;

public class Espada : MonoBehaviour
{
    private KeyCode ARRIBA = KeyCode.F;
    private KeyCode ABAJO = KeyCode.J;

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(ARRIBA))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 15));
        }

        if (Input.GetKey(ABAJO))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10));
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Flecha>() != null)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "F") 
        { 
            GameManager.fGolpeado = true;
            Color color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, .5f);
        }

        if(collision.gameObject.tag == "J") 
        { 
            GameManager.jGolpeado = true;
            Color color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, .5f);
        }

        if(collision.gameObject.tag == "Atras")
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
