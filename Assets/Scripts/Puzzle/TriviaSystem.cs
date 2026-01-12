using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//Class to define what a "trivia question" is
public class TriviaQuestion
{
    //What is the question?
    public string questionText;

    //What are the answer options? 
    public string textAnswerA;
    public string textAnswerB;
    public string textAnswerC;
    public string textAnswerD;

    //correct answer for this question?
    public string correctAnswer;


}
public class TriviaSystem : MonoBehaviour
{

    //the current round. This will correspond to the TriviaRounds[] array. 
    //Arrays count from 0, so currentround is 0 if it's the first question. 
    //in editor, it'll say Element 0, imagine it like 'Element currentRound'
    public int currentRound;

    //player's life/strikes remaining
    public int strikes;

    //how many questions did the player get right so far? 

    public int playerScore;

    //how many questions does the player need to get right to win? 
    public int scoreToWinLevel;

    //the most recent answer from player (A, B, C, D)
    public string lastPlayerAnswer;

    //Good and bad audio clips 
    public AudioClip buzzGood;
    public AudioClip buzzBad;

    public GameObject vfxleGood;
    public GameObject vfxBad;

    //Declare serialized Class "TriviaRound". This defines what a TriviaQuestion contains
    [System.Serializable]
    public class TriviaRound
    {
        //What is the question?
        public string questionText;

        //What are the answer options? 
        public string textA;
        public string textB;
        public string textC;
        public string textD;

        //correct answer for this question?
        public string correctAnswer;
        
        //the VA clip for the audio
        public AudioClip questionVAudio; 

    }

    //The Array for trivia questions. 
    public TriviaRound[] triviaRounds;

    void Start()
    {
    }

    void Update()
    {
        
    }
}
