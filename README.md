# IOTLinkTTS
Allows you to make a remote computer say something using <a href='https://iotlink.gitlab.io/'>IOT Link</a>


## Install Guide
Grab a release from <a href='https://github.com/rossdargan/IOTLinkTTS/releases'>the releases view</a> and copy it into the IOT link addons folder (create a child folder for them), then restart IOT Link.

## Usage (from home assistant)
```
service: mqtt.publish
data:
  topic: {prefix}/{domain}/{machineName}/tts-commands/speak
  payload: The message to speak!
```


