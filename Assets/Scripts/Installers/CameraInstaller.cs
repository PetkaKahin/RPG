using Zenject;
using UnityEngine;
using Cinemachine;
using Unit;

namespace Installers
{
    public class CameraInstaller : MonoInstaller
    {
        [SerializeField] private CinemachineVirtualCamera _camera;

        public override void InstallBindings()
        {
            Container.Bind<CinemachineVirtualCamera>().FromInstance(_camera).AsSingle().NonLazy();
        }

        [Inject]
        private void Construct(PlayerUnit player)
        {
            _camera.LookAt = player.transform;
            _camera.Follow = player.transform;
        }
    }
}
