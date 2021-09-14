using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carreta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //transform.Translate(new Vector3(5f * Time.deltaTime, 0, 0));
        if(this.gameObject.GetComponent<Rigidbody2D>().velocity  != new Vector2 (0,0))
        {
            this.gameObject.GetComponent<Animator>().SetBool("mover", true);
        }
        else
        {
            this.gameObject.GetComponent<Animator>().SetBool("mover", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Espada>() != null)
        {
            FindObjectOfType<Player>().PlayWheel();
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(700,0));
        }
    }

}
