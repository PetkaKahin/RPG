using Unit;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerUnit _playerPrefab;
        [SerializeField] private Transform _spawnPoint;

        private IMover _mover;

        public override void InstallBindings()
        {
            PlayerUnit player = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerPrefab, _spawnPoint);

            Container.Bind<PlayerUnit>().FromInstance(player).AsSingle().NonLazy();
        }
    }
}