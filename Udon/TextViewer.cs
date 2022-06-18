
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

namespace Kmnk.TextViewer.Udon
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class TextViewer : UdonSharpBehaviour
    {
        [SerializeField]
        TextAsset _textAsset = null;

        [SerializeField]
        Text _text = null;

        void Start()
        {
            _text.text = _textAsset.text;
        }
    }
}