using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class BadgeRankTracker : MonoBehaviour
{
    public Slider RankProgressBar;
    public TMP_Text TotalScore;
    private int PlayerTotalScore;

    public int TestingScore;

    public GameObject[] Badges;
    public GameObject[] BadgesPanel;

    public TMP_Text[] BadgesPanelLabel;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i<Badges.Length;i++){
            Badges[i].SetActive(false);
            BadgesPanel[i].GetComponent<Image>().enabled = false;
            BadgesPanelLabel[i].enabled = false;
        }

        // PlayerTotalScore = PlayerPrefs.GetInt("Player Pref Total Score");
        // TODO: remove after done with the scoring system. this is a stub.
        PlayerTotalScore = TestingScore;
    }

    // Update is called once per frame
    void Update()
    {   

        // Show the text on mainmenu
        TotalScore.text = PlayerTotalScore.ToString();

        // Show the value on progress bar
        if(PlayerTotalScore<=100){
            RankProgressBar.value = 4;
            Badges[0].SetActive(true);
            BadgesPanel[0].GetComponent<Image>().enabled = true;
            BadgesPanelLabel[0].enabled = true;
        }else if(PlayerTotalScore>100 && PlayerTotalScore<=500){
            RankProgressBar.value = 27;
            Badges[1].SetActive(true);

            for (int i = 0;i<2;i++){
                BadgesPanel[i].GetComponent<Image>().enabled = true;
                BadgesPanelLabel[i].enabled = true;
            }

        }else if(PlayerTotalScore>500 && PlayerTotalScore<=1000){
            RankProgressBar.value = 50;
            Badges[2].SetActive(true);
            
            for (int i = 0;i<3;i++){
                BadgesPanel[i].GetComponent<Image>().enabled = true;
                BadgesPanelLabel[i].enabled = true;
            }
            
        }else if(PlayerTotalScore>1000 && PlayerTotalScore<=5000){
            RankProgressBar.value = 74;
            Badges[3].SetActive(true);
            
            for (int i = 0;i<4;i++){
                BadgesPanel[i].GetComponent<Image>().enabled = true;
                BadgesPanelLabel[i].enabled = true;
            }
            
        }else{
            RankProgressBar.value = 97;
            Badges[4].SetActive(true);
            
            for (int i = 0;i<5;i++){
                BadgesPanel[i].GetComponent<Image>().enabled = true;
                BadgesPanelLabel[i].enabled = true;
            }
            
        }
    }
}
