public class MoistureSensor : ISettableSensor
{
  private int moistureLevel;

  public MoistureSensor()
  {
    moistureLevel = new Random().Next(0, 50);
  }

  public void SetSensorValue(int value)
  {
    moistureLevel = value;
  }

  public int GetMeasurement()
  {
    moistureLevel = new Random().Next(0, 50);

    return moistureLevel;
  }

  public string GetMeasurementsAsString()
  {
    return moistureLevel.ToString();
  }
}
