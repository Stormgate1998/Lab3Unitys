using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public GameObject gameEndObject; // Assign this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Robot"))
        {
            // Destroy the coin
            Destroy(gameObject);

            // Activate the GameEnd object
            if (gameEndObject != null)
            {
                gameEndObject.SetActive(true);
            }
        }
    }
}
