namespace ExtentionMethods.ExtentionMethod
{
    public static class PersonExtentions
    {
        public static string ToFullName(this Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }
}
