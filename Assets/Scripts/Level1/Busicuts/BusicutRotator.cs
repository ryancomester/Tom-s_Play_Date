using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusicutRotator : MonoBehaviour
{
    [SerializeField] private int busicutRotation;

    void Update()
    {
        transform.Rotate(0, 0 , busicutRotation * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerManager.numberOfBusicuts += 1;
            Destroy(gameObject);

            //plays pop sound
            SoundManager.soundInstance.sfxMusicPlayer.PlayOneShot(SoundManager.soundInstance.busicutGainedMusic);
        }
    }
}
