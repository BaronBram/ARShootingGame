using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour 
{
 
 public int distanceOfRay = 20; // jarak cursor dr kamera ke objek
 private RaycastHit hit; //menerima objek apa yg bakal kena raycast
	// Use this for initialization
	

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));//mengeluarkan raycast dr titik tengah camera
        Debug.DrawLine(transform.position, hit.point, Color.red);
        if(Physics.Raycast(ray, out hit, distanceOfRay)){//apabila ad sesuatu dr Raycast
            if(Input.GetButtonDown("Fire1")&&hit.transform.CompareTag("Enemy")){
                Destroy(hit.transform.gameObject);//destroy sesuatu itu
                GetComponent<AudioSource>().Play();
            }

        }
	}
}
