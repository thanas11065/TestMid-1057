public class StudentInfo: Person
{
    public string school;
    public string grade;
 

    public StudentInfo(string prefix,string name,string surname,string grade,string age,string religion,string allergy,string school)
   : base(prefix,name,surname,age,religion,allergy)
   {
    this.school=school;
    this.grade=grade;
   }
    public string GetEducationLevel()
    {
        return this.grade;
    }
    public string SCHOOL()
    {
        return this.school;
    }
}