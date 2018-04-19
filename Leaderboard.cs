using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class Leaderboard : MonoBehaviour
    {

        public Text[] highScores;
        int[] highScoreValues;

        int nScore;


        // Use this for initialization
        void Start()
        {
            highScoreValues = new int[highScores.Length];
            for (int x = 0; x < highScores.Length; x++)
            {
                highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x);
            }
            DrawScores();

        }
        void SaveScores()
        {
            for (int x = 0; x < highScores.Length; x++)
            {
                PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues[x]);
            }
        }

        public void CheckForHighScore(int nScore)
        {
            for (int x = 0; x < highScores.Length; x++)
            {
                if (nScore> highScoreValues[x])
                {
                    for (int y = highScores.Length - 1; y > x; y--)
                    {
                        highScoreValues[y] = highScoreValues[y - 1];
                    }
                    highScoreValues[x] = nScore;
                    DrawScores();
                    SaveScores();
                    break;
                }
            }
        }
        void DrawScores()
        {
            for (int x = 0; x < highScores.Length; x++)
            {
                highScores[x].text = highScoreValues[x].ToString();
            }
        }
    // Update is called once per frame
    void Update()   
        {
        nScore = PlayerPrefs.GetInt("nScore");
        }
    }

