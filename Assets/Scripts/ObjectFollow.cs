using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Custum/Camara/Camara 2D")]
public class ObjectFollow : MonoBehaviour
{ 
    public Transform objectivoCamara;
    public float distancia = 0.0f;
    public float altura = 0.0f;
    public float velocidadDesplazamiento = 1.0f;

    private float posicionCamaraX = 0.0f;
    private float posicionPersonajeX = 0.0f;
    private Transform refTransform;

    
    // Start is called before the first frame update
    void Start()
    {
        refTransform = this.GetComponent<Transform>();

        refTransform.position = new Vector3(objectivoCamara.position.x, altura, distancia);
        posicionCamaraX = objectivoCamara.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void LateUpdate()
    {
        posicionPersonajeX = objectivoCamara.position.x;

        posicionCamaraX = Mathf.Lerp(posicionCamaraX, posicionPersonajeX, velocidadDesplazamiento * Time.deltaTime);

        refTransform.position = new Vector3(posicionCamaraX, altura, distancia);
    }
}
