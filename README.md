# This tool lets you easily convert MOD files from DVD-Quality digital camcorders (Canon, Panasonic, JVC) into deinterlaced MP4 (h264) videofiles.
<img width="160" height="160" alt="Camcorder Canon Legria" src="https://github.com/user-attachments/assets/b698a621-b364-4214-a3eb-fad6dc39f37f" /> <img width="160" height="160" alt="75edaa19-737e-409f-bb0e-e510011bd486_removalai_preview" src="https://github.com/user-attachments/assets/57052a27-5671-48c3-bb53-2331ce8b72d0" /> <img width="160" height="160" alt="Camcorder JVC Everio" src="https://github.com/user-attachments/assets/0bbf1875-46de-4551-a792-d8d37a51b4ef" />



## **WARNING: THIS TOOL ONLY SUPPORTS PAL INTERLACED VIDEOFILES, NTSC SUPPORT IS YET TO BE IMPLEMENTED AS OF VERSION 1.3 !!!**

<img width="600" alt="Program Screenshot" src="https://github.com/user-attachments/assets/77d45775-b5de-4fb1-8949-5e99d164beb3" />


### Features:
+ Single file or batch conversion
+ Manual selection of resulting aspect ratio (4:3 or 16:9) **(added in 1.3)**

### System Requirements:
+ OS: Windows 7 64bit or higher
+ CPU: Something modern and with strong single core performance (Don't run this on a laptop Celeron / Atom, please, it will be very slow and miserable)

### Prerequisites:
1. FFMPEG
2. DGIndex
3. Avisynth+ with correctly installed QTGMC plugin and D2VSource

### Prerequisites installation instructions (new):
1. Make sure that you have all the Visual C++ Redistributable Runtimes. If unsure, get the all-in-one package here: https://www.techpowerup.com/download/visual-c-redistributable-runtime-package-all-in-one/
2. Get the latest release of AviSynth+ installer here https://github.com/AviSynth/AviSynthPlus/releases and install. Make sure to tick AviSynth+ x64 in the installer.
3. Download QTGMC.avsi and everything under the "Requirements - Core Plugins and Scripts" from here: http://avisynth.nl/index.php/QTGMC
4. Download D2VSource here http://avisynth.nl/index.php/MPEG2DecPlus
5. Now, put all of the files you've downloaded in steps 2 and 3 into AviSynth+ / plugins64 folder
6. Browse all the archives you've got in the previous steps, and extract only the files that correspond to x64 into AviSynth+ / plugins64. If unsure:
   + D2VSource.7z -> x64 -> Release ->  D2VSource.dll
   + masktools2.7z -> x64 -> masktools2.dll
   + mvtools.7z -> x64 -> MSVC -> all of the files (DePan.dll, DePanEstimate.dll, mvtools2.dll)
   + NNEDI3.7z -> x64 -> Release_W7 -> nnedi3.dll
   + RgTools.7z -> x64 -> RgTools.dll
7. You should now have these files in AviSynth+/plugins64/ folder:
   + D2VSource.dll
   + DePan.dll
   + DePanEstimate.dll
   + masktools2.dll
   + mvtools2.dll
   + nnedi3.dll
   + QTGMC.avsi
   + RgTools.dll
   + Zs_RF_Shared.avsi
8. Download the latest FFMPEG binaries here https://www.ffmpeg.org/download.html and extract it to the folder of your choosing. You only need the ffmpeg.exe file from the downloaded archive
9. Download DGIndex here https://www.videohelp.com/software/DGMPGDec and extract it to the folder of your choosing. You only need two files from this archive: DGDecode.dll and DGIndex.exe


### Usage:
1. Make sure you have all the prerequisites installed and/or available on your machine. **MAKE SURE THAT AVISYNTH+ WORKS!!!**
2. Launch the program and correctly fill in the app settings (FFMPEG and DGIndex paths, video aspect ratio).
3. Depending on your needs, fill in the parameters in either the single-file conversion or batch conversion.
4. Single-File conversion is useful when you need to convert one file (duh...) or if you want to convert multiple large files simultaneously. If you want the latter, launch the process for the first file, then adjust settings for the second file and launch the process again, an do this as much as you need.
5. Batch conversion is useful when you need to convert lots of files at once. This mode scans the source folder and launches the process for each file sequentially. Only one file is converted at a time. It is best to leave the PC alone while this happens, as the app will open new windows for each file, interrupting any user activity.
6. Enjoy your files.

### Future features:
- Generalization of the app (right now this app is labeled as "for Panasonic SDR-S7", while it can work with any(?) camcorder of that era)
- NTSC Support
- Non-Interlaced .MOD files support? (do the even exist tho?)
- e.t.c...
