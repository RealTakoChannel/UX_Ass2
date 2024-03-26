using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operate : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;


    public void MoveLeft()
    {
        float x = human.transform.position.x;
        float y = human.transform.position.y;
        float z = human.transform.position.z;
        human.transform.position = new Vector3(x-1f,y, z);
    }
    public void MoveRight()
    {
        float x = human.transform.position.x;
        float y = human.transform.position.y;
        float z = human.transform.position.z;
        human.transform.position = new Vector3(x+1f, y, z);
    }

    public void RotateClockwise() {

        human.transform.Rotate(0, 30f, 0);
    }
    public void RotateCounterClockwise()
    {

        human.transform.Rotate(0, -30f, 0);
    }
    public void Grow()
    {
        human.transform.localScale += sizeChange;
    }
    public void Shrink()
    {
        human.transform.localScale -= sizeChange;
    }
    public void ResetObj()
    {
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = Vector3.one;
    }
}
