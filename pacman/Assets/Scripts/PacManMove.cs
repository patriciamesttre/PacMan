using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMove : MonoBehaviour
{

    public float speed = 0.4f;

    Vector2 dest = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Cima");
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Baixo");
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Esquerda");
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Direita");
        }
    }
}
