using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCamera : MonoBehaviour
{
    public Transform Hero;
    public Texture2D bshLogo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Hero.position.x - 4, Hero.position.y + 2, transform.position.z);
    }

    private void OnGUI()
    {
        if(bshLogo)
            GUI.DrawTexture(new Rect(10, 10, 80, 90), bshLogo, ScaleMode.StretchToFill, true);
    }
}
