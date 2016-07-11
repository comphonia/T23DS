using UnityEngine;
using UnityEngine.Events;
using System.Collections;



namespace T23DS
{
    [RequireComponent(typeof(AudioSource))]

    public class textTo3dSpeech : MonoBehaviour
    {
        [Tooltip("Add the speaker gameObject")]
        public GameObject speaker;
        public string alphabet;
        public AudioClip alphabetSound;

        public UnityEvent onFinishedPlaying;

        private GameObject faceGo;
        private GameObject teethGo;
        private bool isSpeaking = true;

        SkinnedMeshRenderer faceblend;
        SkinnedMeshRenderer teethblend;
       


        void Start ()
        {
            faceGo = speaker.transform.Find("Body").gameObject; 
            teethGo = speaker.transform.Find("TeethDown").gameObject;
            faceblend = faceGo.GetComponent<SkinnedMeshRenderer> (); //Gets Body child object to access its blendshapes
            teethblend = teethGo.GetComponent<SkinnedMeshRenderer>(); //Gets TeethDown child object to access its blendshapes
            blinker(); //runs blinker function once game is played  
        }

        //Use this to start speaking
        public void StartSpeaking()
        {   
            if (isSpeaking == true) //Prevents overlapping couroutines
            {
                char[] temp = split();
                switchStarter(temp);
                isSpeaking = false;
            }
            else { }
        }

        //Use this to stop speaking
        public void StopSpeaking ()
        {
            char[] temp = split();
            switchStopper(temp);
            isSpeaking = true;
        }


        private void switchStarter(char[] temp)
        {
            StartCoroutine(alphaswitch(temp));
            if (alphabetSound != null)
            {
                GetComponent<AudioSource>().PlayOneShot(alphabetSound);
            }
        }

        private void switchStopper(char[] temp)
        {
            StopAllCoroutines();
            GetComponent<AudioSource>().Stop();
            blendset();
            blinker();
        }

        //converts typed alphabet to uppercase, get them as single characters and is checked in the comboswitch function's switch statement
        char[] split()
        {
            string text = alphabet.Replace(" ", "").ToUpper() + '/';
            char[] arr;
            arr = text.ToCharArray();
            return arr;
        }

       
        //Blendshapes set for alphabets
        private IEnumerator alphaswitch(char[] temp)
        {
            foreach (char combo in temp)
            {
                switch (combo)
                {
                    case 'A':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;     

                    case 'B':
                        faceblend.SetBlendShapeWeight(10, 100);
                        faceblend.SetBlendShapeWeight(11, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 100);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'C':
                        faceblend.SetBlendShapeWeight(6, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 50);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'D':
                        faceblend.SetBlendShapeWeight(1, 40);
                        faceblend.SetBlendShapeWeight(25, 30);
                        faceblend.SetBlendShapeWeight(26, 30);
                        teethblend.SetBlendShapeWeight(1, 60);
                        teethblend.SetBlendShapeWeight(12, 20);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'E':
                        faceblend.SetBlendShapeWeight(6, 100);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'F':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(7, 100);
                        faceblend.SetBlendShapeWeight(23, 100);
                        faceblend.SetBlendShapeWeight(24, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'G':
                        faceblend.SetBlendShapeWeight(12, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 100);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'H':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(9, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'I':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(3, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'J':
                        faceblend.SetBlendShapeWeight(12, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'K':
                        faceblend.SetBlendShapeWeight(12, 60);
                        faceblend.SetBlendShapeWeight(30, 40);
                        faceblend.SetBlendShapeWeight(31, 40);
                        teethblend.SetBlendShapeWeight(23, 60);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'L':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 40);
                        teethblend.SetBlendShapeWeight(1, 100);
                        teethblend.SetBlendShapeWeight(13, 80);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                   case 'M':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(21, 100);
                        faceblend.SetBlendShapeWeight(38, 20);
                        faceblend.SetBlendShapeWeight(39, 20);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'N':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.02f);
                        blendset();
                        faceblend.SetBlendShapeWeight(13, 50);
                        faceblend.SetBlendShapeWeight(14, 50);
                        faceblend.SetBlendShapeWeight(26, 50);
                        faceblend.SetBlendShapeWeight(36, 50);
                        teethblend.SetBlendShapeWeight(1, 100);
                        teethblend.SetBlendShapeWeight(6, 60);
                        teethblend.SetBlendShapeWeight(12, 70);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'O':
                        faceblend.SetBlendShapeWeight(4, 100);
                        teethblend.SetBlendShapeWeight(2, 100);
                        teethblend.SetBlendShapeWeight(13, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'P':
                        faceblend.SetBlendShapeWeight(21, 100);
                        faceblend.SetBlendShapeWeight(38, 20);
                        faceblend.SetBlendShapeWeight(39, 20);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 100);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'Q':
                        faceblend.SetBlendShapeWeight(12, 60);
                        faceblend.SetBlendShapeWeight(30, 40);
                        faceblend.SetBlendShapeWeight(31, 40);
                        teethblend.SetBlendShapeWeight(23, 60);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(5, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'R':
                        faceblend.SetBlendShapeWeight(0, 100);
                        teethblend.SetBlendShapeWeight(12, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 80);
                        teethblend.SetBlendShapeWeight(1, 80);
                        teethblend.SetBlendShapeWeight(10, 60);
                        teethblend.SetBlendShapeWeight(12, 80);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'S':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'T':
                        faceblend.SetBlendShapeWeight(1, 30);
                        teethblend.SetBlendShapeWeight(12, 15);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 80);
                        teethblend.SetBlendShapeWeight(24, 40);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'U':
                        faceblend.SetBlendShapeWeight(6, 100);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(5, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'V':
                        faceblend.SetBlendShapeWeight(36, 80);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(7, 100);
                        faceblend.SetBlendShapeWeight(15, 100);
                        faceblend.SetBlendShapeWeight(16, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'W':
                        faceblend.SetBlendShapeWeight(1, 40);
                        faceblend.SetBlendShapeWeight(25, 30);
                        faceblend.SetBlendShapeWeight(26, 30);
                        teethblend.SetBlendShapeWeight(1, 60);
                        teethblend.SetBlendShapeWeight(12, 20);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(4, 80);
                        teethblend.SetBlendShapeWeight(13, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(10, 100);
                        faceblend.SetBlendShapeWeight(11, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 40);
                        teethblend.SetBlendShapeWeight(1, 100);
                        teethblend.SetBlendShapeWeight(13, 80);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(5, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'X':
                        faceblend.SetBlendShapeWeight(0, 30);
                        teethblend.SetBlendShapeWeight(12, 40);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 100);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'Y':
                        faceblend.SetBlendShapeWeight(5, 100);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(0, 50);
                        teethblend.SetBlendShapeWeight(12, 50);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 50);
                        teethblend.SetBlendShapeWeight(14, 30);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case 'Z':
                        faceblend.SetBlendShapeWeight(26, 20);
                        faceblend.SetBlendShapeWeight(30, 50);
                        faceblend.SetBlendShapeWeight(31, 50);
                        yield return new WaitForSeconds(0.09f);
                        blendset();
                        faceblend.SetBlendShapeWeight(6, 50);
                        teethblend.SetBlendShapeWeight(24, 60);
                        yield return new WaitForSeconds(0.5f);
                        blendset();
                        break;

                    case '/':
                        isSpeaking = true;
                        GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(1);
                        onFinishedPlaying.Invoke();
                        break;

                    default:
                        print("none");
                        break;
                       

                }
            }
        }

        //Resets the blendshapes
        private void blendset()
        {
            //Set the face blendshapes to 0

            faceblend.SetBlendShapeWeight(0, 0);
            faceblend.SetBlendShapeWeight(1, 0);
            faceblend.SetBlendShapeWeight(2, 0);
            faceblend.SetBlendShapeWeight(3, 0);
            faceblend.SetBlendShapeWeight(4, 0);
            faceblend.SetBlendShapeWeight(5, 0);
            faceblend.SetBlendShapeWeight(6, 0);
            faceblend.SetBlendShapeWeight(7, 0);
            faceblend.SetBlendShapeWeight(8, 0);
            faceblend.SetBlendShapeWeight(9, 0);
            faceblend.SetBlendShapeWeight(10, 0);
            faceblend.SetBlendShapeWeight(11, 0);
            faceblend.SetBlendShapeWeight(12, 0);
            faceblend.SetBlendShapeWeight(13, 0);
            faceblend.SetBlendShapeWeight(14, 0);
            faceblend.SetBlendShapeWeight(15, 0);
            faceblend.SetBlendShapeWeight(16, 0);
            faceblend.SetBlendShapeWeight(17, 0);
            faceblend.SetBlendShapeWeight(18, 0);
            faceblend.SetBlendShapeWeight(19, 0);
            faceblend.SetBlendShapeWeight(20, 0);
            faceblend.SetBlendShapeWeight(21, 0);
            faceblend.SetBlendShapeWeight(22, 0);
            faceblend.SetBlendShapeWeight(23, 0);
            faceblend.SetBlendShapeWeight(24, 0);
            faceblend.SetBlendShapeWeight(25, 0);
            faceblend.SetBlendShapeWeight(26, 0);
            faceblend.SetBlendShapeWeight(27, 0);
            faceblend.SetBlendShapeWeight(28, 0);
            faceblend.SetBlendShapeWeight(29, 0);
            faceblend.SetBlendShapeWeight(30, 0);
            faceblend.SetBlendShapeWeight(31, 0);
            faceblend.SetBlendShapeWeight(32, 0);
            faceblend.SetBlendShapeWeight(33, 0);
            faceblend.SetBlendShapeWeight(34, 0);
            faceblend.SetBlendShapeWeight(35, 0);
            faceblend.SetBlendShapeWeight(36, 0);
            faceblend.SetBlendShapeWeight(37, 0);
            faceblend.SetBlendShapeWeight(38, 0);
            faceblend.SetBlendShapeWeight(39, 0);
            faceblend.SetBlendShapeWeight(40, 0);
            faceblend.SetBlendShapeWeight(41, 0);
            faceblend.SetBlendShapeWeight(42, 0);
            faceblend.SetBlendShapeWeight(43, 0);
            faceblend.SetBlendShapeWeight(44, 0);
            faceblend.SetBlendShapeWeight(47, 0);
            faceblend.SetBlendShapeWeight(48, 0);
            faceblend.SetBlendShapeWeight(49, 0);
            faceblend.SetBlendShapeWeight(50, 0);
            faceblend.SetBlendShapeWeight(53, 0);
            faceblend.SetBlendShapeWeight(54, 0);
            faceblend.SetBlendShapeWeight(55, 0);
            faceblend.SetBlendShapeWeight(56, 0);
            faceblend.SetBlendShapeWeight(57, 0);
            faceblend.SetBlendShapeWeight(58, 0);
            faceblend.SetBlendShapeWeight(59, 0);
            faceblend.SetBlendShapeWeight(60, 0);
            faceblend.SetBlendShapeWeight(61, 0);
            faceblend.SetBlendShapeWeight(62, 0);
            faceblend.SetBlendShapeWeight(63, 0);
            faceblend.SetBlendShapeWeight(64, 0);

            //Set the teeth blendshapes to 0

            teethblend.SetBlendShapeWeight(0, 0);
            teethblend.SetBlendShapeWeight(1, 0);
            teethblend.SetBlendShapeWeight(2, 0);
            teethblend.SetBlendShapeWeight(3, 0);
            teethblend.SetBlendShapeWeight(4, 0);
            teethblend.SetBlendShapeWeight(5, 0);
            teethblend.SetBlendShapeWeight(6, 0);
            teethblend.SetBlendShapeWeight(7, 0);
            teethblend.SetBlendShapeWeight(8, 0);
            teethblend.SetBlendShapeWeight(9, 0);
            teethblend.SetBlendShapeWeight(10, 0);
            teethblend.SetBlendShapeWeight(11, 0);
            teethblend.SetBlendShapeWeight(12, 0);
            teethblend.SetBlendShapeWeight(13, 0);
            teethblend.SetBlendShapeWeight(14, 0);
            teethblend.SetBlendShapeWeight(15, 0);
            teethblend.SetBlendShapeWeight(16, 0);
            teethblend.SetBlendShapeWeight(17, 0);
            teethblend.SetBlendShapeWeight(18, 0);
            teethblend.SetBlendShapeWeight(19, 0);
            teethblend.SetBlendShapeWeight(20, 0);
            teethblend.SetBlendShapeWeight(21, 0);
            teethblend.SetBlendShapeWeight(22, 0);
            teethblend.SetBlendShapeWeight(23, 0);
            teethblend.SetBlendShapeWeight(24, 0);
            teethblend.SetBlendShapeWeight(25, 0);
            teethblend.SetBlendShapeWeight(26, 0);
            teethblend.SetBlendShapeWeight(27, 0);
            teethblend.SetBlendShapeWeight(28, 0);
            teethblend.SetBlendShapeWeight(29, 0);
            teethblend.SetBlendShapeWeight(30, 0);


        }

        //Runs the couroutine blink()  
        private void blinker()
        {
            StartCoroutine(blink());
        }

        //Blinking on average happens every 4 seconds
        private IEnumerator blink()
        {
            yield return new WaitForSeconds(4); //seconds before character blinks
            faceblend.SetBlendShapeWeight(45, 100);
            faceblend.SetBlendShapeWeight(46, 100);
            faceblend.SetBlendShapeWeight(51, 100);
            faceblend.SetBlendShapeWeight(52, 100);
            yield return new WaitForSeconds(0.1f); //Eye closes when the blendshapes are set to 0 then after 0.1f seconds they open(0) to simulate blinking
            faceblend.SetBlendShapeWeight(45, 0);
            faceblend.SetBlendShapeWeight(46, 0);
            faceblend.SetBlendShapeWeight(51, 0);
            faceblend.SetBlendShapeWeight(52, 0);
            blinker(); //Runs the blink couroutine again
        }

    }
}
