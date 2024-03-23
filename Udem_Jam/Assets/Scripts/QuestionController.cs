using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public TextMeshPro tmp;
    Vector3[] positions;
    Quiz[] quizzes;
    // Start is called before the first frame update
    void Start()
    {
        quizzes = new Quiz[3];
        positions = new Vector3[3];

        positions[0] = new Vector3(-32.29f, 23.66f, 0f);
        positions[1] = new Vector3(-1.6f, 53.7f, 0f);
        positions[2] = new Vector3(29.3f, 23f, 0f);

        instantiateQuestions();
        Debug.Log(quizzes[0].question);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instantiateQuestions(){
        quizzes[0] = new Quiz("Identify a good buffer: \n A) a solution containing small amounts of both a weak acid and its conjugate base \n B) a solution containing significant amounts of both a strong acid and a strong base \n C) a solution containing significant amounts of both a weak acid and its conjugate base", 'C');
        quizzes[1] = new Quiz("Which of the following solutions represents a good buffer system? \n A) a solution that is 0.10 mol L-1 CH3COOH and 0.10 mol L-1 CH3COOLi \n B) a solution that is 0.10 mol L-1 NaOH and 0.10 mol L-1 KOH \n C) a solution that is 0.10 mol L-1 HCl and 0.10 mol L-1 NH4+", 'A');
    }
}

class Quiz{
    public char answer;
    public string question;

    public Quiz(string question, char answer){
        this.answer = answer;
        this.question = question;
    }
}
