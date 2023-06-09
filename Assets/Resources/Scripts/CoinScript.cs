using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameHandler.coins++;
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
    }
}
