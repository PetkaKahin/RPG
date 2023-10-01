using Unit;
using Zenject;

namespace Installers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInput>().To<ClassicInput>().AsSingle().NonLazy();
        }
    }
}
