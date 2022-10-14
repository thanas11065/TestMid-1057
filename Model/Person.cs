public abstract class Person{
    private string prefix;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;

    public Person(string prefix,string name, string surname,string age,string religion,string allergy){
        this.prefix = prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.religion = religion;
        this.allergy = allergy;
        
    }

    public string PREFIX(){
        return this.prefix;
    }
    public string NAME(){
        return this.name;
    }
    public string SURNAME(){
        return this.surname;
    }
    public string AGE(){
        return this.age;
    }
    public string RELIGION(){
        return this.religion;
    }
    public string ALLERGY(){
        return this.allergy;
    }
}
