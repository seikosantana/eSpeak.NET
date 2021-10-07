# eSpeak.NET
A .NET wrapper for eSpeak, an open source speech synthesizer.

## Introduction
eSpeak.NET is inteded to bring easy-to-use speech synthesize library for .NET. The current verion targets .NET Framework 4.6, but a .NET (.NET Core) or newer port will be considered. eSPeak.NET might not be a direct replacement for System.Speech (which is not available on Mono or .NET outside Windows ecosystem). Some more effort would have to be done to allow this library to work on Linux with Mono and .NET  

eSpeak.NET interacts with the command-line executable of eSpeak behind the curtains. That means eSpeak has to be present in the machine to have eSpeak operable.   
### Useful Links
- http://espeak.sourceforge.net/
- http://espeak.sourceforge.net/download.html
- http://espeak.sourceforge.net/commands.html
- http://espeak.sourceforge.net/voices.html  

## How to Use
### First Things First
As mentioned above, eSpeak has to be present on the machine since eSpeak.NET relies on it. See [this link](http://espeak.sourceforge.net/download.html) to download the installer or binary for your machine.

### Getting eSpeak.NET
There is currently no release, dll, or NuGet package available yet. So the only way (for now) is by cloning this repository and build the `eSpeak` project in the solution to get the dll file. Then reference the dll file in your project, simply add the project to your solution and reference the `eSpeak` project.

### A Demo
A demo is provided in the solution to demonstrate what you can do with the eSpeak.NET library.  
![Demo app screenshot](https://github.com/seikosantana/eSpeak.NET/blob/master/eSpeak.png?raw=true)

## How Does It Work
There's nothing much done by this project. eSpeak binary takes care of everything about sounds, pitches, speed, gaps, languages, even accents. What the library actually does is just starting and passing command line arguments to the eSpeak command-line binary so developers can focus on the application itself rather than the process of generating speech.

### Some Footnotes
This library might not be for you if:
- You need more flexibility in starting and terminating the eSpeak process
- You need to access more specific features of eSpeak with the command line that is not (yet) provided in this library. Accents, gaps, and many more things are not provided in this library to keep it simple. See [this link](http://espeak.sourceforge.net/commands.html) for full list of things you can achieve with the command line.
- You are working with Windows operating system and English language, which is already provided in System.Speech namespace.  

Any suggestion and pull requests are welcome.  
Have a nice day.
