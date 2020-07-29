using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mayugescript : MonoBehaviour
{
    public GameObject[] hige;
    [SerializeField] int h_num;
    [SerializeField] float h_x, h_y;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(hige[h_num], new Vector3(h_x, h_y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}