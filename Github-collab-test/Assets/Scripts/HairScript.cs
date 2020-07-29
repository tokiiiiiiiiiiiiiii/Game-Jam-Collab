using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairScript : MonoBehaviour
{
    public static int width = 6;
    public static int height = 6;
    private static Transform[,] grid = new Transform[width, height];

    // Start is called before the first frame update
    void Start()
    {
        CheckWord();
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        //foreach (GameObject go in allObjects) 
        //{
        //    Debug.Log(go.transform.position + " is an active object ");
        //}
        //for (int i =0; i < height; i++)
        //{
        //    for (int j = 0; j < width; j++)
        //    {

        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
    }
    
    void CheckWord()
    {

        //float YellowX = Object.FindObjectOfType<LetterSpawn>().Blocks[1].transform.position.x;
        //float YellowY = FindObjectOfType<LetterSpawn>().Blocks[1].transform.position.y;
        //int ke_x = Mathf.RoundToInt(this.transform.position.x);
        //int ke_y = Mathf.RoundToInt(this.transform.position.y);



        //Debug.Log(YellowX + YellowY);

        //if ((ke_x + 1)== YellowX && ke_y == YellowY)
        //{
        //    Debug.Log("Yes!!");
        //}
        //else
        //{
        //    Debug.Log("No");

        //}


        //GameObject NextToKe = transform.position(1,1,1).gameObject.FindGameObjectWithTag("Letter");
      

        //Debug.Log(FindObjectOfType<LetterBlock>().BlockPos());

    }

}
