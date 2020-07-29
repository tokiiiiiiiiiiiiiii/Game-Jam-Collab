using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    
    public void Reset()
    {
        Object[] allObjects = Object.FindObjectsOfType<GameObject>();
        foreach (GameObject Letter in allObjects)
        {
            Destroy(Letter);
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
        
    }
}
