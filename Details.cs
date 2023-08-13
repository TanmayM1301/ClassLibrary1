namespace ClassLibrary1
{
    public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }

        public string Department { get; set; }

        public int salary { get; set; }
    }
    Details[] D = new Details[15];

    D[0].FirstName = "Devansh";
    D[0].LastName="Jain";
}