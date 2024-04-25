using UnityEngine;

public class Keypad : MonoBehaviour
{
    private static string enteredCombination = "";
    public string greenCombination = "1010"; // Combination for activating the green ball
    public string redCombination = "341"; // Combination for activating the red ball
    public GameObject greenBall; // Reference to the green ball object
    public GameObject redBall; // Reference to the red ball object
    public AudioClip clockClueAudio; // Audio clip for clock clue

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Set the audio clip to play
        audioSource.clip = clockClueAudio;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            // Check if the trigger button is pressed
            if (Input.GetButtonDown("Fire1")) // Assuming Fire1 is the trigger button input
            {
                // Get the key value from the collided GameObject
                string keyValue = gameObject.name;

                // Check if the pressed key is the "*"
                if (keyValue == "*")
                {
                    // Clear the entered combination
                    enteredCombination = "";
                }
                else if (keyValue == "Red")
                {
                    // Play clock clue audio when "#" key is pressed
                    if (clockClueAudio != null)
                    {
                        audioSource.Play();
                    }
                }
                else
                {
                    // Append the key value to the entered combination
                    enteredCombination += keyValue;

                    // Check if entered combination matches the green combination
                    if (enteredCombination == greenCombination)
                    {
                        // Activate the green ball
                        greenBall.SetActive(true);
                    }

                    // Check if entered combination matches the red combination
                    if (enteredCombination == redCombination)
                    {
                        // Activate the red ball
                        redBall.SetActive(true);
                    }
                }
            }
        }
    }
}
