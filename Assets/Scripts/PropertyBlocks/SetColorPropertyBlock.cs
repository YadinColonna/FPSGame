using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorPropertyBlock : MonoBehaviour
{
    public Color _setColor;
    public Texture _setTexture;


    public Renderer _myRenderer;

    private MaterialPropertyBlock _propertyBlock;

    public void Start()
    {
        if (_propertyBlock == null)
        {
            _propertyBlock = new MaterialPropertyBlock();
        }
    }

    public void Update()
    {
        _propertyBlock.SetColor("_BaseColor", _setColor);

        if (_setTexture != null)
            _propertyBlock.SetTexture("_BaseMap", _setTexture);

        //_propertyBlock.SetFloat();
        //_propertyBlock.SetInt();
        //_propertyBlock.SetVector();
        //_propertyBlock.SetMatrix();

        _myRenderer.SetPropertyBlock(_propertyBlock);
    }
}
