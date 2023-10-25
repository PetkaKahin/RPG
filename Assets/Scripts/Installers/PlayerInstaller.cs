using Unit;
using UnityEngine;
using Zenject;
using System;
using Weapon;

namespace Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [Header("Links")]
        [SerializeField] private PlayerUnit _playerPrefab;
        [SerializeField] private Transform _playerSpawnPoint;

        [Header("Configs")]
        [SerializeField] private DashConfig _dashConfig;

        [Header("Options")]
        [SerializeField, Range(1f, 30f)] private float _speed;
        [SerializeField, Range(1f, 100f)] private float _maxHealth;

        private UnitStateMachine _stateMachine;
        private UnitHealth _unitHealth;
        private IMover _unitMover;

        private PlayerUnit _playerUnit;

        public override void InstallBindings()
        {
            BindingConfigs();

            CreatePlayerDependencies();

            _playerUnit = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerPrefab, _playerSpawnPoint);
            Container.Bind<IMovable>().FromInstance(_playerUnit).AsSingle().NonLazy();
            Container.Bind<IDamager>().FromInstance(_playerUnit.Weapon).AsSingle().NonLazy();

            _unitMover = Container.Instantiate<TransformMover>();
            Container.Bind<IMover>().FromInstance(_unitMover).AsSingle().NonLazy();

            Container.Bind<PlayerUnit>().FromInstance(_playerUnit).AsSingle().NonLazy();

            FillingStates();
        }

        private void FillingStates()
        {
            if (_stateMachine == null)
                throw new ArgumentNullException(nameof(_stateMachine));

            IdleState idleState = Container.Instantiate<IdleState>();
            MoveState moveState = Container.Instantiate<MoveState>();
            DashState spurtState = Container.Instantiate<DashState>();
            AttackState attackState = Container.Instantiate<AttackState>();

            _stateMachine.AddState<IdleState>(idleState);
            _stateMachine.AddState<MoveState>(moveState);
            _stateMachine.AddState<DashState>(spurtState);
            _stateMachine.AddState<AttackState>(attackState);

            _stateMachine.SwitchState<IdleState>();
        }

        private void CreatePlayerDependencies()
        {
            _stateMachine = new UnitStateMachine();
            _unitHealth = new UnitHealth(_maxHealth);

            Container.Bind<UnitStateMachine>().FromInstance(_stateMachine).AsTransient().NonLazy();
            Container.Bind<ISwitcherState>().FromInstance(_stateMachine).AsTransient().NonLazy();

            Container.Bind<UnitHealth>().FromInstance(_unitHealth).AsSingle().NonLazy();
        }

        private void BindingConfigs()
        {
            Container.Bind<DashConfig>().FromInstance(_dashConfig).AsSingle().NonLazy();
        }
    }
}