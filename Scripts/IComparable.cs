using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public interface IComparable // интерфейс IComparable позвол€ет сравнивать один объект с другим, использу€ различные методы
    { 
        int CompareTo(object obj);
    }
}