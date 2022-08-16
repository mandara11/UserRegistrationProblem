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

            //UC5
            Password1 password1 = new Password1();
            Console.WriteLine("Please Enter your password to check");
            var check5 = password1.ValidatePassword1(Console.ReadLine());
            Console.WriteLine(check5);

            //UC6
            Password2 password2 = new Password2();
            Console.WriteLine("Please Enter your password to check");
            var check6 = password2.ValidatePassword2(Console.ReadLine());
            Console.WriteLine(check6);

            //UC7
            Password3 password3 = new Password3();
            Console.WriteLine("Please Enter your password to check");
            var check7 = password3.ValidatePassword3(Console.ReadLine());
            Console.WriteLine(check7);

            //UC8
            Password4 password4 = new Password4();
            Console.WriteLine("Please Enter your password to check");
            var check8 = password4.ValidatePassword4(Console.ReadLine());
            Console.WriteLine(check8);
        }
    }
}