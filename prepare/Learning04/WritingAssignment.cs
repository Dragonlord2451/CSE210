public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {_title}";
    }

    public string GetStudentName()
    {
        return _StudentName ; // or change _studentName to protected in base class
    }
}
