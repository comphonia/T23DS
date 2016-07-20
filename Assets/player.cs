using UnityEngine;
using System.Collections;

namespace bumper
{
    public class player : MonoBehaviour {

        public Rigidbody2D rb;
        public GameObject Bumper;
        public float thrust;
        private bool active = false;
        private bool cooldown = true;
        private bool dead = false;
        int i = 0;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
           
        }


        IEnumerator delay()
        {
            yield return new WaitForSeconds(0.1f);
            active = false;
            yield return new WaitForSeconds(0.3f);
            cooldown = false;
        }

        public void pressed()
        {


                if (i == 0)
                {
                Vector3 dir = Quaternion.AngleAxis(95, Vector3.up) * Vector3.up;

                rb.isKinematic = false;
                    rb.GetComponent<Rigidbody2D>().AddForce(dir * thrust);
                StartCoroutine(delay());
                i += 1;
            }

                if (cooldown == false)
                {
                    active = true;
                    cooldown = true;
                    StartCoroutine(delay());
                }
        }

        void Update()
        {
            if (active == true)
            {
                Bumper.SetActive(true);
            }
            if (active == false)
            {
                Bumper.SetActive(false);
            }
        }

        public void restart()
        {
            Application.LoadLevel("Bumper");
        }
    }
}
