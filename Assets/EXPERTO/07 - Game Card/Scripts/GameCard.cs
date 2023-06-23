using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Renderer))]
public class GameCard : MonoBehaviour
{
    [Header("Card Data")]
    [SerializeField] private GameCardSO _data;

    [Header("References")]
    [SerializeField] private TextMeshPro _titleTxt;
    [SerializeField] private TextMeshPro _levelTxt;
    [SerializeField] private TextMeshPro _typeTxt;
    [SerializeField] private TextMeshPro _descriptionTxt;
    [SerializeField] private TextMeshPro _statsTxt;

    private MaterialPropertyBlock _propertyBlock;

    private void Start()
    {
        _propertyBlock = new MaterialPropertyBlock();
        InitData();
    }

    [ContextMenu("Update Data")]
    private void InitData() 
    {
        //title
        _titleTxt.text = _data.title;

        //level
        _levelTxt.text = _data.GetLevel();

        //type
        _typeTxt.text = $"({_data.GetTypes()})";

        //description
        _descriptionTxt.text = _data.description;

        //Stats
        _statsTxt.text = $"ATK/{_data.statAttack}   DEF/{_data.statDefense}";

        //Material
        _propertyBlock.SetColor("_Color", _data.color);
        _propertyBlock.SetTexture("_Texture_Content", _data.texture);
        _propertyBlock.SetFloat("_Is_Holographic", _data.isHolographic ? 1 : 0);

        GetComponent<Renderer>().SetPropertyBlock(_propertyBlock);
    }

}
