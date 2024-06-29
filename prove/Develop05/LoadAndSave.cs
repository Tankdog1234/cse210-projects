public class LoadAndSave
{
    protected int _points;
    string _fileName;
    static protected List <Goal> _goals;
    static List <string> _goalString;

    public LoadAndSave()
    {
        _points = 0;
        _goalString = new List<string>();
        _goals = new List<Goal>();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file would you like to save to? 'example.txt'");
        _fileName = Console.ReadLine();
        GetStringRepresentation(); //split the object data into a computer readable format

        StreamWriter outputFile = new StreamWriter(_fileName, false);
            outputFile.WriteLine(_points);
            foreach (string goal in _goalString)
            {
                outputFile.WriteLine(goal);
            }
        outputFile.Close();
    }
    
    public void LoadGoals()
    {
        Console.WriteLine("What file would you like to load from? 'example.txt'");
        _fileName = Console.ReadLine();
        string[] linesArray = File.ReadAllLines(_fileName);

        _points = int.Parse(linesArray[0]);
        for(int i = 1; i < linesArray.Length; i++)
        {
            string[] objType = linesArray[i].Split('|'); //grabs the object type from the line
            string[] objData = objType[1].Split('~'); //splits the object data from the line
            if(objType[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(objData[0], objData[1], int.Parse(objData[2]), bool.Parse(objData[3])));
            }
            else if(objType[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(objData[0], objData[1], int.Parse(objData[2]), int.Parse(objData[3])));
            }
            else if(objType[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(objData[0], objData[1], int.Parse(objData[2]), int.Parse(objData[3]), int.Parse(objData[4]), int.Parse(objData[5])));
            }
        }
    }
    public void GetStringRepresentation()
    {
        //split the object data into a computer readable format
        foreach(Goal goal in _goals)
        {
            _goalString.Add(goal.GetRawGoalData());
        }
    }
}