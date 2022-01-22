
public static class Verification2
{
    public static bool NumberVerification(this String input)
    {
        char[] verification1 = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        int j = 1;
        for (int i = 0; i < verification1.Length; i++)
        {
            bool ver3 = input.Contains(verification1[i]);
            if (ver3 == true)
            {
                j = j + 1;
            }
        }
        if (j > 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}