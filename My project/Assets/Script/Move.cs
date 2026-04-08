using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1f;

    private float time = 0f;

    private MeshRenderer r;
    private Collider c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        r = GetComponent<MeshRenderer>();
        r.material.color = Random.ColorHSV();

        c = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (time > 1.0f)
        {
            Destroy(gameObject);
        }

        time += Time.deltaTime;
    }

    private void OnMouseDown()
    {

    }
}
