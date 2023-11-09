using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private ScoreManager scoreManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            CollectCherry();
            Destroy(collision.gameObject);
        }
    }

    private void CollectCherry()
    {
        if (collectionSoundEffect != null)
        {
            collectionSoundEffect.Play();
        }
        else
        {
            Debug.LogWarning("Collection sound effect AudioSource is not assigned on " + gameObject.name);
        }

        scoreManager.AddToTemporaryScore(1);
    }
}
