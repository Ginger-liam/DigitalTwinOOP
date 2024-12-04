public interface ISettableSensor : ISensor
{
  void SetSensorValue(int value);
  int GetMeasurement();
}
