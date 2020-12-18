using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public double maxTime = 1;
    private float timer = 0;
    public GameObject venus;
    public float height;
    private float pipeSpawnTimer;
    private float pipeSpawnTimerMax;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newvenus = Instantiate(venus);
        newvenus.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

        pipeSpawnTimerMax = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            SoundManagerScript.PlaySound("venusChomp");
            GameObject newvenus = Instantiate(venus);
            newvenus.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newvenus, 20);

            timer = 0;
        }
        timer += Time.deltaTime;
        HandlePipeSpawning();

    }

    private void HandlePipeSpawning() {
        pipeSpawnTimer -= Time.deltaTime;
        if(pipeSpawnTimer < 0) {
            pipeSpawnTimer +=  pipeSpawnTimerMax;

        }

    }
}
