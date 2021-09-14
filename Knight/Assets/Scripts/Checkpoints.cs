using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private static bool creado;
    private static int point;
    [SerializeField] GameObject[] checkpoints;
    // Start is called before the first frame update

    private void Awake()
    {
        if (!creado)
        {
            GameObject.DontDestroyOnLoad(gameObject);
            creado = true;
            init();
        }
    }

    void Start()
    {
        if (point >= 0)
        {
            FindObjectOfType<Jugador>().gameObject.transform.position = new Vector2(checkpoints[point].gameObject.transform.position.x + 8f, FindObjectOfType<Jugador>().gameObject.transform.position.y);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pointSetter(int valor)
    {
        point = valor;
    }
    public int pointGetter()
    {
        return point;
    }

    public void init()
    {
        //-1
        point = -1;
    }
}
