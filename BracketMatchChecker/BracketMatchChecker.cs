namespace BracketMatchChecker
{
    public class BracketCheck
    {
        public bool MatchingBracketCheck(string input)
        {
            Queue<char> brackets = new Queue<char>();

            // if there are no brackets skip the check and return true
            if (!(input.Contains('<') || input.Contains('>'))) return true;

            foreach (char c in input)
            {
                // if it is an opening bracket, add it to the queue
                if (c == '<')
                {
                    brackets.Enqueue(c);
                }
                // if it's a closing bracket, remove an opening bracket from the queue
                else if (c == '>')
                {
                    // if the queue is empty there is a mismatch so return false
                    if (brackets.Count == 0) return false;
                    brackets.Dequeue();
                }
            }

            // if the queue isn't empty the brackets aren't matching so return false
            if (brackets.Count > 0) return false;

            return true;
        }
    }
}