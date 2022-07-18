public class Solution_1678
{
    public string Interpret(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}