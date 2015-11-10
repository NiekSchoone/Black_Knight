//Written by Rob Verhoef
using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{
    private float _speed = 0.005f;
    private float _offset;
    private Renderer _renderer;

	void Awake ()
    {
        _renderer = GetComponent<Renderer>();
    }
	
	void Update ()
    {
        _offset += _speed;
        if (_offset > 1.0f)
        {
            _offset -= 1.0f;
            Debug.Log("Scrolling");
        }
        _renderer.material.mainTextureOffset = new Vector2 (_offset, 0);
	}
}
