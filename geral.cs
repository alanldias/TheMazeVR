using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class geral : MonoBehaviour
{    
    public GameObject even1, even2, even3, even4, even5, keya6;
    public GameObject keya1, keya2, keya3, keya4, keya5, END, keyb6, cube, Final;
    public GameObject keyb1, keyb2, keyb3, keyb4, keyb5, even6;
    public GameObject odd1, odd2, odd3, odd4, odd5, odd6;
    public GameObject status,camera;
    public float tempo = 0.0f;
    private int pontos = 0, min = 0;
    public bool finnished, flageven, flagodd, flagkey, flagFim = false;

    public TextMesh word1, word2, word3, word4, word5, word6;
    public bool flagum, flagdois, flagtres, flagquatro, flagcinco, flagseis, flagultimo;
    public float countdown = 3.0f;



    System.Random random = new System.Random();

    public void Finnished()
    {
        word1.text = " ";
        word2.text = " ";
        word3.text = " ";
        //word4.text = " ";
        //word5.text = " ";
        //word6.text = " ";
        countdown = 8.0f;
        //finnished = true;
    }

    // Use this for initialization
    void Start()
    {
        //startTime = Time.time;
        finnished = false;
        flageven = false;
        flagodd = false;
        flagkey = false;
        flagum = false;
        flagdois = false;
        flagtres = false;
        flagquatro = true;
        flagultimo = false;

        
    }



    // Update is called once per frame
    void Update()
    {
        //tempo += Time.deltaTime;
        //if (tempo >= 60)
        //{
        //    tempo = 0.0f;
        //    min = min + 1;
        //}
        if (flagFim == false)
        {
            tempo += Time.deltaTime;
            if (tempo >= 60)
            {
                tempo = 0.0f;
                min = min + 1;
            }
            word4.text = "TIME: " + min + ":" + tempo.ToString("F");
            word5.text = "SCORE: " + pontos.ToString();
            countdown -= Time.deltaTime;
        }
        if (min >= 6)
        {
            flagFim = true;
            status.GetComponent<VRLookWalk>().enabled = false;
            word6.text = "The End!";
            word1.text = "Congratulations";
            //passandodados= tempo;
            DontDestroyOnLoad(status);
            SceneManager.LoadScene(1);
        }
        if (flagFim == true)
        {
            word4.text = "TIME: " + min + ":" + tempo.ToString("F");
            word5.text = "SCORE: " + pontos.ToString();
        }
        word4.text = "TIME: " + min + ":" + tempo.ToString("F");
        word5.text = "SCORE: " + pontos.ToString();
        countdown -= Time.deltaTime;
        if (countdown < 0.0f)
        {
            Finnished();
        }

        if (flagultimo == true)
        {
            keya5.SetActive(false);
            keyb5.SetActive(false);
            even5.SetActive(false);
            odd5.SetActive(false);
            Final.SetActive(true);
            word6.text = "Find the FINAL BOX";
        }
    }

    void Termina1()
    {
        //if (flagkey == true && flagum == true)
        //{

        //    keya1.SetActive(false);
        //    keyb1.SetActive(false);
        //    even1.SetActive(false);
        //    odd1.SetActive(false);

        //    even2.SetActive(true);
        //    keya2.SetActive(true);
        //    keyb2.SetActive(true);
        //    odd2.SetActive(true);
        //    flagdois = true;

        //    flagkey = false;
        //    flagodd = false;
        //    flageven = false;
        //    flagum = false;
        //}
        //if (flagkey == true && flagdois == true)
        //{

        //    keya2.SetActive(false);
        //    keyb2.SetActive(false);
        //    even2.SetActive(false);
        //    odd2.SetActive(false);

        //    keya3.SetActive(true);
        //    keyb3.SetActive(true);
        //    even3.SetActive(true);
        //    odd3.SetActive(true);
        //    flagdois = false;
        //    flagtres = true;
        //    flagkey = false;
        //    flagodd = false;
        //    flageven = false;

        //}
        //if (flagkey == true && flagtres == true)
        //{
        //    keya3.SetActive(false);
        //    keyb3.SetActive(false);
        //    even3.SetActive(false);
        //    odd3.SetActive(false);

        //    //keya4.SetActive(true);
        //    //keyb4.SetActive(true);
        //    //even4.SetActive(true);
        //    //odd4.SetActive(true);
        //    flagtres = false;
        //    flagultimo = true;
        //    flagkey = false;
        //    flagodd = false;
        //    flageven = false;
        //    //flagquatro = true;
        //    //flagkey = false;
        //    //flagodd = false;
        //    //flageven = false;
        //}
        if (flagkey == true && flagquatro == true)
        {
            keya4.SetActive(false);
            keyb4.SetActive(false);
            even4.SetActive(false);
            odd4.SetActive(false);

            keya5.SetActive(true);
            keyb5.SetActive(true);
            even5.SetActive(true);
            odd5.SetActive(true);
            flagquatro = false;
            flagcinco = true;
            flagkey = false;
            flagodd = false;
            flageven = false;
        }
        if (flagkey == true && flagcinco == true)
        {
            keya5.SetActive(false);
            keyb5.SetActive(false);
            even5.SetActive(false);
            odd5.SetActive(false);

            keya6.SetActive(true);
            keyb6.SetActive(true);
            even6.SetActive(true);
            odd6.SetActive(true);
            // flagultimo = true;
            flagcinco = false;
            flagseis = true;
            flagkey = false;
            flagodd = false;
            flageven = false;
        }
        if (flagkey == true && flagseis == true)
        {
            //keya5.SetActive(false);
            //keyb5.SetActive(false);
            //even5.SetActive(false);
            //odd5.SetActive(false);

            keya6.SetActive(false);
            keyb6.SetActive(false);
            even6.SetActive(false);
            odd6.SetActive(false);
            flagultimo = true;
            flagkey = false;
            flagodd = false;
            flageven = false;
        }
    }

    private int aleatoriedade(int min, int max)
    {
        return random.Next(min, max);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "even1")
        //{
        //    odd1.GetComponent<AudioSource>().enabled = false;
        //    countdown = 6.0f;
        //    word1.text = "CONDOMINIUM   /ˌkɒn.dəˈmɪn.i.əm/";
        //    word2.text = "APARTMENT   /əˈpɑːt.mənt/";
        //    word3.text = "CASTLE   /ˈkɑː.səl/ ";
        //    even1.GetComponent<AudioSource>().enabled = true;
        //    even1.GetComponent<AudioSource>().Play();
        //    flageven = true;
        //}
        //if (collision.gameObject.tag == "even2")
        //{
        //    odd2.GetComponent<AudioSource>().enabled = false;
        //    even2.GetComponent<AudioSource>().enabled = true;
        //    even2.GetComponent<AudioSource>().Play();
        //    countdown = 7.0f;
        //    word1.text = "POETRY /ˈpəʊ.ɪ.tri/";
        //    word2.text = "PAINTING  /ˈpeɪn.tɪŋ/";
        //    word3.text = "CERAMICS  /səˈræm.ɪks/ ";
        //    flageven = true;
        //}
        //if (collision.gameObject.tag == "even3")
        //{
        //    odd3.GetComponent<AudioSource>().enabled = false;
        //    even3.GetComponent<AudioSource>().enabled = true;
        //    even3.GetComponent<AudioSource>().Play();
        //    countdown = 8.0f;
        //    word1.text = "PERFORMANCE /pəˈfɔː.məns/";
        //    word2.text = "STAGE /steɪdʒ/";
        //    word3.text = "ACTING /ˈæk.tɪŋ/";

        //    flageven = true;
        //}
        if (collision.gameObject.tag == "even4")
        {
            odd4.GetComponent<AudioSource>().enabled = false;
            even4.GetComponent<AudioSource>().enabled = true;
            even4.GetComponent<AudioSource>().Play();
            countdown = 10.0f;
            word1.text = "COUGAR /ˈkuː.ɡə r /";
            word2.text = "CHEETAH /ˈtʃiː.tə/";
            word3.text = "TIGER /ˈtaɪ.ɡə r";

            flageven = true;
        }
        if (collision.gameObject.tag == "even5")
        {
            odd5.GetComponent<AudioSource>().enabled = false;
            even5.GetComponent<AudioSource>().enabled = true;
            even5.GetComponent<AudioSource>().Play();
            countdown = 12.0f;
            word1.text = "PARADE /pəˈreɪd/";
            word2.text = "STREET PARTY /ˈstriːt ˌpɑː.ti/";
            word3.text = "CELEBRATION /ˌsel.əˈbreɪ.ʃ ə n/";

            flageven = true;
        }
        if (collision.gameObject.tag == "even6")
        {
            odd6.GetComponent<AudioSource>().enabled = false;
            even6.GetComponent<AudioSource>().enabled = true;
            even6.GetComponent<AudioSource>().Play();
            countdown = 12.0f;
            word1.text = "HOLIDAY  /ˈhɒl.ə.deɪ/ ";
            word2.text = "CELEBRATION  /ˌsel.əˈbreɪ.ʃən/";
            word3.text = "CHRISTIAN  /ˈkrɪs.tʃən/";

            flageven = true;
        }

        //if (collision.gameObject.tag == "odd1")
        //{
        //    even1.GetComponent<AudioSource>().enabled = false;
        //    odd1.GetComponent<AudioSource>().enabled = true;
        //    odd1.GetComponent<AudioSource>().Play();
        //    flagodd = true;
        //    countdown = 7.0f;
        //    word1.text = "SUMMER  /ˈsʌm.ər/  ";
        //    word2.text = "UNDERGROUND  /ˌʌn.dəˈɡraʊnd/";
        //    word3.text = "BUS  /bʌs/";
        //}
        //if (collision.gameObject.tag == "odd2")
        //{
        //    even2.GetComponent<AudioSource>().enabled = false;
        //    odd2.GetComponent<AudioSource>().enabled = true;
        //    odd2.GetComponent<AudioSource>().Play();
        //    flagodd = true;
        //    countdown = 7.0f;
        //    word1.text = "STRETCHING  /stretʃɪŋ/ ";
        //    word2.text = "TYPING  ˈtaɪ.pɪŋ/";
        //    word3.text = "LEARNING  /ˈlɜː.nɪŋ/";
        //}
        //if (collision.gameObject.tag == "odd3")
        //{
        //    even3.GetComponent<AudioSource>().enabled = false;
        //    odd3.GetComponent<AudioSource>().enabled = true;
        //    odd3.GetComponent<AudioSource>().Play();
        //    flagodd = true;
        //    countdown = 7.0f;
        //    word1.text = "COUGH /kɒf/";
        //    word2.text = "LEARNER /ˈlɜː.nə r /";
        //    word3.text = "TEACHER /ˈtiː.tʃə r /";
        //}
        if (collision.gameObject.tag == "odd4")
        {
            even4.GetComponent<AudioSource>().enabled = false;
            odd4.GetComponent<AudioSource>().enabled = true;
            odd4.GetComponent<AudioSource>().Play();
            flagodd = true;
            countdown = 8.0f;
            word1.text = "MONKEY /ˈmʌŋ.ki/";
            word2.text = "DOG /dɒɡ/";
            word3.text = "BEAR /beə r /";
        }
        if (collision.gameObject.tag == "odd5")
        {
            even5.GetComponent<AudioSource>().enabled = false;
            odd5.GetComponent<AudioSource>().enabled = true;
            odd5.GetComponent<AudioSource>().Play();
            flagodd = true;
            countdown = 8.0f;
            word1.text = "BONFIRE /ˈbɒn.faɪə r /";
            word2.text = "COD /kɒd/";
            word3.text = "CORN /kɔːn/";
        }
        if (collision.gameObject.tag == "odd6")
        {
            even6.GetComponent<AudioSource>().enabled = false;
            odd6.GetComponent<AudioSource>().enabled = true;
            odd6.GetComponent<AudioSource>().Play();
            flagodd = true;
            countdown = 8.0f;
            word1.text = "MARCH   /mɑːtʃ/";
            word2.text = "APRIL  /ˈeɪ.prəl/";
            word3.text = "MONDAY   /ˈmʌn.deɪ/";
        }

        if (collision.gameObject.tag == "rightkey")
        {
            if (flageven == true && flagodd == true)
            {
                cube.GetComponent<AudioSource>().enabled = true;
                cube.GetComponent<AudioSource>().Play();
                countdown = 5.0f;
                word1.text = "|o|.|o|.|o|";
                pontos = pontos + 10;
                flagkey = true;
                Termina1();                
            }
        }
        if (collision.gameObject.tag == "wrongkey")
        {
            if (flageven == true && flagodd == true)
            {
                keyb1.GetComponent<AudioSource>().enabled = true;
                keyb1.GetComponent<AudioSource>().Play();                
                pontos = pontos - 5;
                flagkey = true;
                Termina1();
                
            }
            
        }
        if (collision.gameObject.tag == "Final")
        {
            flagultimo = false;
            flagFim = true;
            status.GetComponent<VRLookWalk>().enabled = false;
            word1.text = "Congratulations";
            word6.text = "The End!";                        
            DontDestroyOnLoad(status);
            SceneManager.LoadScene(1);

            //word6.text = "FIM!";
            ////word1 = pontos.ToString();
            ////word2 = 
            //status.GetComponent<VRLookWalk>().enabled = false;
            //word6.text = "FIM!";
            ////passandodados= tempo;
            //DontDestroyOnLoad(status);
            //SceneManager.LoadScene(1);
            //word6.text = "FIM! apos";
        }


    }

   
}

