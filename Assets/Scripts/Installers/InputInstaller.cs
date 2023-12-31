﻿using Zenject;

namespace Installers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInput>().To<DescktopInput>().AsSingle().NonLazy();
        }
    }
}
