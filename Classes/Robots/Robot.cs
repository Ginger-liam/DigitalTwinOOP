public class BasicRobot
{
  public string RobotName;
  private List<ISettableSensor> sensors;
  private List<Measurement> measurementLog;

  public BasicRobot(string name)
  {
    RobotName = name;
    sensors = new List<ISettableSensor>();
    measurementLog = new List<Measurement>();
  }

  public void AddSensor(ISettableSensor sensor)
  {
    sensors.Add(sensor);
  }

  public T GetSensor<T>() where T : ISensor
  {
    return (T)sensors.Find(sensor => sensor is T);
  }

  public void DisplaySensorValues()
  {
    foreach (var sensor in sensors)
    {
      Console.WriteLine($"{sensor.GetType().Name} value: {sensor.GetMeasurementsAsString()}");
    }
  }

  public void TurnRobot(string direction, int degrees)
  {
    switch (direction)
    {
      case "left":
        Console.WriteLine($"{RobotName} is turning left, {degrees} degrees");
        break;
      case "right":
        Console.WriteLine($"{RobotName} is turning right, {degrees} degrees");
        break;
    }
  }

  public void LogMeasurements()
  {
    foreach (var sensor in sensors)
    {
      measurementLog.Add(new Measurement(sensor.GetMeasurement(), sensor.GetType().Name));
    }
  }

  public void DisplayMeasurementLog()
  {
    foreach (var measurement in measurementLog)
    {
      Console.WriteLine($" measurement: {measurement.Value}, {measurement.Type}");
    }
  }
}
