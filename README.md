# HS100-WIN-CONTROL

TP-Link HS100 WiFi socket controller for Windows. Written in VB.NET.

## Introduction

I own a couple of TP-Link HS100 WiFi sockets.

When I’m using my PC, it’s a minor pain to have to unlock my phone, open the Kasa app, wait for it to finish displaying the infernal splashscreen, then turn on my socket.

What I wanted was a program sitting in the windows tray to control them. So that’s what I made. It’s in VB.NET. All you need to do is toggle a switch icon on your taskbar.

![Taskbar view](http://chris-stubbs.co.uk/wp/wp-content/uploads/2018/04/wifi2.png)
[![GUI view](http://chris-stubbs.co.uk/wp/wp-content/uploads/2018/04/wifi1-150x150.png)](http://chris-stubbs.co.uk/wp/wp-content/uploads/2018/04/wifi1.png)

## Instructions for use


### Installing

Uninstall any old versions.  
Download [installer.zip](https://github.com/chrisstubbs93/HS100-WIN-CONTROL/raw/master/installer.zip).  
Extract and run setup.exe.  

## Use
### GUI mode

GUI mode is started by default.

1. Log in to a cloud account in the Kasa app, and make sure at least one device is associated with your account. Give them names if it’s helpful.

2. Download and install my program.

3. Put in your Kasa account details and click the “update devices list button”
The list should be populated with the details of each device you have connected. You can click each one and control it from this screen. Notifyicons will also be created in the system tray for each device.

4. If you click the x (close) in the top right of the program, it will minimise to the tray.
You can mouse over the tray icons to see their name, and click them to toggle the state. Right clicking any icon will open the menu again.

5. I recommend you tick the “start in system tray” box and "Start with Windows".



### CLI mode
Since version 2.0.0.0 a command line interface can be used to control your TP-Link devices through this program. It is used as follows (you can copy this in to a batch file in the same directory as the program to try it):

```
TPLink_HS100_controller.exe /mode=1 /email=your@mail.co.uk /pass=1234 /id=12345AB1234A1A1234A12345AB123456789ABCD1
```
/mode=1 - Turn on device.  
/mode=0 - Turn off device.  
/mode=T - Toggle state of device.  
/email= and /pass= should be the email address and password you use to sign in to your Kasa account.  
/id= should contain the ID of the device you wish to control. This ID can be obtained by using the GUI version of the program and right clicking the name of the device in question to copy its ID.
![Copying ID](http://chris-stubbs.co.uk/wp/wp-content/uploads/2019/06/copyID.png)

## Known bugs

I have noticed device status may = 0 when using a VPN. On/off control still seems to work, but behavior may be odd. The TP-Link backend knows you are in a different region.

## Requests

If you would like to make a commercial inquiry to request a custom feature, please email contact@chris-stubbs.co.uk.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Disclaimer

This program has no affiliation with itnerd.space or tp-link. I accept no liability for its use. This program is provided without warranty/guarantee. 

## Acknowledgments
This is heavily based on the API research over at [itnerd.space](http://itnerd.space/2017/06/19/how-to-authenticate-to-tp-link-cloud-api/).
