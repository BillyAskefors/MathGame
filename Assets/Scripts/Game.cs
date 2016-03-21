using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
    public GameObject cube;
    public Camera mainCamera;

    private Vector3 startPosition = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
        Instantiate(cube, startPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("pew pew");
                GameObject currentObject = hit.transform.gameObject;
                currentObject.transform.Translate(new Vector3(5, 5, 5));
                
            }
        }
    }
}
