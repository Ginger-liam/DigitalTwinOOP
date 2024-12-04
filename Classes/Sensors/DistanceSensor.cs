public class DistanceSensor : ISettableSensor
{
  private int currentDistance;

  public DistanceSensor()
  {
    currentDistance = new Random().Next(0, 5000);
  }

  public void SetSensorValue(int value)
  {
    currentDistance = value;
  }

  public int GetMeasurement()
  {
    currentDistance = new Random().Next(0, 5000);

    return currentDistance;
  }

  public string GetMeasurementsAsString()
  {
    return currentDistance.ToString();
  }
}
