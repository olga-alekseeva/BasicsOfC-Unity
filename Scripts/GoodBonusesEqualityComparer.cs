using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public sealed class GoodBonusesEqualityComparer : IEqualityComparer<GoodBonus> //��������� ��������� ����������� ������������� ��������� �� ��������� ��� ���������.
                                                                                   //�� ���� ����� ������� ����������� ����������� ��������� ��� ���� T

    {
        public bool Equals(GoodBonus x, GoodBonus y) => x.Point == y.Point;

        public int GetHashCode(GoodBonus obj) => obj.Point.GetHashCode();

    }
}