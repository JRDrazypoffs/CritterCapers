using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckAnimalHabitat : MonoBehaviour
{
    [Header("Habitat List")]
    public GameObject Forest;
    public GameObject Grasslands;
    public GameObject Wetlands;
    public GameObject Desert;
    public GameObject Polar;

    [Header("Habitat Positions List")]
    public Transform ForestPos;
    public Transform GrasslandsPos;
    public Transform WetlandsPos;
    public Transform DesertPos;
    public Transform PolarPos;

    [Header("Animal List")]
    public GameObject[] ForestAnimals;
    public GameObject[] GrasslandsAnimals;
    public GameObject[] WetlandsAnimals;
    public GameObject[] DesertAnimals;
    public GameObject[] PolarAnimals;

    // [Header("Animal Position List")]
    // public Transform[] ForestAnimalsPos;
    // public Transform[] GrasslandsAnimalsPos;
    // public Transform[] WetlandsAnimalsPos;
    // public Transform[] DesertAnimalsPos;
    // public Transform[] PolarAnimalsPos;

    [Header("Utility")]
    public AudioSource SuccessSound;
    public AudioSource ErrorSound;
    public Transform Sparkle;
    public static int ReleaseErrorCount;
    public static int ReleaseSuccessCount;
    
    

    // Start is called before the first frame update
    void Start(){
        ReleaseErrorCount=0;
        ReleaseSuccessCount=0;
    }

    // Update is called once per frame
    void Update(){

        for (int i = 0;i<ForestAnimals.Length;i++){
            if (ForestAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Forest.GetComponent<PolygonCollider2D>())){
                ForestAnimals[i].SetActive(false);
                Instantiate(Sparkle, ForestPos.position, Sparkle.rotation);
                ReleaseSuccessCount++;
                SuccessSound.Play();
            }
            // Error Detect
            if (ForestAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Grasslands.GetComponent<PolygonCollider2D>())){
                ForestAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (ForestAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Desert.GetComponent<PolygonCollider2D>())){
                ForestAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (ForestAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Wetlands.GetComponent<PolygonCollider2D>())){
                ForestAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (ForestAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Polar.GetComponent<PolygonCollider2D>())){
                ForestAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
        }


        for (int i = 0;i<GrasslandsAnimals.Length;i++){
            if (GrasslandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Grasslands.GetComponent<PolygonCollider2D>())){
                GrasslandsAnimals[i].SetActive(false);
                Instantiate(Sparkle, GrasslandsPos.position, Sparkle.rotation);
                ReleaseSuccessCount++;
                SuccessSound.Play();
            }
            // Error Detect
            if (GrasslandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Forest.GetComponent<PolygonCollider2D>())){
                GrasslandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (GrasslandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Desert.GetComponent<PolygonCollider2D>())){
                GrasslandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (GrasslandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Wetlands.GetComponent<PolygonCollider2D>())){
                GrasslandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (GrasslandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Polar.GetComponent<PolygonCollider2D>())){
                GrasslandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
        }


        for (int i = 0;i<WetlandsAnimals.Length;i++){
            if (WetlandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Wetlands.GetComponent<PolygonCollider2D>())){
                WetlandsAnimals[i].SetActive(false);
                Instantiate(Sparkle, WetlandsPos.position, Sparkle.rotation);
                ReleaseSuccessCount++;
                SuccessSound.Play();
            }
            // Error Detect
            if (WetlandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Grasslands.GetComponent<PolygonCollider2D>())){
                WetlandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (WetlandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Desert.GetComponent<PolygonCollider2D>())){
                WetlandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (WetlandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Forest.GetComponent<PolygonCollider2D>())){
                WetlandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (WetlandsAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Polar.GetComponent<PolygonCollider2D>())){
                WetlandsAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
        }


        for (int i = 0;i<DesertAnimals.Length;i++){
            if (DesertAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Desert.GetComponent<PolygonCollider2D>())){
                DesertAnimals[i].SetActive(false);
                Instantiate(Sparkle, DesertPos.position, Sparkle.rotation);
                ReleaseSuccessCount++;
                SuccessSound.Play();
            }
            // Error Detect
            if (DesertAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Grasslands.GetComponent<PolygonCollider2D>())){
                DesertAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (DesertAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Forest.GetComponent<PolygonCollider2D>())){
                DesertAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (DesertAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Wetlands.GetComponent<PolygonCollider2D>())){
                DesertAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (DesertAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Polar.GetComponent<PolygonCollider2D>())){
                DesertAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
        }


        for (int i = 0;i<PolarAnimals.Length;i++){
            if (PolarAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Polar.GetComponent<PolygonCollider2D>())){
                PolarAnimals[i].SetActive(false);
                Instantiate(Sparkle, PolarPos.position, Sparkle.rotation);
                ReleaseSuccessCount++;
                SuccessSound.Play();
            }
            // Error Detect
            if (PolarAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Grasslands.GetComponent<PolygonCollider2D>())){
                PolarAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (PolarAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Desert.GetComponent<PolygonCollider2D>())){
                PolarAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (PolarAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Wetlands.GetComponent<PolygonCollider2D>())){
                PolarAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
            if (PolarAnimals[i].GetComponent<PolygonCollider2D>().IsTouching(Forest.GetComponent<PolygonCollider2D>())){
                PolarAnimals[i].SetActive(false);
                ReleaseErrorCount++;
                ErrorSound.Play();
            }
        }
    }

    
}


