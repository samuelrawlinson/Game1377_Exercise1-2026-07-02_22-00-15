/*
 * Assignment: Rock Paper Scissors Lizard Spock Game
 * 
 * Objective:
 * Implement a fully functional Rock Paper Scissors Lizard Spock game using Unity and C#. The player selects a choice via UI buttons, 
 * the computer randomly selects its choice, and the game determines the winner based on the game rules.
 * 
 * Requirements:
 * 1. The player can choose from five options: Rock, Paper, Scissors, Lizard, or Spock by pressing designated buttons in the scene.
 * 2. The computer randomly selects one of the five choices each turn.
 * 3. Game logic determines the winner based on the following rules:
 *    - Rock beats Scissors and Lizard
 *    - Scissors beats Paper and Lizard
 *    - Paper beats Rock and Spock
 *    - Lizard beats Paper and Spock
 *    - Spock beats Scissors and Rock
 * 4. Ties occur when both the player and computer choose the same option.
 * 5. All game results (player choice, computer choice, and outcome) should be output using Debug.Log.
 * 6. Use an enum to represent the five choices instead of strings.
 * 7. Update the OnClick() method in the editor to use enums instead of strings.
 * 
 * Instructions:
 * - Attach the script to any active GameObject in your Unity scene.
 * - Change the OnClick method on the UI buttons in the scene to use enums instead of strings.
 * - Observe the game results in the Console after each button press.
 * 
 * Hint:
 * - Start by just fixing up the strings and doing Rock Paper Scissors. 
 * - Once you have that working, add in the Lizard and Spock options and update the game logic accordingly.
 * - Lastly, change the method to use enums instead of strings.
 *
 */

using UnityEngine;

public class RockPaperScissorsGame : MonoBehaviour
{
    private enum GameChoices 
    {
        Rock, // 0
        Paper, // 1
        Scissors, // 2
        Lizard, // 3
        Spock, // 4
        Maximum // Used to avoid magic number with Random.Range
    };

    float maxmiumEnumValue = (float) GameChoices.Maximum;

    public void RockPaperScissors(int playerChoice)
    {
        // Print out the player and computer choices in Enum form
        Debug.Log("You chose: " + (GameChoices)playerChoice);
        
        int computerChoice = (int) (GameChoices)Random.Range(0, maxmiumEnumValue);
        Debug.Log("Computer chose: " + (GameChoices)computerChoice);

        // Tie
        if(playerChoice == computerChoice)
        {
            Debug.Log("It's a tie! Both chose " + (GameChoices)playerChoice);
        }


        // Rock beats Scissors and Lizard, so the player wins
        else if (playerChoice == 0 && (computerChoice == 2 || computerChoice == 3))
        {
            Debug.Log("You win! " + (GameChoices)playerChoice + " beats " + (GameChoices)computerChoice);
        }
        // Rock beats Scissors and Lizard, so the computer wins
        else if (computerChoice == 0 && (playerChoice == 2 || playerChoice == 3))
        {
            Debug.Log("You lose! " + (GameChoices)computerChoice + " beats " + (GameChoices)playerChoice);
        }


        // Paper beats Rock and Spock, so the player wins
        else if (playerChoice == 1 && (computerChoice == 0 || computerChoice == 4))
        {
            Debug.Log("You win! " + (GameChoices)playerChoice + " beats " + (GameChoices)computerChoice);
        }
        // Paper beats Rock and Spock, so the computer wins
        else if (computerChoice == 1 && (playerChoice == 0 || playerChoice == 4))
        {
            Debug.Log("You lose! " + (GameChoices)computerChoice + " beats " + (GameChoices)playerChoice);
        }


        // Scissors beats Paper and Lizard, so the player wins
        else if (playerChoice == 2 && (computerChoice == 1 || computerChoice == 3))
        {
            Debug.Log("You win! " + (GameChoices)playerChoice + " beats " + (GameChoices)computerChoice);
        }
        // Scissors beats Paper and Lizard, so the computer wins
        else if (computerChoice == 2 && (playerChoice == 1 || playerChoice == 3))
        {
            Debug.Log("You lose! " + (GameChoices)computerChoice + " beats " + (GameChoices)playerChoice);
        }


        // Lizard beats Paper and Spock, so the player wins
        else if (playerChoice == 3 && (computerChoice == 1 || computerChoice == 4))
        {
            Debug.Log("You win! " + (GameChoices)playerChoice + " beats " + (GameChoices)computerChoice);
        }
        // Lizard beats Paper and Spock, so the computer wins
        else if (computerChoice == 3 && (playerChoice == 1 || playerChoice == 4))
        {
            Debug.Log("You lose! " + (GameChoices)computerChoice + " beats " + (GameChoices)playerChoice);
        }


        // Spock beats Scissors and Rock, so the player wins
        else if (playerChoice == 4 && (computerChoice == 2 || computerChoice == 0))
        {
            Debug.Log("You win! " + (GameChoices)playerChoice + " beats " + (GameChoices)computerChoice);
        }
        // Spock beats Scissors and Rock, so the computer wins
        else if (computerChoice == 4 && (playerChoice == 2 || playerChoice == 0))
        {
            Debug.Log("You lose! " + (GameChoices)computerChoice + " beats " + (GameChoices)playerChoice);
        }

        
    }
}
