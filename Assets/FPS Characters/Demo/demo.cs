using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace T23DS
{
    //Simple Script for Demo scene and is not required for your project

    public class demo : MonoBehaviour
    {

        public int counter = 0;
        public Text CharacterName;
        public GameObject[] character;
        private textTo3dSpeech t23ds;

        // Use this for initialization
        void Start()
        {
            if (character.Length > 0)
            {
                CharacterName.text = character[counter].transform.name;
            }
        }

        void Update()
        {
            if (character.Length > 0)
            {
                t23ds = character[counter].GetComponent<textTo3dSpeech>();
            }
        }

        public void next()  // Called by Next Button
        {

            if (counter < character.Length - 1)
            {
                counter++;
                character[counter].SetActive(true);
                character[counter - 1].SetActive(false);
                CharacterName.text = character[counter].transform.name;

            }
            else
            {
                character[counter].SetActive(false);
                counter = 0;
                character[counter].SetActive(true);
                CharacterName.text = character[counter].transform.name;
            }
        }

        public void prev() // Called by Previous Button
        {
            if (counter > 0)
            {
                counter--;
                character[counter].SetActive(true);
                character[counter + 1].SetActive(false);
                CharacterName.text = character[counter].transform.name;

            }
            else
            {
                character[counter].SetActive(false);
                counter = character.Length - 1;
                character[counter].SetActive(true);
                CharacterName.text = character[counter].transform.name;
            }
        }

    }
}
