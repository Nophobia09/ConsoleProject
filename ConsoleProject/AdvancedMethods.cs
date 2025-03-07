using System.Text.RegularExpressions;

namespace ConsoleProject;

public class AdvancedMethods
{
    public bool ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }

    public string EncryptString(string input, int shift)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] inputArray = input.ToCharArray();
        string result = string.Empty;
            foreach (char letter in inputArray)
            {
                //store current position in order to calculate shift
                int currentLetterIndex = Array.IndexOf(alphabet, char.ToLower(letter));
                int newIndex = (currentLetterIndex + shift) % alphabet.Length;
                char newLetter = alphabet[newIndex];
                result += newLetter;
            }
        return result;
    }
}