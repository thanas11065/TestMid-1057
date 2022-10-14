using System.Collections.Generic;

public class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
        int num = 0;
        num++;
    }
       
       public void FetchScholarList()
    {
        Console.WriteLine("List Scholar");
        Console.WriteLine("***************************");

        foreach(Person person in this.personList)
        {
            if(person is ScholarInfo)
            {
                Console.WriteLine("{0} {1} {2}", person.PREFIX(), person.NAME(), person.SURNAME());
            }
        }
    }
    public void FetchStudentList()
    {
        Console.WriteLine("List Student");
        Console.WriteLine("***************************");

        foreach(Person person in this.personList)
        {
            if(person is StudentInfo)
            {
                Console.WriteLine("{0} {1} {2}", person.PREFIX(), person.NAME(), person.SURNAME());
            }
        }
    }
    public void FetchTeacherList()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("***************************");

        foreach(Person person in this.personList)
        {
            if(person is TeacherInfo)
            {
                Console.WriteLine("{0} {1} {2}", person.PREFIX(), person.NAME(), person.SURNAME());
            }
        }
    }
    public bool CheckLogin(string email, string password)
    {
         foreach(Person person in this.personList)
         {
            if(person is TeacherInfo teacherInfo)
            {
                if(teacherInfo.EMAIL() == email && teacherInfo.PASSWORD() == password)
                {
                    return true;
                }
            }
            else if(person is ScholarInfo scholarInfo)
            {
                if(scholarInfo.EMAIL() == email && scholarInfo.PASSWORD() == password)
                {
                    return true;
                }
            }
         }  
         return false;
    }

    public void CountTeacher()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is TeacherInfo TeacherInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("Teacher : {0}", num);
    }

    public void CountStudent()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is StudentInfo StudentInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("Student : {0}", num);
    }

    public void CountScholar()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is ScholarInfo scholarInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("Scholar : {0}", num);
    }

    public void CountStudent4()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.4")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.4 : {0}", num);
    }

    public void CountStudent5()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.5")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.5 : {0}", num);
    }

    public void CountStudent6()
    {
        int num = 0;
         foreach(Person person in this.personList)
        {
            if(person is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.6")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.6 : {0}", num);
    }
}
