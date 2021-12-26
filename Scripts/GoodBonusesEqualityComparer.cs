using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public sealed class GoodBonusesEqualityComparer : IEqualityComparer<GoodBonus> //интерфейс позвол€ет реализовать настраиваемое сравнение на равенство дл€ коллекций.
                                                                                   //“о есть можно создать собственное определение равенства дл€ типа T

    {
        public bool Equals(GoodBonus x, GoodBonus y) => x.Point == y.Point;

        public int GetHashCode(GoodBonus obj) => obj.Point.GetHashCode();

    }
}