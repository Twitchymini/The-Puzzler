using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    float m_time = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_time += Time.deltaTime;

        Vector3 pos = gameObject.transform.position;
        pos.x += Mathf.Sin(m_time);
        gameObject.transform.position = pos;
    }
}
