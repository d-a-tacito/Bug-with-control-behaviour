using Avalonia.Xaml.Interactions.Custom;
using System.Reactive.Disposables;

namespace InputValidationBug.Behaviours;
public class MyShowOnTappedBehavior : ShowOnTappedBehavior
{
    protected override void OnAttachedToVisualTree(CompositeDisposable disposable)
    {
        base.OnAttachedToVisualTree(disposable);
    }

    protected override void OnAttachedToVisualTree()
    {
        base.OnAttachedToVisualTree();
    }

    protected override void OnDetachedFromVisualTree()
    {
        base.OnDetachedFromVisualTree();
    }
}
