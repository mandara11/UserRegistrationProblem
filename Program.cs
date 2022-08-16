namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            //UC1
            FirstName firstName = new FirstName();
            Console.WriteLine("Please Enter your first name");
            var check = firstName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check);

            //UC2
            LastName lastName = new LastName();
            Console.WriteLine("Please Enter your last name");
            var check2 = lastName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check2);

            //UC3
            CheckEmail checkEmail = new CheckEmail();
            Console.WriteLine("Please Enter your email to check");
            var check3 = checkEmail.ValidateEMail(Console.ReadLine());
            Console.WriteLine(check3);

            //UC4
            MobileFormat mobileFormat = new MobileFormat();
            Console.WriteLine("Please Enter your mobile no with country code");
            var check4 = mobileFormat.ValidateMobileNo(Console.ReadLine());
            Console.WriteLine(check4);
        }
    }
}