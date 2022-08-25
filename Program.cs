namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            //UC10
            Patterns p = new Patterns("msg");

            Console.WriteLine("Write your first name using 1st character should be Capital ");
            Console.Write("\n Enter First Name : ");
            string name1 = Console.ReadLine();
            p.FirstName(name1);

            Console.WriteLine("\n Write your last name using 1st character should be Capital ");
            Console.Write("\n Enter Last Name : ");
            string name2 = Console.ReadLine();
            p.LastName(name2);

            Console.WriteLine("\n Write your Email ex : example123@gmail.com your can write yahoo and any other mail ID.");
            Console.Write("\n Enter Email : ");
            string name3 = Console.ReadLine();
            p.Email(name3);

            Console.WriteLine("\n Write your Mobile Number ex : +91 7891235452 .");
            Console.Write("\n Enter Mobile Number : ");
            string name4 = Console.ReadLine();
            p.MobileNumber(name4);

            Console.WriteLine("\n Write your Password ex : Aa9@ length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name5 = Console.ReadLine();
            p.Password(name5);


            //UC1
            //FirstName firstName = new FirstName();
            //Console.WriteLine("Please Enter your first name");
            //var check = firstName.ValidateFirstName(Console.ReadLine());
            //Console.WriteLine(check);

            //UC2
            //LastName lastName = new LastName();
            //Console.WriteLine("Please Enter your last name");
            //var check2 = lastName.ValidateFirstName(Console.ReadLine());
            //Console.WriteLine(check2);

            //UC3
            //CheckEmail checkEmail = new CheckEmail();
            //Console.WriteLine("Please Enter your email to check");
            //var check3 = checkEmail.ValidateEMail(Console.ReadLine());
            //Console.WriteLine(check3);

            //UC4
            //MobileFormat mobileFormat = new MobileFormat();
            //Console.WriteLine("Please Enter your mobile no with country code");
            //var check4 = mobileFormat.ValidateMobileNo(Console.ReadLine());
            //Console.WriteLine(check4);

            ////UC5
            //Password1 password1 = new Password1();
            //Console.WriteLine("Please Enter your password to check");
            //var check5 = password1.ValidatePassword1(Console.ReadLine());
            //Console.WriteLine(check5);

            ////UC6
            //Password2 password2 = new Password2();
            //Console.WriteLine("Please Enter your password to check");
            //var check6 = password2.ValidatePassword2(Console.ReadLine());
            //Console.WriteLine(check6);

            ////UC7
            //Password3 password3 = new Password3();
            //Console.WriteLine("Please Enter your password to check");
            //var check7 = password3.ValidatePassword3(Console.ReadLine());
            //Console.WriteLine(check7);

            ////UC8
            //Password4 password4 = new Password4();
            //Console.WriteLine("Please Enter your password to check");
            //var check8 = password4.ValidatePassword4(Console.ReadLine());
            //Console.WriteLine(check8);

            ////UC9
            //while (true)
            //{
            //    SampleEmails sampleEmail = new SampleEmails();
            //    Console.WriteLine("Please Enter your sample emails to check");
            //    var check9 = sampleEmail.ValidateEmail(Console.ReadLine());
            //    Console.WriteLine(check9);
            //}
        }
    }
}