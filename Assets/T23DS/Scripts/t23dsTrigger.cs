using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace T23DS
{
    public class t23dsTrigger : MonoBehaviour
    {
        public float delaytime;
        public UnityEvent onTriggerEnter;

        public IEnumerator delay()
        {
            yield return new WaitForSeconds(delaytime);
            onTriggerEnter.Invoke();
        }

        void OnTriggerEnter(Collider other)
        {
            StartCoroutine(delay());
        }



    }
}