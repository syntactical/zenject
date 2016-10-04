using UnityEngine;
using Zenject;
using System.Collections;

public class TestInstaller : MonoInstaller<TestInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<ITickable>().To<TestLoggerScript>().AsSingle();
        Container.Bind<TestLoggerScript>();
    }
}