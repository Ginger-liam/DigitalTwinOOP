public class BasicRobot
{
  public string RobotName;
  private List<ISensor> sensors;

  public BasicRobot(string name)
  {
    RobotName = name;
    sensors = new List<ISensor>();
  }

  public void AddSensor(ISensor sensor)
  {
    sensors.Add(sensor);
  }

  public void SetSensorValue(int value, string sensorType)
  {
    foreach (var sensor in sensors)
    {
      if (sensor.GetType().Name == sensorType)
      {
        if (sensor is LightSensor)
        {
          ((LightSensor)sensor).SetLightValue(value);
        }
        else
        {
          Console.WriteLine("This sensor does not have a value to set.");
        }
      }
    }
  }

  public void DisplaySensorValues()
  {
    foreach (var sensor in sensors)
    {
      Console.WriteLine($"{sensor.GetType().Name} value: {sensor.GetMeasurementsAsString()}");
    }
  }
}
