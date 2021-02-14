using Character;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        CharacterInstaller.Install(Container);
    }
}
