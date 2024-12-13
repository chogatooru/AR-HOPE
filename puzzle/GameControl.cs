using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    Color scolor;
    public GameObject Ui;
    public GameObject pintu;
    //public Animator animator;
    //public Animator markflyanimator;
    [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    public static bool youWin;
    public Animator anima;
    public Animator anipuzzle;
    public Sprite finished;
    public Transform target;

    public GameObject page9;
    public Transform targetfire;
    public bool isonpage9 = false;
    public bajifly bajiflys;
    //public flytomiddel flytomiddel;
    // Start is called before the first frame update

    private AudioSource _audioSource;
    AudioClip audioClip;
    public bool mhasPlayedGameOverMusic = false;

    void Start()
    {
        _audioSource = this.gameObject.AddComponent<AudioSource>();


        //winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bajiflys.isAni)
        {
            Invoke("di", 2);
        }
            Invoke("dis", 2);
        if (pictures[0].localRotation.z / 360 == 0 && pictures[1].localRotation.z / 360 == 0 && pictures[2].localRotation.z / 360 == 0 && pictures[3].localRotation.z / 360 == 0)
        {
            youWin = true;
            Invoke("win", 1);
            
        }

    }
    void dis()
    {
      //  anipuzzle.SetBool("Isanim", true);
        anima.SetBool("Isactiveed", true);
        //anipuzzle.SetBool("Isanim", false);
        
        //anipuzzle.SetBool("Isfin", true);
    }
    void di()
    {

        anipuzzle.SetBool("Isfin", true);
    }
    void win()
    {
        transform.parent = target.parent;
        pintu.SetActive(false);
        gameObject.GetComponent<SpriteRenderer>().sprite = finished;
        gameObject.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.None;

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, 0.5f);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 10);

        if (gameObject.transform.position == target.transform.position)
        {
            if (mhasPlayedGameOverMusic == false)
            {
                playpopse();
            }
            iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));
            if (gameObject.transform.localScale == target.localScale)
            {
                Ui.SetActive(true);
                //puzzle.SetActive(true);
            }
            // animator.SetBool("IsCCC", true);


            //print("4145648");
            //winText.SetActive(true);s
        }
        if (page9.activeSelf)
        {
            Ui.SetActive(false);
            
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetfire.position, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetfire.rotation, 1);


            if (gameObject.transform.position == targetfire.transform.position)
            {

                gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(128, 128, 128, 255);
                //sldie.SetActive(true);
                transform.parent = targetfire.parent;
                iTween.ScaleTo(gameObject, iTween.Hash("scale", targetfire.localScale, "time", 1));
                isonpage9 = true;
            }
        }

    }
    void playpopse()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("Positive_response");
            mhasPlayedGameOverMusic = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 1.5F);

        }
    }
}
