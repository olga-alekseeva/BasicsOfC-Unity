using System.Collections.Generic;

namespace RollABall
{
    //хранилище контроллеров, котрые будет обновлять GameController
    public sealed class ControllersRepository : ILogicUpdatable, IPhysicsUpdatable, ILateUpdatable
    {
        private readonly List<ILogicUpdatable> _logicUpdatables;
        private readonly List<IPhysicsUpdatable> _physicsUpdatables;
        private readonly List<ILateUpdatable> _lateUpdatebles;


        public ControllersRepository()//инициализация
        {
            _logicUpdatables = new List<ILogicUpdatable>();
            _physicsUpdatables = new List<IPhysicsUpdatable>();
            _lateUpdatebles = new List<ILateUpdatable>();
        }

        public void Add(IController controller) //метод, ограничивающий добавление контроллеров
        {
            if (controller is ILogicUpdatable logicUpdatable) _logicUpdatables.Add(logicUpdatable);
            if (controller is IPhysicsUpdatable physicsUpdatable) _physicsUpdatables.Add(physicsUpdatable);
            if (controller is ILateUpdatable lateUpdatable) _lateUpdatebles.Add(lateUpdatable);

        }

        public void Remove(IController controller) //удаление ненужных контроллеров
        {
            if (controller is ILogicUpdatable logicUpdatable) _logicUpdatables.Remove(logicUpdatable);
            if (controller is IPhysicsUpdatable physicsUpdatable) _physicsUpdatables.Remove(physicsUpdatable);
            if (controller is ILateUpdatable lateUpdatable) _lateUpdatebles.Remove(lateUpdatable);
        }

        public void CleanUp() //обнуление всех списков
        {
            _logicUpdatables.Clear();
            _physicsUpdatables.Clear();
            _lateUpdatebles.Clear();
        }

        public void LogicUpdate(float delta)
        {
            foreach (var updatable in _logicUpdatables)
            {
                updatable.LogicUpdate(delta);
            }
        }

        public void PhysicsUpdate(float delta)
        {
            foreach (var updatable in _physicsUpdatables)
            {
                updatable.PhysicsUpdate(delta);
            }
        }

        public void LateUpdate(float delta)
        {
            foreach (var updatable in _lateUpdatebles)
            {
                updatable.LateUpdate(delta);
            }
        }
    }
}