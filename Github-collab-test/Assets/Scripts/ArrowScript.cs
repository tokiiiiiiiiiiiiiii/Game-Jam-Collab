using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{

    public GameObject ArrowX;
    public GameObject ArrowY;
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

        //矢印キー位置移動

        if (Input.GetKeyDown(KeyCode.A))
        {
            ArrowX.transform.position += new Vector3(-1, 0, 0);
            if (!ValidMove())
            {
                ArrowX.transform.position -= new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ArrowX.transform.position += new Vector3(1, 0, 0);
            if (!ValidMove())
            {
                ArrowX.transform.position -= new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ArrowY.transform.position += new Vector3(0, 1, 0);
            if (!ValidMove())
            {
                ArrowY.transform.position -= new Vector3(0, 1, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ArrowY.transform.position += new Vector3(0, -1, 0);
            if (!ValidMove())
            {
                ArrowY.transform.position -= new Vector3(0, -1, 0);
            }
        }


        //文字ブロック回転





        bool ValidMove()//矢印がプレイ範囲外に出ないようにする関数
        {

            int roundedX = Mathf.RoundToInt(ArrowX.transform.position.x);
            int roundedY = Mathf.RoundToInt(ArrowY.transform.position.y);

            //テトロミノが負の座標に行こうとする、または、プレイ範囲を越えようとする時、falseを返す
            if (roundedX < 0 || roundedX >= width || roundedY < 0 || roundedY >= height)
            {
                return false;
            }
            /*if (grid[roundedX, roundedY] != null)
            {
                return false;
            }*/

            return true;
        }
    }
}
