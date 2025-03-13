using System.Security.Cryptography.X509Certificates;

public class Resume
{
    // Class attributes
    public string _name;
    // attribut of a list containing Job Class instances.
    public List<Job> _jobs = new List<Job>();

    // Class methods
    public void DisplayMyResume()
    {
        // display person's name and then iterate each Job instance 
        // in list _jobs and display them
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job instanceJob in _jobs)
        {
            // Calls Job Class's DisplayJobDetails method on each instanceJob
            instanceJob.DisplayJobDetails();
        }
    }
}