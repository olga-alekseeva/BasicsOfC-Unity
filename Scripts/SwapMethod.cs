using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMethod : MonoBehaviour
{
    public int A;
    public int B;
    private void Start()
    {
        Swap(ref A, ref B);
    }
    private void Swap(ref int A, ref int B)
    {
        A = A + B;
        B = A - B;
        A = A - B;

        Debug.Log($"A = {A} B = {B}");
        
    }
}
