using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace eSpeak
{
    /// <summary>
    /// Variant is a file within the espeak-data/voices/!v directory
    /// </summary>
    public enum Variant
    {
        None,
        Male1, Male2, Male3, Male4, Male5, Male6, Male7,
        Female1, Female2, Female3, Female4
    }

    /// <summary>
    /// A class representing a speaker profile.
    /// </summary>
    public class Speaker
    {

        /// <summary>
        /// Creates a Speaker object with eSpeak from a specified path.
        /// </summary>
        /// <param name="eSpeakPath">Path to eSpeak executable</param>
        public Speaker(string eSpeakPath)
        {
            this.eSpeakPath = eSpeakPath;
        }

        /// <summary>
        /// Creates instance of Speaker by searching in installation path. Default path is %ProgramFiles(x86)%\eSpeak\command_line.
        /// </summary>
        /// <returns></returns>
        public static Speaker FromInstalled()
        {
            return new Speaker(FindInProgramFIles());
        }

        static string FindInProgramFIles()
        {
            string programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string eSpeakPath = Path.Combine(programFilesPath, "eSpeak", "command_line", "espeak.exe");
            if (File.Exists(eSpeakPath))
            {
                return eSpeakPath;
            }
            else
            {
                throw new Exception("eSpeak installation is not found.");
            }
        }

        string eSpeakPath;

        /// <summary>
        /// A Voice file specifies a language (and possibly a language variant or dialect)
        /// together with various attributes that affect the characteristics of the voice
        /// quality and how the language is spoken.
        /// </summary>
        public string VoiceLanguage { get; set; }

        /// <summary>
        /// <variant> is a file within the espeak-data/voices/!v directory. Only basic
        /// variants are supported.
        /// </summary>
        public Variant Variant { get; set; }

        /// <summary>
        /// Sets the speed in words-per-minute (approximate values for the default
        /// English voice, others may differ slightly). The default value is 175.
        /// I generally use a faster speed of 260. The lower limit is 80.
        /// There is no upper limit, but about 500 is probably a practical maximum.
        /// </summary>
        public int Speed { get; set; } = 175;

        /// <summary>
        /// Adjusts the pitch in a range of 0 to 99. The default is 50.
        /// </summary>
        public int Pitch { get; set; } = 50;

        string GetVoiceArg(string voiceLanguage, Variant variant)
        {
            string result = "";
            if (!string.IsNullOrEmpty(voiceLanguage) || variant != Variant.None)
            {
                result = "-v" + voiceLanguage;
                switch (variant)
                {
                    case Variant.Male1:
                        result += "+m1";
                        break;
                    case Variant.Male2:
                        result += "+m2";
                        break;
                    case Variant.Male3:
                        result += "+m3";
                        break;
                    case Variant.Male4:
                        result += "+m4";
                        break;
                    case Variant.Male5:
                        result += "+m5";
                        break;
                    case Variant.Male6:
                        result += "+m6";
                        break;
                    case Variant.Male7:
                        result += "+m7";
                        break;
                    case Variant.Female1:
                        result += "+f1";
                        break;
                    case Variant.Female2:
                        result += "+f2";
                        break;
                    case Variant.Female3:
                        result += "+f3";
                        break;
                    case Variant.Female4:
                        result += "+f4";
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        string GetSpeedArg()
        {
            return "-s " + Speed;
        }

        string GetPitchArg()
        {
            return "-p " + Pitch;
        }

        /// <summary>
        /// Speaks a text with profile set in properties of the speaker instance synchronously
        /// </summary>
        /// <param name="text">Text to be spoken</param>
        public void SpeakText(string text)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = eSpeakPath,
                WindowStyle = ProcessWindowStyle.Minimized,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"{GetVoiceArg(VoiceLanguage, Variant)} {GetSpeedArg()} {GetPitchArg()} \"{text}\""
            };
            Process.Start(startInfo).WaitForExit();
        }

        /// <summary>
        /// Speaks text in a specified text file.
        /// </summary>
        /// <param name="textFilePath">Path to the text file</param>
        public void SpeakTextFile(string textFilePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = eSpeakPath,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"{GetVoiceArg(VoiceLanguage, Variant)} {GetSpeedArg()} {GetPitchArg()} -f {textFilePath}"
            };
            Process.Start(startInfo).WaitForExit();
        }

        /// <summary>
        /// Async version of SpeakText()
        /// </summary>
        /// <param name="text">Text to be spoken</param>
        /// <returns>A task that completes after eSpeak finished speaking.</returns>
        public async Task SpeakTextAsync(string text)
        {
            await Task.Run(() =>
            {
                SpeakText(text);
            });
        }

        /// <summary>
        /// Async version of SpeakTextFile()
        /// </summary>
        /// <param name="text">Path to the text file</param>
        /// <returns>A task that completes after eSpeak finished speaking.</returns>
        public async Task SpeakTextFileAsync(string textFilePath)
        {
            await Task.Run(() =>
            {
                SpeakTextFile(textFilePath);
            });
        }

    }
}
