using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is being used with a 3D GameObject called Quad with a Mesh Renderer
public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 0.5f;
    //The sprite had to be converted to "Texture type: Default" & "Wrap Mode: Repeat" before being applied as a material.
    [SerializeField] Material bgMaterial;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        //this is the material that's been applied to the 3D Quad
        //this material's offset property is being changed via Update to add illusion of movement.
        bgMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0, backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        bgMaterial.mainTextureOffset += (offset * Time.deltaTime);
    }
}
