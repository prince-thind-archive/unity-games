using UnityEngine;
using System.Collections;

public class CoinPool : MonoBehaviour
{    
    //variables names used in this script
    public GameObject coinPrefab;                                    
    public int coinPoolSize = 5;                                     
    public float spawnRate = 3f;                                    
    public float coinMin = -4.8f;     //for coin to remain within road horizontally                               
    public float coinMax = 4.8f; 
    private GameObject[] coins;      // this is an array of gameobjects                             
    private int currentcoin = 0;                                    

    private Vector2 objectPoolPosition = new Vector2(-15, -25);    //this is a random position for coins to be placed before transformation  

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;
        coins = new GameObject[coinPoolSize];  //construct the empty array of size coinpoolsize
        for (int i = 0; i < coinPoolSize; i++)
        {
            //fill the array with objects constructed from the prefab object
            coins[i] = (GameObject)Instantiate(coinPrefab, objectPoolPosition, Quaternion.identity);
        }
    }



    void Update()
    {
        if(Input.GetKey(KeyCode.W)) //if w key is pressed time will increment
        timeSinceLastSpawned += Time.deltaTime;

        if (Controller.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) //if sufficient time has passed and game is not over yet
        {
            timeSinceLastSpawned = 0f;                             //reset time
            float spawnXPosition = Random.Range(coinMin, coinMax); //Set a random X position for the coin
            float spawnYPosition = Random.Range(15f, 25f);         //Set a random Y position for the coin
            coins[currentcoin].transform.position = new Vector2(spawnXPosition, spawnYPosition); //...then set the current coin to that position.
            currentcoin++;                   // move to next coin in array

            if (currentcoin >= coinPoolSize) //reset index if out of bound
            {
                currentcoin = 0;
            }
        }
    }
}