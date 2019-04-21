using UnityEngine;
using Zenject;

public class SetupInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<DiagnosticsManager>().AsSingle();
        Container.Bind<UIManager>().AsSingle();
    }
}