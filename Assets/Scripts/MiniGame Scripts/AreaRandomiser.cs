using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRandomiser : MonoBehaviour
{

    public List<GameObject> Area = new List<GameObject>();
    private int RandomNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i<Area.Count;i++){
            Area[i].SetActive(false);
        }
        
        RandomNumber = Random.Range(0,Area.Count);
        Area[RandomNumber].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
