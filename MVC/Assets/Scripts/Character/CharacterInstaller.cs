using UniRx;
using Zenject;

namespace Character
{
    public class CharacterInstaller : Installer<CharacterInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<CharacterView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<CharacterModel>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<CharacterController>().AsSingle().NonLazy();
        }
    }
}