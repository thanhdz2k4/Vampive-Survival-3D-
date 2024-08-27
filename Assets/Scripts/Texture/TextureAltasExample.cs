using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAltasExample : MonoBehaviour
{
    public Texture2D[] atlasTextures; // Assign these in the Unity Inspector
    public Material material;         // Assign the material that will use the atlas

    void Start()
    {
        // Create an atlas and pack textures
        Texture2D atlas = new Texture2D(8192, 8192);
        Rect[] rects = atlas.PackTextures(atlasTextures, 32, 8192, false);

        // Fill in padding
        uPaddingBleed.BleedEdges(atlas, 32, rects, repeatingTextures: true);

        // Apply the atlas to the material
        material.mainTexture = atlas;
    }
}
