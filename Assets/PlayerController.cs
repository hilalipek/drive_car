using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    //private degiskeni sadece dosyada publıc degıskenı unity ekranında da degişiklik saglar
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float yatayGiris;
    private float dikeyGiris;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yatayGiris= Input.GetAxis("Horizonal");
        dikeyGiris= Input.GetAxis("Vertical");
        //burada aracı hareket ettircez
        //ileri geri
        transform.Translate(Vector3.forward * Time.deltaTime * speed * dikeyGiris);
        //sag sol
        transform.Rotate(Vector3.up, turnSpeed * yatayGiris * Time.deltaTime);
    }
}
