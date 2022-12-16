using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GmaeManager : MonoBehaviour
{
    public GameObject AsteroidPrefab;
    public Transform[] AsteroidSpawnPoints;
 
    public float spawnthreshold = 0.00001f;
    public int frequency = 0;
    public FFTWindow fftWindow;

    private float[] samples = new float[1024];
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnAsteroid", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {

       
    

    }

    void SpawnAsteroid()
    {
        AudioListener.GetSpectrumData(samples, 0, fftWindow);
        if(samples[frequency] > spawnthreshold)
        {
            int index = Random.Range(0, AsteroidSpawnPoints.Length);
            Vector3 spawPos = AsteroidSpawnPoints[index].position;
            GameObject Asteroid = Instantiate(AsteroidPrefab, spawPos, Quaternion.identity);

            int dirModifier = 1;

            Asteroid.GetComponent<asteroidcontrol>().speed = Random.Range(0.5f, 1.5f) * dirModifier;

        }
        

    }

}
