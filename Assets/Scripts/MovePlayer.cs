using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private Transform refTransform = null;
    private Vector3 direccionMovimiento = Vector3.zero;

    public float velocidadMovimiento = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        refTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        direccionMovimiento = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

        refTransform.Translate(direccionMovimiento * velocidadMovimiento * Time.deltaTime);
    }
}
