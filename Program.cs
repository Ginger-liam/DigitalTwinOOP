BasicRobot basicRobot = new BasicRobot("Basic Robot");

basicRobot.AddSensor(new TempSensor());
basicRobot.AddSensor(new LightSensor());
basicRobot.AddSensor(new LightSensor());
basicRobot.AddSensor(new ButtonSensor());

// basicRobot.SetSensorValue(50, "LightSensor");

basicRobot.DisplaySensorValues();
