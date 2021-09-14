using UnityEngine;

public class Linea : MonoBehaviour
{
    public Rigidbody2D hook;
    public HingeJoint2D endHook;
    public GameObject linkPrefab;
    public int links = 3;

    private GameObject[] cubos = new GameObject[5];

    void Start()
    {
        generateRope();
    }
     void generateRope()
    {

        Rigidbody2D prevRB = hook;
        for(int i = 0; i < links; i++)
        {
            GameObject link =  Instantiate(linkPrefab, transform);
            cubos[i] = link.gameObject;
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = prevRB;
            prevRB = link.GetComponent<Rigidbody2D>();
        }
        endHook.connectedBody = prevRB;
    }

    private void RomperMeta()
    {
        Destroy(cubos[2]);
        int p = FindObjectOfType<Checkpoints>().pointGetter();
        FindObjectOfType<Checkpoints>().pointSetter(p + 1);
        print("Linea: " + FindObjectOfType<Checkpoints>().pointGetter());
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RomperMeta();
    }

}
