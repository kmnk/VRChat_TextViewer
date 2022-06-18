using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

using Kmnk.Core;

namespace Kmnk.TextViewer
{
    [CustomEditor(typeof(TextViewer))]
    class TextViewerEditor : EditorBase<TextViewer>
    {
        SerializedProperty _textAssetProperty;
        SerializedProperty _textSizeProperty;
        SerializedProperty _textColorProperty;

        protected override void FindProperties()
        {
            _target = target as TextViewer;
            _textAssetProperty = serializedObject.FindProperty("_textAsset");
            _textSizeProperty = serializedObject.FindProperty("_textSize");
            _textColorProperty = serializedObject.FindProperty("_textColor");
        }

        protected override void LayoutGUI()
        {
            using (new GUILayout.VerticalScope(GUI.skin.box))
            {
                EditorGUILayout.LabelField("Core", BoxTitleStyle());
                EditorGUILayout.PropertyField(_textAssetProperty);
            }

            EditorGUILayout.Space();

            using (new GUILayout.VerticalScope(GUI.skin.box))
            {
                EditorGUILayout.LabelField("Option", BoxTitleStyle());
                EditorGUILayout.PropertyField(_textSizeProperty);
                EditorGUILayout.PropertyField(_textColorProperty);
            }
        }

        internal override void ApplyModifiedProperties()
        {
            FindProperties();

            var udon = _target.GetChildUdonBehaviour<Udon.TextViewer>();
            udon.SetPublicVariable("_textAsset", _textAssetProperty.objectReferenceValue as TextAsset);
            udon.GetComponentInChildren<Text>().fontSize = _textSizeProperty.intValue;
            udon.GetComponentInChildren<Text>().color = _textColorProperty.colorValue;
        }
    }
}