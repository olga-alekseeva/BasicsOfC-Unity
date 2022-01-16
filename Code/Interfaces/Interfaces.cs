using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    //список задействованных интерфейсов
    public interface IController { }
    public interface ILogicUpdatable { void LogicUpdate(float delta); }
    public interface IPhysicsUpdatable { void PhysicsUpdate(float delta); }
    public interface ILateUpdatable { void LateUpdate(float delta); }
    public interface IFactory<T> { T Create(); }
}