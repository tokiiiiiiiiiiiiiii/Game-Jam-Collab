using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum
public class LetterBlock : MonoBehaviour



{
    public static int width = 6;
    public static int height = 6;
    private static Transform[,] grid = new Transform[width, height];
    
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
       
        GameObject ArwX = FindObjectOfType<ArrowScript>().ArrowX;
        GameObject ArwY = FindObjectOfType<ArrowScript>().ArrowY;


      /*  Vector3 camPos = FindObjectOfType<Camera>().transform.position;

        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("")
        
        for(int i = 0; i < 36; i++)
        {

            
        }

        

        int camX = 6;
        int camY = 2;
        
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(this.transform.position);
                RaycastHit2D hit = Physics2D.Raycast(camPos, pos, 100);
                pos.z = 100;
                // 可視化
                Debug.Log(pos);
                Debug.DrawRay(camPos, pos, Color.blue, 1);

            }
        }
        */








        //文字ブロック回転
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (this.transform.position.x == ArwX.transform.position.x) {
                this.transform.position += new Vector3(0, 1, 0);
                if (!LetterValidMove())
                {
                    this.transform.position -= new Vector3(0, 6, 0);
                }
            }




        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (this.transform.position.x == ArwX.transform.position.x)
            {
                this.transform.position += new Vector3(0, -1, 0);
                if (!LetterValidMove())
                {
                    this.transform.position -= new Vector3(0, -6, 0);
                }
            }

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.transform.position.y == ArwY.transform.position.y)
            {
                this.transform.position += new Vector3(-1, 0, 0);
                if (!LetterValidMove())
                {
                    this.transform.position -= new Vector3(-6, 0, 0);
                }
            }

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.transform.position.y == ArwY.transform.position.y)
            {
                this.transform.position += new Vector3(1, 0, 0);
                if (!LetterValidMove())
                {
                    this.transform.position -= new Vector3(6, 0, 0);
                }
            }
        }

        


    }
   





    void AddToGrid()
    {
        int roundedX = Mathf.RoundToInt(transform.position.x);//テトロミノのグローバルx座標(整数値)を取得
        int roundedY = Mathf.RoundToInt(transform.position.y);//テトロミノのグローバルy座標(整数値)を取得

        
    }

    bool LetterValidMove()
    {
        int roundedX = Mathf.RoundToInt(this.transform.position.x);
        int roundedY = Mathf.RoundToInt(this.transform.position.y);

        if (roundedX< 0 || roundedX >= width||roundedY< 0 || roundedY >= height)
            {
                return false;

            }
             /*if (grid[roundedX, roundedY] != null)
                {
                return false;
            }*/
        
                return true;
    }
    
    //public int BlockPos()
    //{
    //    Vector3 NowPoint = this.transform.position;
        

    //}

}
