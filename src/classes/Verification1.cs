
public static class Verification1
{
    public static bool IsNumeric(this String input)
    {
        Double number;
        return Double.TryParse(input, out number);
    }
}