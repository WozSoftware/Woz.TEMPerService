# Woz.TEMPerService

A simple C# ASP.NET REST service to read all TEMPer sensors plugged into the host machine

To call:


```
http://localhost:PORTNUM/temperature
```

The results are in JSON

```
[ 
   { 
      "date":"2020-01-01T12:59:31.6860333+13:00",
      "sensorType":"TEMPerV14",
      "deviceId":"\\\\?\\hid#vid_0c45&pid_7401&mi_01#7&b37c9c6&0&0000#{4d1e55b2-f16f-11cf-88cb-001111000030}",
      "manufacturer":"RDing",
      "temperature":26.75,
      "error":null
   }
]
```
