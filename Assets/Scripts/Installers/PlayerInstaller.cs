using Unit;
using UnityEngine;
using Zenject;
using System;

namespace Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [Header("Links")]
        [SerializeField] private PlayerUnit _playerPrefab;
        [SerializeField] private Transform _playerSpawnPoint;

        [Header("Options")]
        [SerializeField] private MoverType _moverType;

        private UnitStateMachine _stateMachine;

        private PlayerUnit _playerUnit;

        public override void InstallBindings()
        {
            _stateMachine = new UnitStateMachine();

            Container.Bind<UnitStateMachine>().FromInstance(_stateMachine).AsTransient().NonLazy();
            Container.Bind<ISwitcherState>().FromInstance(_stateMachine).AsTransient().NonLazy();

            _playerUnit = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerPrefab, _playerSpawnPoint);

            Container.Bind<PlayerUnit>().FromInstance(_playerUnit).AsSingle().NonLazy();
            Container.Bind<IMovable>().FromInstance(_playerUnit).AsSingle().NonLazy();

            FillingStates();
        }

        private void FillingStates()
        {
            if (_stateMachine == null)
                throw new ArgumentNullException(nameof(_stateMachine));

            IdleState idleState = Container.Instantiate<IdleState>();
            MoveState moveState = Container.Instantiate<MoveState>();

            _stateMachine.AddState<IdleState>(idleState);
            _stateMachine.AddState<MoveState>(moveState);

            _stateMachine.SwitchState<IdleState>();
        }

        private void BindingMover()
        {
            switch (_moverType)
            {
                case MoverType.Classic:
                    Container.Bind<IMover>().To<ClassicMover>().AsSingle().NonLazy();
                    return;

                case MoverType.Physical:
                    Container.Bind<IMover>().To<PhysicalMover>().AsSingle().NonLazy();
                    return;
            }
        }
    }
}