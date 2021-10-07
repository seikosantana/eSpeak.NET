using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using eSpeak;

namespace Driver
{
    public partial class DemoForm : Form
    {

        Speaker speaker;
        OpenFileDialog fileDialog;

        public DemoForm()
        {
            InitializeComponent();
            btnSpeakText.Click += SpeakText;
            Load += FormLoad;
            cbVariants.SelectedValueChanged += VariantChanged;
            txtLanguage.TextChanged += LanguageChanged;
            nmPitch.ValueChanged += PitchChanged;
            nmSpeed.ValueChanged += SpeedChanged;
            btnChooseFile.Click += ChooseFile;
            btnSpeakTextFile.Click += SpeakTextFile;
            txtTextFilePath.TextChanged += FilePathChanged;
            txtText.TextChanged += SpeakTextChanged;
            linkGithub.Click += GoToGithub;
            linkSourceforge.Click += GotoSourceforge;
        }

        private void GotoSourceforge(object sender, EventArgs e)
        {
            Process.Start("http://espeak.sourceforge.net/");
        }

        private void GoToGithub(object sender, EventArgs e)
        {
            Process.Start("https://github.com/seikosantana/eSpeak.net");
        }

        private void SpeakTextChanged(object sender, EventArgs e)
        {
            btnSpeakText.Enabled = !string.IsNullOrEmpty(txtText.Text.Trim());
        }

        private void FilePathChanged(object sender, EventArgs e)
        {
            btnSpeakTextFile.Enabled = !string.IsNullOrEmpty(txtTextFilePath.Text.Trim());
        }

        private async void SpeakTextFile(object sender, EventArgs e)
        {
            await speaker.SpeakTextFileAsync(txtTextFilePath.Text);
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            var dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtTextFilePath.Text = fileDialog.FileName;
            }
        }

        private void SpeedChanged(object sender, EventArgs e)
        {
            speaker.Speed = Convert.ToInt32(nmSpeed.Value);
        }

        private void PitchChanged(object sender, EventArgs e)
        {
            speaker.Pitch = Convert.ToInt32(nmPitch.Value);
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            speaker.VoiceLanguage = txtLanguage.Text;
        }

        private void VariantChanged(object sender, EventArgs e)
        {
            speaker.Variant = (Variant)cbVariants.SelectedItem;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            try
            {
                speaker = Speaker.FromInstalled();
                cbVariants.DataSource = Enum.GetValues(typeof(Variant));
                fileDialog = new OpenFileDialog()
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Choose a text file"
                };
                txtLanguage.Text = "id";
            }
            catch
            {
                MessageBox.Show("eSpeak installation cannot be found.");
            }
        }

        private async void SpeakText(object sender, EventArgs e)
        {
            await speaker.SpeakTextAsync(txtText.Text);
        }
    }
}
