using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionController : MonoBehaviour
{
    public Color collisionColor = Color.red;
    public Color defaultColor = Color.white;
    public TMP_Text collisionText;
    public TMP_Text endGameText;

    public static int collisionCount = 0;
    public AudioClip beepSound;
    private AudioSource audioSource;
    private Renderer objectRenderer;
    public static List<string> objectsNotInTray;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = beepSound;

        collisionText.text = "Collisions: 0";
        endGameText.text = "";

        objectsNotInTray = new List<string> { "Nose", "Bone1", "Bone2" };

        if (objectRenderer != null)
        {
            objectRenderer.material.color = defaultColor;
        }
    }


    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("Collider"))
        {
            
            collisionCount++;
            collisionText.text = "Collisions: " + collisionCount;
            audioSource.Play();
            if (objectRenderer != null)
            {
                objectRenderer.material.color = collisionColor;
            }
        }

        if (collision.gameObject.CompareTag("Tray"))
        {
            objectsNotInTray.Remove(gameObject.name);
            if (objectsNotInTray.Count == 0)
            {
                endGameText.text = "Success";
                HapticGrabber.timerStarted = false;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collider"))
        {
            audioSource.Play();
            if (objectRenderer != null)
            {
                objectRenderer.material.color = defaultColor;
            }
        }
    }
}
