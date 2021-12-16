using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Rigidbody rb;
    Animator m_Animator;
    AudioSource death;
    public Image imge;
    // Start is called before the first frame update
    void Start()
    {
        death = GetComponent<AudioSource>();
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!SpawnHurdles.gameOver && Input.GetKeyDown("w"))
        {
            rb.AddForce(0,6f,0,ForceMode.Impulse);
            rb.constraints = (RigidbodyConstraints)10;
        }
        if(!SpawnHurdles.gameOver && (transform.position.y <= -2.8f || transform.position.y >= 7.7f))
        {
            ShowGameOver();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(!SpawnHurdles.gameOver && col.collider.tag == "Hurdle")
        {
            ShowGameOver();
        }
    }
    void ShowGameOver()
    {
        SpawnHurdles.gameOver = true;
        m_Animator.SetTrigger("GameOverTrigger");
        if (!death.isPlaying)
            death.Play();
        Invoke("ShowRedScreenControl", 2f);
        Invoke("GameOverInvoke", 7f);
    }

    void GameOverInvoke()
    {
        SceneTransition.EndGame();
    }
    void ShowRedScreenControl()
    {
        ShowRedScreen.Show();
    }
}
