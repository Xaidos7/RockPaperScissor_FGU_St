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
        foreach (GameObject a in playerChoices)
        {
            a.SetActive(false);
        }
        foreach (GameObject b in enemyChoices)
        {
            b.SetActive(false);
        }
        
        enemyChoice.SetActive(true);
        playerChoice.SetActive(true);

        Debug.Log("Du valgte: " + playerChoice.tag);
        Debug.Log("Din modstander valgte: " + enemyChoice.tag);

        if (playerChoice.CompareTag(enemyChoice.tag))
        {
            Debug.Log("Den er uafgjort!");
        }
        else if (playerChoice.CompareTag("Sten") && enemyChoice.CompareTag("Saks")|| 
                 playerChoice.CompareTag("Saks") && enemyChoice.CompareTag("Papir")||
                 playerChoice.CompareTag("Papir") && enemyChoice.CompareTag("Sten"))
        {
            Debug.Log("Du vandt!");
        }
        else
        {
            Debug.Log("Du tabte!");
        }

    }
}
