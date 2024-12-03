public class LightSensor : ISensor
{
  private int lightValue;

  public LightSensor()
  {
    lightValue = new Random().Next(0, 100);
  }

  public void SetLightValue(int value)
  {
    lightValue = value;
  }

  public int GetMeasurement()
  {
    return lightValue;
  }

  public string GetMeasurementsAsString()
  {
    return lightValue.ToString();
  }
}
