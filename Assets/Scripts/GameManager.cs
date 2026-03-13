using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] playerChoices;
    public GameObject[] enemyChoices;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonPress(GameObject playerChoice)
    {
        GameObject enemyChoice = enemyChoices[Random.Range(0, enemyChoices.Length)];
        Debug.Log("Du valgte: " + playerChoice.tag);
        Debug.Log("Din modstander valgte: " + enemyChoice.tag);

        if (playerChoice.CompareTag(enemyChoice.tag))
        {
            Debug.Log("Den er uafgjort!");
        }

    }
}
