using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using System.Security.Cryptography;
using System.Threading;

namespace QTGMC_FFMPEG_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Get the host (directory of origin) for this file
            string tempfolderpath = Directory.GetCurrentDirectory() + "\\temp\\";
            string configfilepath = Directory.GetCurrentDirectory() + "\\settings.ini";
            var MyIni = new IniFile("settings.ini");

            if (!Directory.Exists(tempfolderpath))
            {
                Directory.CreateDirectory(tempfolderpath);
            }
            if (!File.Exists(configfilepath))
            {
                MyIni.Write("FFMPEG Location",  "C:\\TEMP\\ffmpeg.exe");
                MyIni.Write("DGIndex Location", "C:\\TEMP\\dgindex.exe");
                MyIni.Write("Last SDR7 Source", "C:\\TEMP\\sdr7.mod");
                MyIni.Write("Last SDR7 Batch Source", "C:\\TEMP\\");
                MyIni.Write("Last SDR7 Output", "C:\\TEMP\\");
                MyIni.Write("Last SDR7 Batch Output", "C:\\TEMP\\");
                MyIni.Write("Last Aspect Ratio", "16:9");
                ffmpeg_loc_textbox.Text = "C:\\TEMP\\ffmpeg.exe";
                dgindex_loc_textbox.Text = "C:\\TEMP\\dgindex.exe";
                aspectSelector169.Checked = true;
                aspectSelector43.Checked = false;
            }
            else
            {
                var ffmpeg_location = MyIni.Read("FFMPEG Location");
                var dgindex_location = MyIni.Read("DGIndex Location");
                var last_aspect_ratio = MyIni.Read("Last Aspect Ratio");
                ffmpeg_loc_textbox.Text = ffmpeg_location;
                dgindex_loc_textbox.Text = dgindex_location;
                if (last_aspect_ratio=="16:9")
                {
                    aspectSelector169.Checked = true;
                    aspectSelector43.Checked = false;
                }
                else if (last_aspect_ratio == "4:3")
                {
                    aspectSelector169.Checked = false;
                    aspectSelector43.Checked = true;
                }
                else
                {
                    MyIni.Write("Last Aspect Ratio", "16:9");
                    aspectSelector169.Checked = true;
                    aspectSelector43.Checked = false;
                }

            }
        }

        private void button_set_ffmpeg_folder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string ffmpeg_location_exe = Directory.GetCurrentDirectory();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ffmpeg_location_exe;
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    ffmpeg_loc_textbox.Text = filePath;
                }
            }
        }

        private void button_set_dgindex_folder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string dgindex_location_exe = Directory.GetCurrentDirectory();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = dgindex_location_exe;
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    dgindex_loc_textbox.Text = filePath;
                }
            }
        }

        private void button_save_settings_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile("settings.ini");
            MyIni.Write("FFMPEG Location", ffmpeg_loc_textbox.Text.Trim());
            MyIni.Write("DGIndex Location", dgindex_loc_textbox.Text.Trim());
            if (aspectSelector169.Checked == true)
            {
                MyIni.Write("Last Aspect Ratio", "16:9");
            }
            else if (aspectSelector43.Checked == true)
            {
                MyIni.Write("Last Aspect Ratio", "4:3");
            }
            else
            {
                MyIni.Write("Last Aspect Ratio", "16:9");
                aspectSelector169.Checked = true;
                aspectSelector43.Checked = false;
            }
            
        }

        private void autosave_aspect_ratio ()
        {
            var MyIni = new IniFile("settings.ini");
            if ((aspectSelector169.Checked == true && MyIni.Read("Last Aspect Ratio") == "16:9") || (aspectSelector43.Checked == true && MyIni.Read("Last Aspect Ratio") == "4:3"))
            { }
            else
            {
                if (aspectSelector169.Checked == true)
                {
                    MyIni.Write("Last Aspect Ratio", "16:9");
                }
                else if (aspectSelector43.Checked == true)
                {
                    MyIni.Write("Last Aspect Ratio", "4:3");
                }
                else
                {
                    MyIni.Write("Last Aspect Ratio", "16:9");
                    aspectSelector169.Checked = true;
                    aspectSelector43.Checked = false;
                }
            }
        }

        private void button_sdr7_source_file_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var MyIni = new IniFile("settings.ini");
            var sdr7_mod_location = MyIni.Read("Last SDR7 Source");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = sdr7_mod_location;
                openFileDialog.Filter = "MOD files (*.mod)|*.mod";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePathX = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePathX);
                    string folderName = Path.GetDirectoryName(filePathX);
                    sdr7_source_file.Text = filePathX;
                    MyIni.Write("Last SDR7 Source", folderName);
                }
            }
        }

        private void button_sdr7_output_folder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var MyIni = new IniFile("settings.ini");
            var sdr7_output = MyIni.Read("Last SDR7 Output");

            string dummyFileName = "Save Results Here";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;
            sf.InitialDirectory = sdr7_output;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                sdr7_output_folder.Text = savePath;
                MyIni.Write("Last SDR7 Output", savePath);
            }
        }

        private void button_sdr7_batch_source_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var MyIni = new IniFile("settings.ini");
            var batch_files_loc = MyIni.Read("Last SDR7 Batch Source");

            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string loadPath = fbd.SelectedPath;
                    sdr7_batch_source_file.Text = loadPath;
                    MyIni.Write("Last SDR7 Batch Source", loadPath);
                }
            }
        }

        private void button_sdr7_batch_output_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var MyIni = new IniFile("settings.ini");
            var batch_sdr7_output = MyIni.Read("Last SD7 Batch Output");

            string dummyFileName = "Save Results Here";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;
            sf.InitialDirectory = batch_sdr7_output;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                sdr7_batch_output_folder.Text = savePath;
                MyIni.Write("Last SDR7 Batch Output", savePath);
            }
        }

        private void button_sdr7_go_Click(object sender, EventArgs e)
        {

        }
        private void button_sdr7_v2_go_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile("settings.ini");
            string ffmpeg_exe_location = ffmpeg_loc_textbox.Text.Trim();
            string dgindex_location = dgindex_loc_textbox.Text.Trim();
            string output_folder_name = sdr7_output_folder.Text.Trim();
            string input_MOD_name = sdr7_source_file.Text.Trim();
            string input_MOD_for_later = Path.GetFileNameWithoutExtension(input_MOD_name);
            string work_folder_temp = Directory.GetCurrentDirectory() + "\\temp\\";
            string currentfilenameDATE = (DateTime.Now.ToString("yyyy.MM.dd.HHmmss"));
            string avs_filename = (work_folder_temp + currentfilenameDATE + ".avs");
            string d2v_filename = (work_folder_temp + currentfilenameDATE);
            string d2v_filename_we = (work_folder_temp + currentfilenameDATE + ".d2v");
            string resulting_file = (output_folder_name + "\\" + currentfilenameDATE + "." + input_MOD_for_later + ".mp4");

            if (string.IsNullOrEmpty(ffmpeg_exe_location) || string.IsNullOrEmpty(dgindex_location) || string.IsNullOrEmpty(output_folder_name) || string.IsNullOrEmpty(input_MOD_name))
            {
                MessageBox.Show("Error: One or more input parameters are null or empty. Please, enter all parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(input_MOD_name) && Directory.Exists(output_folder_name))
            {
                // Start a new thread for the workflow
                Thread workerThread = new Thread(() => RunSdr7Workflow(ffmpeg_exe_location, dgindex_location, output_folder_name, input_MOD_name, input_MOD_for_later, work_folder_temp, currentfilenameDATE, avs_filename, d2v_filename, d2v_filename_we, resulting_file));
                workerThread.Start();
                Thread.Sleep(1000);
            }
            else
            {
                MessageBox.Show("Error: Either the input file or the output folder do not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string choose_aspect_ratio()
        {
            if (aspectSelector169.Checked == true && aspectSelector43.Checked == false)
            {
                return " -map 1:a -map 0:v -vf scale=1024:576 -c:v libx264 -preset slow -crf 20 -strict -2 -c:a aac -b:a 512k ";
            }
            else if (aspectSelector169.Checked == false && aspectSelector43.Checked == true)
            {
                return " -map 1:a -map 0:v -vf scale=768:576 -c:v libx264 -preset slow -crf 20 -strict -2 -c:a aac -b:a 512k ";
            }
            return " error ";
        }

        private void RunSdr7Workflow(string ffmpegExeLocation, string dgIndexLocation, string outputFolderName, string input_MOD_name, string input_MOD_for_later, string work_folder_temp, string currentfilenameDATE, string avs_filename, string d2v_filename, string d2v_filename_we, string resulting_file)
        {
            // DGIndex Command Execution
            try
            {
                string dgindex_arguments = "-i " + "\u0022" + input_MOD_name + "\u0022" + " -o " + "\u0022" + d2v_filename + "\u0022" + " -exit"; // Arguments for the first program
                ProcessStartInfo processStartInfo = new ProcessStartInfo(dgIndexLocation, dgindex_arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Minimized,
            };

                using (Process processFirst = new Process())
                {
                    processFirst.StartInfo = processStartInfo;
                    processFirst.Start();
                    processFirst.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting DGIndex: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Generate AVS Script
            if (!File.Exists(avs_filename))
            {
                using (StreamWriter sw = File.CreateText(avs_filename))
                {
                    sw.WriteLine("D2VSource(" + "\u0022" + d2v_filename_we + "\u0022" + ")");
                    sw.WriteLine("AssumeTFF()");
                    sw.WriteLine("QTGMC( Preset=\"Slow\" )");
                }
            }

            // FFMPEG Command Execution
            try
            {
                string ffmpeg_arguments = "-i " + "\u0022" + avs_filename + "\u0022" + " -i " + "\u0022" + input_MOD_name + "\u0022" + choose_aspect_ratio() + "\u0022" + resulting_file + "\u0022";
                //string ffmpeg_arguments = "-i " + "\u0022" + avs_filename + "\u0022" + " -i " + "\u0022" + input_MOD_name + "\u0022" + " -map 1:a -map 0:v -vf scale=1024:576 -c:v libx264 -preset slow -crf 20 -strict -2 -c:a aac -b:a 512k " + "\u0022" + resulting_file + "\u0022";

                ProcessStartInfo processSecondStartInfo = new ProcessStartInfo(ffmpegExeLocation, ffmpeg_arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    WindowStyle = ProcessWindowStyle.Minimized,
                };

                using (Process processSecond = new Process())
                {
                    processSecond.StartInfo = processSecondStartInfo;
                    processSecond.Start();
                    processSecond.WaitForExit();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show($"An error occurred while starting FFMPEG: {ex2.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button_sdr7_batch_go_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile("settings.ini");
            string ffmpeg_exe_location = ffmpeg_loc_textbox.Text.Trim();
            string dgindex_location = dgindex_loc_textbox.Text.Trim();
            string output_folder_name = sdr7_batch_output_folder.Text.Trim();
            string input_folder_name = sdr7_batch_source_file.Text.Trim();
            string work_folder_temp = Directory.GetCurrentDirectory() + "\\temp\\";

            if (string.IsNullOrEmpty(ffmpeg_exe_location) || string.IsNullOrEmpty(dgindex_location) || string.IsNullOrEmpty(output_folder_name) || string.IsNullOrEmpty(input_folder_name))
            {
                MessageBox.Show("Error: One or more input parameters are null or empty. Please, enter all parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(input_folder_name) && Directory.Exists(output_folder_name))
            {
                try
                {
                    string[] modFiles = Directory.GetFiles(input_folder_name, "*.MOD");
                    if (modFiles.Length == 0)
                    {
                        MessageBox.Show("Error: No .MOD files found in this directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (var filePath in modFiles)
                    {
                        string currentfilenameDATE = (DateTime.Now.ToString("yyyy.MM.dd.HHmmss"));
                        string avs_filename = (work_folder_temp + currentfilenameDATE + ".avs");
                        string d2v_filename = (work_folder_temp + currentfilenameDATE);
                        string d2v_filename_we = (work_folder_temp + currentfilenameDATE + ".d2v");
                        string input_MOD_for_later = Path.GetFileNameWithoutExtension(filePath);
                        string input_MOD_name = Path.GetFileName(filePath);
                        string resulting_file = (output_folder_name + "\\" + currentfilenameDATE + "." + input_MOD_for_later + ".mp4");
                        RunSdr7BatchWorkflow(ffmpeg_exe_location, dgindex_location, output_folder_name, input_folder_name, input_MOD_name, input_MOD_for_later, work_folder_temp, currentfilenameDATE, avs_filename, d2v_filename, d2v_filename_we, resulting_file);
                    }

                    MessageBox.Show("Batch conversion was successful. Converted " + modFiles.Length + " file(s).", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Access to the path is denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show("The specified path was not found: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The directory does not exist or is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }

        private void RunSdr7BatchWorkflow(string ffmpegExeLocation, string dgIndexLocation, string outputFolderName, string input_folder_name, string input_MOD_name, string input_MOD_for_later, string work_folder_temp, string currentfilenameDATE, string avs_filename, string d2v_filename, string d2v_filename_we, string resulting_file)
        {
            // DGIndex Command Execution
            try
            {
                string dgindex_arguments = "-i " + "\u0022" + input_folder_name + "\\" + input_MOD_name + "\u0022" + " -o " + "\u0022" + d2v_filename + "\u0022" + " -exit"; // Arguments for the first program
                ProcessStartInfo processStartInfo = new ProcessStartInfo(dgIndexLocation, dgindex_arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Minimized,
                };

                using (Process processFirst = new Process())
                {
                    processFirst.StartInfo = processStartInfo;
                    processFirst.Start();
                    processFirst.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting DGIndex: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Generate AVS Script
            if (!File.Exists(avs_filename))
            {
                using (StreamWriter sw = File.CreateText(avs_filename))
                {
                    sw.WriteLine("D2VSource(" + "\u0022" + d2v_filename_we + "\u0022" + ")");
                    sw.WriteLine("AssumeTFF()");
                    sw.WriteLine("QTGMC( Preset=\"Slow\" )");
                }
            }

            // FFMPEG Command Execution
            try
            {
                string ffmpeg_arguments = "-i " + "\u0022" + avs_filename + "\u0022" + " -i " + "\u0022" + input_folder_name + "\\" + input_MOD_name + "\u0022" + choose_aspect_ratio() + "\u0022" + resulting_file + "\u0022";
                //string ffmpeg_arguments = "-i " + "\u0022" + avs_filename + "\u0022" + " -i " + "\u0022" + input_folder_name + "\\" + input_MOD_name + "\u0022" + " -map 1:a -map 0:v -vf scale=1024:576 -c:v libx264 -preset slow -crf 20 -strict -2 -c:a aac -b:a 512k " + "\u0022" + resulting_file + "\u0022";

                ProcessStartInfo processSecondStartInfo = new ProcessStartInfo(ffmpegExeLocation, ffmpeg_arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    WindowStyle = ProcessWindowStyle.Minimized,
                };

                using (Process processSecond = new Process())
                {
                    processSecond.StartInfo = processSecondStartInfo;
                    processSecond.Start();
                    processSecond.WaitForExit();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show($"An error occurred while starting FFMPEG: {ex2.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
public class IniFile   // revision 11
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
