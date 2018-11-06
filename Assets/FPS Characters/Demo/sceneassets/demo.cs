using UnityEngine;
using UnityEngine.UI;
using System.Collections;

    //Simple Script for Demo scene and is not required for your project

    public class demo : MonoBehaviour
    {

        public int counter = 0;
        public Text speakerName;
        public GameObject[] character;
        bool RLeft = false, RRight = false;

    // Use this for initialization
    void Start()
        {
            if (character.Length > 0)
            {
                speakerName.text = character[counter].transform.name;
            }
        }


        public void next()  // Called by Next Button
        {

            if (counter < character.Length - 1)
            {
                counter++;
                character[counter].SetActive(true);
                character[counter - 1].SetActive(false);
                speakerName.text = character[counter].transform.name;

            }
            else
            {
                character[counter].SetActive(false);
                counter = 0;
                character[counter].SetActive(true);
                speakerName.text = character[counter].transform.name;
            }
        }

        public void prev() // Called by Previous Button
        {
            if (counter > 0)
            {
                counter--;
                character[counter].SetActive(true);
                character[counter + 1].SetActive(false);
                speakerName.text = character[counter].transform.name;

            }
            else
            {
                character[counter].SetActive(false);
                counter = character.Length - 1;
                character[counter].SetActive(true);
                speakerName.text = character[counter].transform.name;
            }
        }

    public void RotateRight()
    {
        RRight = true;
    }
    public void RotateRightFalse()
    {
        RRight = false;
    }

    public void RotateLeft()
    {
        RLeft = true;
    }
    public void RotateLeftFalse()
    {
        RLeft = false;
    }

    void Update()
    {
        if(RLeft)
        {
            character[counter].transform.Rotate(Vector3.up * 3);
        }
        if (RRight)
        {
            character[counter].transform.Rotate(Vector3.down * 3);
        }
    }

}
