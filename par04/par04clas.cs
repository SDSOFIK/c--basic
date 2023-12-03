using System.Threading.Channels;

namespace par04;
//class

 public class student
{
    public string name ;
    
    public double Class ;
    public double roll;
    public double id;
}


 //constructor

public class mayClas 
{
  public  string name;
    
   public int id;
    public int salary;
    public mayClas(string name, int id, int salary )
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
        
    }

     public void showData()
    {
        Console.WriteLine($"my name is : {name} \n my id on : {id} \n salary : {salary}");
    }


}


//static

public class staric()
{
    public static float pi = 3.1416f;

}

//static-constructor

public class tacsoftSalary
{
    public string name;
    public int id;
    public float salary;
    public static float bonus = 400.679f;

    public tacsoftSalary(string name, int id, float salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Your name: {name}, Your id: {id}, Bonus: {bonus}, Salary: {salary + bonus}");
    }
}
// inheritance 
public class father
{
    public string name;
    public int id;

} 
public class child : father
{
    public int age;
}

public class input
{
public int num; 
}
