/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Abstraction Learning Activity
/// Create resume class
/// Add a Display method to the Resume class
/// Display resume details using method call
/// </summary>

public class Resume
{
    //Fields
    public string _name;
    public List<Job> _jobList = [];    

    //Display resume details
    public void DisplayResumeDetails()
    {
        //Display name
        Console.WriteLine(_name);

        //Display jobs details by iterative call to job Display method
        foreach (var item in _jobList)
        {
            item.DisplayJobDetails();
        };
    }
    
}


