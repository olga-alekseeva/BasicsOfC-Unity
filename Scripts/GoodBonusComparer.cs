using RollingBall;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBonusComparer : IComparer<GoodBonus> //класс сортировки объектов по количеству бонусных очков
{
    public int Compare(GoodBonus x, GoodBonus y)
    {
        if (x.Point < y.Point)
        {
            return 1;
        }

        if (x.Point > y.Point)
        {
            return -1;
        }

        return 0;
    }

}
