using System;
enum Menu
{
    RegisterType=1,
    GetList=2,
    SignIn=3
}
enum MenuLogin{
    RegisterType=1,
    InfoListScholar=2,
    InfoListStudent=3,
    InfoListTeachet=4,
    LogOut=5
}
class Program
{
    static PersonList personList;
    public static void Main(string[] args)
    {
        PersonListProgram();
        PrintMenuScreen();
     
    }
    public static void PersonListProgram()
    {
        Program.personList = new PersonList();
    }
    public static void PrintMenuScreen()
    {
        Console.Clear();
        PrintRegisterMenu();  
        InputMenuRegister();
    }

    public static void PrintRegisterMenu()
    {
        Console.WriteLine("Welcome to registration campaign");
        Console.WriteLine("************************************");
        Console.WriteLine("1.Register Types");
        Console.WriteLine("2.List Person");
        Console.WriteLine("3.Sign In");
        Console.WriteLine("*************************************");
    }
    public static void InputMenuRegister()
    {
        Console.Write("Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));
        PresentMenuRegister(menu);
    }
    public static void PresentMenuRegister(Menu menu)
    {
        switch(menu)
        {
            case Menu.RegisterType:
                ShowInputRegistrationInCampainScreen();
                break;
            case Menu.GetList:
                ShowAllRegisterInCampaign();
                break;
            case Menu.SignIn:
                ShowSignInCampaign();
                break;
            default:
                break;

        }
    }
    public static void PrintMenuLoginScreen()
    {
        Console.Clear();
        PrintMenuLogin();
        InputMenuLogin();
    }
    public static void PrintMenuLogin(){
        Console.WriteLine("Welcome to registration campaign");
        Console.WriteLine("************************************");
        Console.WriteLine("1.Register Types");
        Console.WriteLine("2.List Scholar");
        Console.WriteLine("3.List Student");
        Console.WriteLine("4.List Teacher");
        Console.WriteLine("5.Sign Out");
        Console.WriteLine("*************************************");
    }
    public static void InputMenuLogin()
    {
        Console.Write("Input Menu: ");
        MenuLogin menulogin = (MenuLogin)(int.Parse(Console.ReadLine()));
        ShowMenuLogin(menulogin);
    }
    public static void ShowMenuLogin(MenuLogin menulogin){
      switch(menulogin)
      {
        case MenuLogin.RegisterType:
        ShowInputRegistrationInCampainScreen();
        break;
        case MenuLogin.InfoListScholar:
        ShowScholarInfo();
        break;
        case MenuLogin.InfoListStudent:
        ShowStudentInfo();
        break;
        case MenuLogin.InfoListTeachet:
        ShowTeacherInfo();
        break;
        case MenuLogin.LogOut:
        signout();
        break;
        default:
        BlackToMenuII();
        break;
      }
    }
    public static void ShowInputRegistrationInCampainScreen()
    {
        Console.Clear();
        Console.WriteLine("Types Registration");
        Console.WriteLine("*********************");
        Console.WriteLine("1. Scholar");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("*********************");
        InputTypeRegister();
    }

    public static void InputTypeRegister()
{
        Console.WriteLine("Input Type: ");
        for(int i = 0; i  <= 0;)
    {
        int Type = int.Parse(Console.ReadLine());
        if(Type == 1)
        {
            InputRegistrationNewsScholarFromKeyboard();
            i++;
        }
        else if (Type == 2)
        {
            InputRegistrationNewsStudentFromKeyboard();
            i++;
        }
        else if (Type == 3)
        {
            InputRegistrationNewsTeacherFromKeyboard();
            i++;
        }
        else
        {
        Console.WriteLine("Try Again!!");
        }
    }
    BlackToMenu();
}
    public static void ShowSignInCampaign()
    {
        string emailname = Console.ReadLine();
        string passwordname = Console.ReadLine();
        Console.WriteLine("Sign In");
        Console.WriteLine("*********************");
        Console.WriteLine("Input Email: ");
        Console.WriteLine("*********************");
        if(emailname == "exit")
        {
            PrintMenuScreen();
        }
        else if (Program.personList.CheckLogin(emailname,passwordname))
         {
            BlackToMenuII();
        }
        else{
            PrintMenuLogin();
        }
    }
    public static void signout()
    {
        Console.Clear();
        BlackToMenu();
    }

    public static void InputRegistrationNewsScholarFromKeyboard()
    {
        
        bool checkAdmin ;
        Console.WriteLine("Register New Scholar");
        Console.WriteLine("********************");
        ScholarInfo scholar = new ScholarInfo(Inputprefix(),InputName(),InputSurname(),InputScholarID(),InputAge(),InputReligion(),InputAllergy(),checkAdmin = CheckAdmin(),Email(checkAdmin),Password(checkAdmin));
        Program.personList.AddNewPerson(scholar);
        PrintMenuScreen();
    }
     public static void InputRegistrationNewsStudentFromKeyboard()
    {
        Console.WriteLine("Register New Student");
        Console.WriteLine("********************");
       StudentInfo student = new StudentInfo(Inputprefix(),InputName(),InputSurname(),Inputclass(),InputAge(),InputReligion(),InputAllergy(),InputSchool());
       Program.personList.AddNewPerson(student);
       PrintMenuScreen();
    }
    public static void InputRegistrationNewsTeacherFromKeyboard()
    {
        
        bool checkAdmin ;
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
       TeacherInfo teacher = new TeacherInfo(Inputprefix(),InputName(),InputSurname(),InputPosition(),InputAge(),InputReligion(),InputAllergy(),checkAdmin = CheckAdmin(),Email(checkAdmin),Password(checkAdmin),InputNumOfcar());
       Program.personList.AddNewPerson(teacher);
       PrintMenuScreen();
    }
    static bool CheckAdmin()
    {
        Console.WriteLine("Is you Admin ?");
        Console.WriteLine("Type Yes or No");

                string s = Console.ReadLine();
                if (s == "Yes" || s == "yes")
                {
                    return true;
                }

                else if (s == "No" || s == "no")
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Please Enter only Yes or No :"); 
                    return CheckAdmin();            
                }
    }
    static string Email(bool checkAdmin)
    {
        if(checkAdmin == true)
        {
            return InputEmail();
        }

        else 
        {
            return null;
        }
    }
    static string Password(bool checkAdmin)
 {
    if(checkAdmin == true)
        {
            return InputPassword();
        }

        else 
        {
            return null;
        }
 }
    static void ShowAllRegisterInCampaign()
    {
        Console.Clear();
        Console.WriteLine("Show Person");
        Console.WriteLine("***************************");

        Program.personList.CountTeacher();
        Program.personList.CountStudent();
        Program.personList.CountScholar();
        Program.personList.CountStudent4();
        Program.personList.CountStudent5();
        Program.personList.CountStudent6();

        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenu();
    }
    static void ShowScholarInfo()
    {
       Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");
        Program.personList.FetchScholarList();
        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();
    }
    static void ShowStudentInfo()
    {
       Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");
        Program.personList.FetchStudentList();
        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();
    }
    static void ShowTeacherInfo()
    {
       Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");
        Program.personList.FetchTeacherList();
        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();
    }
    static void BlackToMenu()
    {
        Console.Clear();
        PrintRegisterMenu();
        InputMenuRegister();
    }

    static void BlackToMenuII()
    {
        Console.Clear();
        PrintMenuLogin();
        InputMenuLogin();
    }
    
    static string Inputprefix()
    {
        Console.WriteLine("1.Mr.");
         Console.WriteLine("2.Mrs.");
          Console.WriteLine("3.Miss.");
          Console.Write("Prefix: ");
         for(int i = 0; i  <= 0;){
          int Prefix = int.Parse(Console.ReadLine());
          if(Prefix==1)
          {
            return "Mr.";
              i++;
          }
          else if (Prefix==2)
          {
            return "Mrs.";
            i++;
          }
          else if (Prefix==3)
          {
            return "Miss.";
            i++;
          }
          else
          {
            Console.WriteLine("Please Enter only 1-3 :"); 
          }
    }
    return null;
    }
    static string InputName()
    {
        Console.Write("Name: ");
        return Console.ReadLine();
    }
    static string InputSurname()
    {
        Console.Write("Surname: ");
        return Console.ReadLine();
    }
    static string InputScholarID()
    {
        Console.Write("ScholarID: ");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Age: ");
        return Console.ReadLine();
    }
    static string InputAllergy()
    {
         Console.Write("Allergy: ");
        return Console.ReadLine();
    }
    static string InputReligion()
    {
     Console.WriteLine("Your Religion");   
     Console.WriteLine("**************");
     Console.WriteLine("1. Buddhist");
     Console.WriteLine("2. Christain");
     Console.WriteLine("3. Islam");
     Console.WriteLine("4. Other");
     Console.WriteLine("**************");
     Console.Write("Religion: ");
      for(int i = 0; i  <= 0;)
      {
     int Religion = int.Parse(Console.ReadLine());
     if(Religion==1)
     {
        return "Buddhist";
     }
     else if (Religion==2)
     {
        return "Christain";
     }
     else if (Religion==3)
     {
        return "Islam";
     }
     else if (Religion==4)
     {
        return "Other";
     }
    }
    return null;
    }
    static string Inputclass()
    {
        Console.WriteLine("1. M4");
        Console.WriteLine("2. M5");
        Console.WriteLine("3. M6");
        Console.Write("Class Level: ");
        for(int i = 0; i  <= 0;)
        {
        int Level = int.Parse(Console.ReadLine());
        if(Level==1)
        {
            return "M4";
        }
        else if(Level==2)
        {
            return "M5";
        }
        else if(Level==3)
        {
            return "M6";
        }
    }
    return null;
    }
    static string InputSchool()
    {
        Console.Write("SchoolName: ");
        return Console.ReadLine();
    }
    static string InputPosition()
    {
        Console.WriteLine("1.Dean");
        Console.WriteLine("2.Head of department");
        Console.WriteLine("3.Fulll-time teacher");
        Console.Write("Position: ");
        for(int i = 0; i  <= 0;){
        int Position = int.Parse(Console.ReadLine());
        if(Position==1)
        {
            return "Dean";
        }
        else if(Position==2)
        {
            return "Head of department";
        }
        else if(Position==3)
        {
            return "Fulll-time teacher";
        }
    }
    return null;
    }
    static string InputNumOfcar()
    {
        Console.Write("Do you have car(Y/N): ");
        string x = Console.ReadLine();
        if (x=="Y"||x=="y")
        {
            Console.Write("Num of car: ");
            return Console.ReadLine();
        }
       else if (x=="X"||x=="x") 
        {
            return null;

        }
       else
       {
        Console.WriteLine("Try again");
        return InputNumOfcar();
       } 
    }
    static bool InputAdministor()
    {
        Console.Write("Are you an admin(Y/N)");
        string y = Console.ReadLine();
        if(y=="Y"||y=="y")
        {
            return true;
        }
       else if (y=="X"||y=="x") 
        {
            return false;

        }
       else
       {
        Console.WriteLine("Try again");
        return InputAdministor();
       } 
    }
    static string InputEmail()
    {
        
            Console.Write("Email: ");
            return Console.ReadLine();


    }
    static string InputPassword()
    {
    
            Console.Write("Password: ");
            return Console.ReadLine();


    }
}