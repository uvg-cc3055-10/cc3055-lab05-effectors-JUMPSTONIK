using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time;
    public GameObject AE1;
    public GameObject AE2;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time >3)
        {
            AE1.gameObject.SetActive(false);
            
        }
        

        if (time > 4.5)
        {
            AE2.gameObject.SetActive(false);
            time = 0;
        }
        AE1.gameObject.SetActive(true);
        AE2.gameObject.SetActive(true);


    }
}
