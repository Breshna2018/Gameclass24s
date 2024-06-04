using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour


{

    private float speed = 20.0f;
    private float turnspeed = 40.0f;
    private float horizontalinput;
    private float forwardinput;
    private int score = 0;
    string scoreText = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Rotate(Vector3.up, turnspeed * horizontalinput * Time.deltaTime);

    } // Update

    private void OnTriggerEnter(Collider other)
    {
        string objectTag = other.tag;

        string positiveTagName = "BoxPositive";
        string negativeTagName = "BoxNegative";

        if (objectTag == positiveTagName)
        {
            Debug.Log("This is a positive box");
            score += 10;
            AddPoints(10);// Increase score by 10 for positive boxes
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);

            // To make an object disappear, call Destory(object)

        }
        else if (objectTag == negativeTagName)
        {
            Debug.Log("This is a negative box");
            score -= 5;
            AddPoints(10);
            // Decrease score by 5 for negative boxes
            Debug.Log("Score: " + score);

            Destroy(other.gameObject);



        }
    }

        private void AddPoints(int points)
        {
            score += points;
            UpdateScoreText();  // Update the score display
        }

        // Method to update the score UI text
        private void UpdateScoreText()
        {
            if (scoreText != null)
            {
                //scoreText.text = "Score: " + score;
            }
        }


} 
