using UnityEngine;
using Zenject;
using System.Collections;

public class TestInstaller : MonoInstaller<TestInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<ITickable>().To<TestLoggerScript>().AsSingle();
        Container.Bind<IOtherDependency>().To<OtherDependency>().AsSingle();
        Container.Bind<TestLoggerScript>();

        //Container.Bind<OtherDependency>().To<TestLoggerScript>();
    }
}