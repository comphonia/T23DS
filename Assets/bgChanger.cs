using UnityEngine;
using System.Collections;

namespace bumper
{
    public class bgChanger : MonoBehaviour
    {

        public Color dcolor;
        public Color[] color;
     

        SpriteRenderer renderer;

        // Use this for initialization
        void Start()
        {
            renderer = GetComponent<SpriteRenderer>();
            int t = Random.Range(0, color.Length);
            renderer.color = color[t];
        }

        void Update()
        {

            if (death.dead == true)
            {
                renderer.color = dcolor;
            }
        }
    }
}
