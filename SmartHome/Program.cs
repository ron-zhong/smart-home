using YeelightAPI;

var device = new Device("192.168.18.20");
await device.Connect();

for (var i = 0; i < 10; ++i)
{
    await Task.Delay(1000);
    await device.Toggle();
}
