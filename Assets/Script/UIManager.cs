using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text _Scoreval;
    [SerializeField]
    private Text _livesCounter;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void getScore(int score)
    {
        _Scoreval.text = score.ToString();
    }
    public void updateLivers(int lives)
    {
        _livesCounter.text = lives.ToString();
    }
}
