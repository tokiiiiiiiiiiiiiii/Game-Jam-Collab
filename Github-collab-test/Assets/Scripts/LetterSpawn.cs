using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawn : MonoBehaviour
{
    public GameObject[] Blocks;
    public static int width = 6;
    public static int height = 6;
    private static Transform[,] grid = new Transform[width, height];

    

    // Start is called before the first frame update
    void Start()
    {
        ArrayLetters();

        
    }

    // Update is called once per frame
    void Update()
    {
        //盤面リセット
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
            ArrayLetters();
        }

    }


    void ArrayLetters()
    {
        int pointx = Random.Range(0, width);
        int pointy = Random.Range(0, height);
        Debug.Log("X:" + pointx + ",Y:" + pointy);
        if (!HairExist())
        {


            //Destroy(grid[pointx, pointy].gameObject);
            //grid[pointx, pointy] = null;

            Instantiate(Blocks[0], new Vector3(pointx, pointy, 0), Quaternion.identity);

        }
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (i == pointx && j == pointy)
                {
                    continue;
                }
                else if (grid[i, j] == null)
                {
                    SpawnBlock(i, j);
                }


            }
        }
    }

    //毛ブロックの存在確認
    bool HairExist()
    {
        if (GameObject.Find("Square1")){
            return true;
        }
        return false;
    }

    void SpawnBlock(int i, int j)
    {
        Instantiate(Blocks[Random.Range(0, Blocks.Length)], new Vector3(i,j,0), Quaternion.identity);
    }


    public void Reset()
    {
        GameObject[] Letters = GameObject.FindGameObjectsWithTag("Letter");
        foreach (GameObject Letter in Letters)
        {
            Destroy(Letter);
        }


    }
}


