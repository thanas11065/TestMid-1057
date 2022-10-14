public class TeacherInfo : Person{
public string position;
public string numOfcar;
private string email;
private string password;
private bool checkAdmin;

public TeacherInfo(string prefix,string name,string surname,string position,string age,string religion,string allergy,bool checkAdmin,string email,string password,string numOfcar)
 : base(prefix,name,surname,age,religion,allergy)
 {
 this.numOfcar=numOfcar;
 this.email=email;
 this.password=password;
 this.checkAdmin=false;
 }
   public bool CheckAdmin()
    {
        return this.checkAdmin;
    }

    public string EMAIL()
    {
        return this.email;
    }
    public string PASSWORD()
    {
        return this.password;
    }
}
