using Practical6;
class Program
{
    public static void Main(string[] args)
    {
        ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
        processBusinessLogic.ProcessCompleted += bl_ProcessCompleted;
        processBusinessLogic.StartProcess();
    }

    /// <summary>
    /// When StartProcess will complete bl_ProcessCompleted method will called.
    /// </summary>
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked");
    }
}