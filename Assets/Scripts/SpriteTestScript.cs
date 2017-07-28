using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteTestScript : MonoBehaviour {
    [SerializeField]
    Image image;

	// Use this for initialization
	void Start () {
        Debug.Log( image.sprite.texture.name);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
