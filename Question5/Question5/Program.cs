using System;
using System.Collections;

public interface IActivity
{
    void Execute();
}

public class WorkflowEngine
{
    public void Run(ArrayList workflow)
    {
        foreach (IActivity activity in workflow)
        {
            activity.Execute();
        }
    }
}

// Example of a concrete activity
public class UploadFileActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Uploading file...");
        
    }
}

// Example of another concrete activity
public class SendEmailActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Sending email...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //workflow engine
        WorkflowEngine engine = new WorkflowEngine();

        // Created an array list of activities for the workflow
        ArrayList workflow = new ArrayList();
        workflow.Add(new UploadFileActivity());
        workflow.Add(new SendEmailActivity());

        engine.Run(workflow);
    }
}

