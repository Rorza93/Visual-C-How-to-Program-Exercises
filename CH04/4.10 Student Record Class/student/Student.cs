// Student.cs
// a class that contains the student records

class Student
{ 
    public string StudentID { get; set; }   // auto implement variable
    public string StudentName { get; set; } // auto implement variable
    private decimal classMaths;             // instance variable
    private decimal classEnglish;           // instance variable
    private decimal classHistory;           // instance variable

    // Student constructor that reveives five parameters
    public Student(string studentID, string studentName, decimal classMaths, decimal classEnglish, decimal classHistory)
    {
        StudentID = studentID;
        StudentName = studentName;
        ClassMaths = classMaths;
        ClassEnglish = classEnglish;
        ClassHistory = classHistory;
    }

    // ClassMaths property with validation
    public decimal ClassMaths
    {
        get { return classMaths; }
        private set
        { 
            if (value > 0)
            {
                classMaths = value;
            }
        }
    }

    // ClassEnglish property with validation
    public decimal ClassEnglish
    {
        get { return classEnglish; }
        private set
        {
            if (value > 0)
            {
                classEnglish = value;
            }
        }
    }

    // ClassHistory property with validation
    public decimal ClassHistory
    {
        get { return classHistory; }
        private set
        {
            if (value > 0)
            {
                classHistory = value;
            }
        }
    }

    // method to print Student Records
    public void getRecords()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Maths Results: {ClassMaths}");
        Console.WriteLine($"English Results: {ClassEnglish}");
        Console.WriteLine($"History Results: {ClassHistory}");
    }

    // method to print aggregate sum of grades
    public void getAggregate()
    {
        decimal aggregate = (ClassEnglish + ClassHistory + ClassMaths);
        Console.WriteLine($"The aggregate score for {StudentName} is : {aggregate}");
    }

    // method to print the students score percentage
    public void getPercentage()
    {
        decimal maxScore = 50m;
        decimal aggregate = (ClassEnglish + ClassHistory + ClassMaths);
        int classes = 3;
        decimal percentage = (aggregate / (maxScore * classes) * 100m);
        
        Console.WriteLine($"{StudentName} has received a score of {percentage}%");
    }
}