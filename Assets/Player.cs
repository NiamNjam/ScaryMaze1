using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //public GameObject player;
    public GameObject Wall;
    //public GameObject trap;
    //public GameObject buttonPlay;
    public float speed = 1f;
    public string nextLevelName;
    public GameObject menu;
    public GameObject scaryPic;
    public AudioSource source;
    public AudioClip scareSound;
    Vector3 pos;
    public Vector3 spawnPoint;
    //Vector3 coll;
    // Start is called before the first frame update
    void Start()
    {
        //menu.objectActive(false);
        menu.SetActive(true);
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        //speed = 0;
        if (other.gameObject.name == "Teleporter")
        {
            SceneManager.LoadScene(nextLevelName);
        }
        else if (other.gameObject.name == "Trap")
        {
            scaryPic.SetActive(true);
            //var source = GetComponent<AudioSource>();
            source.clip = scareSound;
            source.Play();
        }
        else if (other.gameObject.name == "Wall")
        {
            print("collided");
            string col = "collided";
            if (!string.IsNullOrWhiteSpace(col))
            {
                transform.position = spawnPoint;
                SceneManager.LoadScene("SS1");
                menu.SetActive(true);

            }
        }
    }



    

}
