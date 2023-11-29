using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelToLoad : MonoBehaviour
{
    public int levelAt;
    public int lastLevel;

    public GameObject[] btnLoadLvl = new GameObject[0];

    // Start is called before the first frame update
    void Start()
    {
        levelAt = PlayerPrefs.GetInt("p_levelAt");

        switch (levelAt)
        {
            case 1:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(false);
                btnLoadLvl[3].gameObject.SetActive(false);
                btnLoadLvl[4].gameObject.SetActive(false);
                btnLoadLvl[5].gameObject.SetActive(false);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 2:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(false);
                btnLoadLvl[4].gameObject.SetActive(false);
                btnLoadLvl[5].gameObject.SetActive(false);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 3:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(false);
                btnLoadLvl[5].gameObject.SetActive(false);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 4:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(false);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 5:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 6:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(true);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 7:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(true);
                btnLoadLvl[7].gameObject.SetActive(true);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 8:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(true);
                btnLoadLvl[7].gameObject.SetActive(true);
                btnLoadLvl[8].gameObject.SetActive(true);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 9:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(true);
                btnLoadLvl[7].gameObject.SetActive(true);
                btnLoadLvl[8].gameObject.SetActive(true);
                btnLoadLvl[9].gameObject.SetActive(true);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
            case 10:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(true);
                btnLoadLvl[3].gameObject.SetActive(true);
                btnLoadLvl[4].gameObject.SetActive(true);
                btnLoadLvl[5].gameObject.SetActive(true);
                btnLoadLvl[6].gameObject.SetActive(true);
                btnLoadLvl[7].gameObject.SetActive(true);
                btnLoadLvl[8].gameObject.SetActive(true);
                btnLoadLvl[9].gameObject.SetActive(true);
                btnLoadLvl[10].gameObject.SetActive(true);
                break;
            default:
                btnLoadLvl[1].gameObject.SetActive(true);
                btnLoadLvl[2].gameObject.SetActive(false);
                btnLoadLvl[3].gameObject.SetActive(false);
                btnLoadLvl[4].gameObject.SetActive(false);
                btnLoadLvl[5].gameObject.SetActive(false);
                btnLoadLvl[6].gameObject.SetActive(false);
                btnLoadLvl[7].gameObject.SetActive(false);
                btnLoadLvl[8].gameObject.SetActive(false);
                btnLoadLvl[9].gameObject.SetActive(false);
                btnLoadLvl[10].gameObject.SetActive(false);
                break;
        }
    }


}
