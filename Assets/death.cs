using UnityEngine;
using System.Collections;

namespace bumper
{
    public class death : MonoBehaviour
    {

        public GameObject player;
       public static bool dead = false;

        //Once player enters Trigger
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                dead = true;
                Destroy(player);
            }
        }
    }
}
