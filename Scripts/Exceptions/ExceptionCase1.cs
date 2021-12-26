using RollingBall;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionCase1 : MonoBehaviour
{
    public Player Player;
    void Start()
    {
        try
        {
            Player = Object.FindObjectOfType<Player>();
            if (Player == null)
            
                throw new MyException("игрок отсутствует на сцене");
            Debug.Log("игрок есть");
        }
        catch(MyException e)
        {
            Debug.Log($"{e.Message}");
        }
    }

    
}
