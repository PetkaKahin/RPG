using Unit;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [Header("Links")]
        [SerializeField] private PlayerUnit _playerPrefab;
        [SerializeField] private Transform _playerSpawnPoint;

        [Header("Options")]
        [SerializeField] private MoverType _moverType;

        public override void InstallBindings()
        {
            BindingMover();

            PlayerUnit player = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerPrefab, _playerSpawnPoint);

            Container.Bind<PlayerUnit>().FromInstance(player).AsSingle().NonLazy();
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