using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{
    public Texture2D texture;
    public Vector2Int textureSize = new Vector2Int(x:2048, y:2048);

    void Start()
    {
        var r = GetComponent<Renderer>();
        texture = new Texture2D(width:(int)textureSize.x, height:(int)textureSize.y);
        r.material.mainTexture = texture;
    }
}
