using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Text_UI : MonoBehaviour
{
    [TextArea(3,4)]public string text;

    private string _lastFrameText;
    private List<TextMeshProUGUI> _tmpTexts;

    private void OnEnable()
    {
        try
        {
            _tmpTexts = new List<TextMeshProUGUI>(GetComponentsInChildren<TextMeshProUGUI>());
        }
        catch
        {
            Debug.Log("Error");
        }
    }
    void Update()
    {
        if (HasTextChanged())
        {
            UpdateSpriteTexts();
        }
    }

    bool HasTextChanged()
    {
        bool textChanged = false;

        if (text != _lastFrameText)
        {
            textChanged = true;
        }

        _lastFrameText = text;

        return textChanged;
    }


    void UpdateSpriteTexts()
    {
        foreach (var tmpText in _tmpTexts)
        {
            tmpText.text = text;
            UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(tmpText);
        }
    }
}
