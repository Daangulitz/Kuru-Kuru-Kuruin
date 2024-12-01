using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void FixedUpdate()
    {
        m_Rigidbody.rotation += 2f;
        if(Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(5f, 0f));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2( -5f, 0f));
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0f, 5f));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0f, -5f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("U hit Something");
        transform.position = Vector3.zero;
    }
}
