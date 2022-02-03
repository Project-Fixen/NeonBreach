using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    private int Opponent;
    private int result;
    private int score;

    public GameObject[] display;
    public GameObject roll;
    public GameObject[] Input;
    public TextMesh text;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(int player) {
        StartCoroutine(OnChoice(player));
    }

    IEnumerator OnChoice(int Player) {
        Opponent = (int) Random.Range(0.0f, 3.0f) + 1;
        display[Opponent - 1].SetActive(true);
        roll.SetActive(false);
        if (Player == Opponent) {
            result = 0;
        }
        else if ((Player % 2 == 1) && (Opponent % 2 == 1)) {
            if (Player > Opponent) {
                result = -1;
            }
            else {
                result = 1;
            }
        }
        else {
            if (Player < Opponent) {
                result = -1;
            }
            else {
                result = 1;
            }
        }
        yield return new WaitForSeconds(1.0f);
        roll.SetActive(true);
        display[Opponent - 1].SetActive(false);
        score += result;
        text.text = "" + score;
    }
}
