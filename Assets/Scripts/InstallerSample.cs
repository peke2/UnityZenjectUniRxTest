using System;
using Zenject;

public class InstallerSample : MonoInstaller<InstallerSample> {
    public override void InstallBindings()
    {
        //base.InstallBindings();
        Container.Bind<ZenjectSample>().AsSingle();
        Container.Bind<IInitializable>().To<ZenjectSample>().FromResolve();
        Container.Bind<IDisposable>().To<ZenjectSample>().FromResolve();
    }
}
