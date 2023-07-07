using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerController PlayerController;
    private TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Text UI�� ���� ���� ������ ������Ʈ
        textScore.text = "Score" + PlayerController.Score;
    }
}