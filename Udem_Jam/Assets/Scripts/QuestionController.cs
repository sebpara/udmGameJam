using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public int level;
    public Quiz quizzed;
    public TextMeshPro field;
    Vector3[] positions;
    
    // Start is called before the first frame update
    void Start()
    {
        positions = new Vector3[3];

        positions[0] = new Vector3(-32.29f, 23.66f, 0f);
        positions[1] = new Vector3(-1.6f, 53.7f, 0f);
        positions[2] = new Vector3(29.3f, 23f, 0f);

        instantiateQuestion();
        // Debug.Log(field.text);

        field.text = this.quizzed.question;
       // Debug.Log(tmp.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instantiateQuestion(){
        switch(Random.Range(0, 9)){
            case 0: 
                this.quizzed = new Quiz("Identify a good buffer: \n\n A) a solution containing small amounts of both a weak acid and its conjugate base \n\n B) a solution containing significant amounts of both a strong acid and a strong base \n\n C) a solution containing significant amounts of both a weak acid and its conjugate base", 'C');
                break;
            case 1:
                this.quizzed = new Quiz("Which of the following solutions represents a good buffer system? \n\n A) a solution that is 0.10 mol L-1 CH3COOH and 0.10 mol L-1 CH3COOLi \n\n B) a solution that is 0.10 mol L-1 NaOH and 0.10 mol L-1 KOH \n\n C) a solution that is 0.10 mol L-1 HCl and 0.10 mol L-1 NH4+", 'A');
                break;
            case 2:
                this.quizzed = new Quiz("Which of the following statements is true? \n\n A) A buffer is an aqueous solution composed of two weak acids. \n\n B) A buffer resists pH change by neutralizing added acids and bases. \n\n C) The common ion in a buffer solution does not have any effect on the dissociation of the acidic component of the buffer solution.", 'B');
                break;
            case 3:
                this.quizzed = new Quiz("Which of the following solutions is a good buffer system? \n\n A) a solution that is 0.10 mol L-1 NaCl and 0.10 mol L-1 HCl \n\n B) a solution that is 0.10 mol L-1 HCN and 0.10 mol L-1 LiCN \n\n C) a solution that is 0.10 mol L-1 NaOH and 0.10 mol L-1 HNO3",'B');
                break;
            case 4:
                this.quizzed = new Quiz("Which of the following is TRUE? \n\n A) An effective buffer has a [conj base]/[weak acid] ratio in the range of 10 - 100. \n\n B) A buffer is most resistant to pH change when [acid] = [conjugate base]. \n\n C) An effective buffer has very small absolute concentrations of acid and conjugate base.", 'B');
                break;
            case 5:
                this.quizzed = new Quiz("Define buffer capacity. \n\n A) Buffer capacity is the amount of acid or base that can be added to a buffer without destroying its effectiveness. \n\n B) Buffer capacity is the amount of acid that can be added until all the base in the buffer is consumed. \n\n C) Buffer capacity is the amount of base that can be added until all the acid in the buffer is consumed.", 'A');
                break;
            case 6:
                this.quizzed = new Quiz("Which of the following acids (listed with pKa values) and its conjugate base could form a buffer with a pH of 8.10? \n\n A) HC7H5O2, pKa = 4.19 \n\n B) HF, pKa = 3.46 \n\n C) HClO, pKa = 7.54", 'C');
                break;
            case 7:
                this.quizzed = new Quiz("Which of the following acids (listed with Ka values) and their conjugate base would be the best choice to make a buffer with a pH of 2.34? \n\n A) C6H5COOH, Ka = 6.5 × 10-5 \n\n B) HClO2, Ka = 1.1 × 10-2 \n\n C) HClO, Ka = 2.9 × 10-8", 'B');
                break;
            case 8:
                this.quizzed = new Quiz("Which one of the following statements is TRUE? \n\n A)	A buffer is an aqueous solution composed of two weak acids. \n\n B)	A buffer can absorb an unlimited amount of acid or base. \n\n C)   A buffer resists pH change by neutralizing added acids and bases.", 'C');
                break;
            case 9:
                this.quizzed = new Quiz("Which of the following pairs of species is not a conjugate acid-base pair?  \n\n A) HCl and H+ \n\n B) HSO¬4- and SO42- C) NH3 and NH2-", 'C');
                break;
        }
        activatePortal();
    }

    void activatePortal(){
        Debug.Log($"Portal{this.quizzed.answer}{this.level}");
        GameObject portal = GameObject.Find($"Portal{this.quizzed.answer}{this.level}");
        portal.GetComponent<SpriteRenderer>().enabled = true;
        portal.GetComponent<CircleCollider2D>().enabled = true;
    }
}

public class Quiz{
    public char answer;
    public string question;

    public Quiz(string question, char answer){
        this.answer = answer;
        this.question = question;
    }
}