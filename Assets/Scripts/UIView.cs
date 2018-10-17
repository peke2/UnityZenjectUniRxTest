using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UniRx;

public class UIView : MonoBehaviour
{
    [SerializeField]
    Button button;

    [SerializeField]
    Text text;

    public IObservable<string> OnClickObservable()
    {
        return button.OnClickAsObservable().Select(_ => text.text);
    }
}
