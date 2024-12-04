public class ButtonSensor : ISettableSensor
{
  private int buttonPressed;
  private int counter = 0;
  private int runDuration;

  public ButtonSensor(int runDuration)
  {
    buttonPressed = 1;
    this.runDuration = runDuration;
  }

  public void SetSensorValue(int value)
  {
    buttonPressed = value;
  }

  public int GetMeasurement()
  {
    counter++;
    return buttonPressed = (counter > runDuration) ? 0 : 1;
  }

  public string GetMeasurementsAsString()
  {
    return (buttonPressed == 1) ? "Button is pressed" : "Button is not pressed";
  }
}
