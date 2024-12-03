public class ButtonSensor : ISensor
{
  private int buttonPressed;

  public ButtonSensor()
  {
    buttonPressed = new Random().Next(0, 2);
  }

  public int GetMeasurement()
  {
    return buttonPressed;
  }

  public string GetMeasurementsAsString()
  {
    return (buttonPressed == 1) ? "Button is pressed" : "Button is not pressed";
  }
}
