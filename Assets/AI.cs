using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
    private float Botx;
    private float Boty;
    private Vector3 PlayerPos;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Botx = transform.position.x;
        Boty = transform.position.y;
    }
}
