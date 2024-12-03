public class TempSensor : ISensor
{
  private int tempValue;

  public TempSensor()
  {
    tempValue = new Random().Next(0, 100);
  }

  public int GetMeasurement()
  {
    return tempValue;
  }

  public string GetMeasurementsAsString()
  {
    return tempValue.ToString();
  }
}
