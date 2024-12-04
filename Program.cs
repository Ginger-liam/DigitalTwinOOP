var robot = new BasicRobot("BRUHBOT");

robot.AddSensor(new MoistureSensor());
robot.AddSensor(new DistanceSensor());
robot.AddSensor(new ButtonSensor(10)); // Button sensor will be pressed for 10 seconds

var retrievedMoistureSensor = robot.GetSensor<MoistureSensor>();
var retrievedDistanceSensor = robot.GetSensor<DistanceSensor>();
var retrievedButtonSensor = robot.GetSensor<ButtonSensor>();

while (retrievedButtonSensor.GetMeasurement() == 1)
{
  if (retrievedDistanceSensor.GetMeasurement() < 1000)
  {
    robot.TurnRobot("left", 90);
  }

  robot.LogMeasurements();
  robot.DisplayMeasurementLog();

  Thread.Sleep(1000);
}
