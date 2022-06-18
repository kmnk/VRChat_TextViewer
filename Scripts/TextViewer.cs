using UnityEngine;

namespace Kmnk.TextViewer
{
    public class TextViewer : MonoBehaviour
    {
    #pragma warning disable CS0414
        [SerializeField]
        [Tooltip("複数の TextViewer を設置する場合に対応する Id を指定します")]
        int _id = 0;

        [SerializeField]
        [Tooltip("読み込むテキストファイルを指定します")]
        TextAsset _textAsset = null;

        [SerializeField]
        [Tooltip("テキストのデフォルトサイズを指定します")]
        int _textSize = 48;

        [SerializeField]
        [Tooltip("テキストのデフォルトカラーを指定します")]
        Color32 _textColor = Color.white;
    #pragma warning restore CS0414
    }
}