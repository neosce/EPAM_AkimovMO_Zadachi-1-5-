namespace Algorithms.Controller
{
    public class BracketSequence
    {

        public bool BracketSeq(string items)
        {

            int check = 0;
            for (int i = 0; i < items.Length; i++)
            {

                string symbol1 = items.Substring(i, 1);
                if (symbol1.Equals("(") || symbol1.Equals("[") || symbol1.Equals("{"))
                {
                    check++;
                }
                else
                {
                    check--;
                }

                if (check < 0)
                {
                    return false;
                }

            }
            return check == 0;

        }

    }
}
