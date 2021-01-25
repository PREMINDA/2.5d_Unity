using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text _Scoreval;

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
}
