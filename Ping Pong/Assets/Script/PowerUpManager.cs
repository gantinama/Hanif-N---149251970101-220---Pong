using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerUps;
    public int spawnIntervals;
    // public int timeInterval;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;
    public List<GameObject> powerUpsTemplate;
    

    private List<GameObject> powerUps;
    private float timer;

    private void Start() 
    {
        powerUps = new List<GameObject>();   
        timer = 0;
    }

    private void Update() 
    {
        timer += Time.deltaTime;

        if (timer > spawnIntervals)
        {
            // else
            // {
                GenerateRandomPwrUp();
            //     // timer -= spawnIntervals;
                Debug.Log("masuk " + timer); 
            // }
        }
        if (timer > 5)
        {
            RemovePowerUp(gameObject);
            // timer -= timeInterval;                 
            Debug.Log("tolak " + powerUps.Count + " " + timer);
        }

    }

    public void GenerateRandomPwrUp()
    {
        GenerateRandomPwrUpPos(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPwrUpPos(Vector2 position)
    {
        if (powerUps.Count >= maxPowerUps)
        {
            return;
        }
        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpsTemplate.Count);

        GameObject powerUp = Instantiate(powerUpsTemplate[randomIndex], position, Quaternion.identity, spawnArea);

        powerUp.SetActive(true);

        powerUps.Add(powerUp);
        timer -= spawnIntervals; 
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        Debug.Log("berhasil " + powerUps.Count + " " + timer);
        powerUps.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUps()
    {
        while (powerUps.Count > 0)
        {
            RemovePowerUp(powerUps[0]);
        }
    }
    
}