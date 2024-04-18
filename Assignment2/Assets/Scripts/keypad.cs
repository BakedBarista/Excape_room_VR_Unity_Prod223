using UnityEngine;

public class Keypad : MonoBehaviour
{
    private string enteredCombination = "";
    public string correctCombination = "1234"; // Set your desired combination here
    public GameObject objectToActivate; // Reference to the object you want to activate

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Controller"))
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
                else
                {
                    // Append the key value to the entered combination
                    enteredCombination += keyValue;
                }

                // Check if entered combination matches the correct combination
                if (enteredCombination == correctCombination)
                {
                    // Activate the object
                    objectToActivate.SetActive(true);
                }
            }
        }
    }
}
