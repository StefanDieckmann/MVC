using UniRx;
using Zenject;

namespace Score
{
    public class ScoreInstaller : Installer<ScoreInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ScoreView>().FromComponentInHierarchy().AsSingle();
            Container.BindInterfacesAndSelfTo<ScoreModel>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<ScoreController>().AsSingle().NonLazy();
        }
    }
}