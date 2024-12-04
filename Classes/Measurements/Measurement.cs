public class Measurement
{
  public int Value { get; }
  public string Type { get; }

  public Measurement(int value, string type)
  {
    Value = value;
    Type = type;
  }
}
