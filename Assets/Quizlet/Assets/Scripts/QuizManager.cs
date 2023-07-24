using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour {

	public question[] questions;
	public static List<question> unansweredQuestions;

	private question currentQuestion;

	[SerializeField]
	private Text factText;

	[SerializeField]
	private float timeBetweenQuestions = 1.0f ;

	[SerializeField]
	private Text trueAnswerText, falseAnswerText;

	[SerializeField]
	private Animator animator;
     void Awake()
    {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
    void Start()
	{
		if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
			unansweredQuestions = questions.ToList<question> ();
		}

		SetCurrentQuestion ();
	}

	void SetCurrentQuestion()
	{
		int randomQuestionsIndex = Random.Range (0,questions.Length);
		currentQuestion = questions [randomQuestionsIndex];

		if (currentQuestion.isTrue) {
			trueAnswerText.text = "CORECT";
			falseAnswerText.text = "GRESIT";
		} else {
			trueAnswerText.text = "GRESIT";
			falseAnswerText.text = "CORECT";
		}

		factText.text = currentQuestion.fact;


	}

	IEnumerator TranstionToNextQuestion()
	{
		unansweredQuestions.Remove (currentQuestion);

		yield return new WaitForSeconds (1.7f );
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void userSelectTrue()
	{
		animator.SetTrigger ("True");
		if (currentQuestion.isTrue) {
			Debug.Log ("Correct");
		} else {
			Debug.Log ("Gresit");
		}
		StartCoroutine (TranstionToNextQuestion());
	}

	public void userSelectFalse()
	{
		animator.SetTrigger ("False");
		if (!currentQuestion.isTrue) {
			Debug.Log ("Corect");
		} else {
			Debug.Log ("Gresit");
		}

		StartCoroutine (TranstionToNextQuestion());
	}
}
