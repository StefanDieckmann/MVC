using Character;
using LetterGenerator;
using Score;
using UniRx;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        var disposable = new CompositeDisposable();
        Container.BindInstance(disposable).AsSingle();

        CharacterInstaller.Install(Container);
        ScoreInstaller.Install(Container);
        LetterGeneratorInstaller.Install(Container);
    }
}
