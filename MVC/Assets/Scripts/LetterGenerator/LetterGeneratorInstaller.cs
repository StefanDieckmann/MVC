using Zenject;

namespace LetterGenerator
{
    public class LetterGeneratorInstaller : Installer<LetterGeneratorInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<LetterGeneratorModel>().AsSingle().NonLazy();
        }
    }
}