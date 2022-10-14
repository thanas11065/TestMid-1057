public class ScholarInfo : Person{
public string scholarID;
public bool checkAdmin;
private string email;
private string password;
public ScholarInfo(string prefix,string name,string surname,string scholarID,string age,string religion,string allergy,bool checkAdmin,string email,string password)
 : base(prefix,name,surname,age,religion,allergy)
 {
    this.scholarID = scholarID;
    this.email = email;
    this.password = password;
    this.checkAdmin = false;
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
