# Tubes2_Euforia
Tugas Besar 2 IF2211 Strategi Algoritma Pengaplikasian Algoritma BFS dan DFS dalam Menyelesaikan Persoalan Maze Treasure Hunt

## Daftar Isi
* [Deskripsi Singkat Program](#deskripsi-singkat-program)
* [Requirements](#requirements)
* [Cara Menjalankan Program](#cara-menjalankan-program)
* [Dibuat Oleh](#dibuat-oleh)

## Deskripsi Singkat Program
Program ini merupakan program yang menggunakan algoritma pencarian BFS dan DFS untuk mendapatkan rute dalam memperoleh seluruh treasure atau harta karun yang ada pada suatu maze. Untuk visualisasi proses pencarian seluruh treasure program telah dibuat GUI sederhana menggunakan bantuan WinForms dari Visual Studio.

## Struktur Program
```bash
 ┣ 📂.vs
 ┃ ┣ 📂ProjectEvaluation
 ┃ ┃ ┣ 📜tubes2_euforia.metadata.v6.1
 ┃ ┃ ┗ 📜tubes2_euforia.projects.v6.1
 ┃ ┗ 📂Tubes2_Euforia
 ┃ ┃ ┣ 📂DesignTimeBuild
 ┃ ┃ ┃ ┗ 📜.dtbcache.v2
 ┃ ┃ ┣ 📂FileContentIndex
 ┃ ┃ ┃ ┗ 📜read.lock
 ┃ ┃ ┗ 📂v17
 ┃ ┃ ┃ ┣ 📜.futdcache.v2
 ┃ ┃ ┃ ┗ 📜.suo
 ┣ 📂bin
 ┃ ┗ 📂Debug
 ┃ ┃ ┗ 📂net7.0-windows
 ┃ ┃ ┃ ┣ 📜FontAwesome.Sharp.dll
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.deps.json
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.dll
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.exe
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.pdb
 ┃ ┃ ┃ ┗ 📜Tubes2_Euforia.runtimeconfig.json
 ┣ 📂doc
 ┃ ┗ 📜Euforia.pdf
 ┣ 📂obj
 ┃ ┣ 📂Debug
 ┃ ┃ ┗ 📂net7.0-windows
 ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┗ 📜Tubes2_Euforia.dll
 ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┗ 📜Tubes2_Euforia.dll
 ┃ ┃ ┃ ┣ 📂TempPE
 ┃ ┃ ┃ ┃ ┗ 📜Properties.Resources.Designer.cs.dll
 ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v7.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┣ 📜apphost.exe
 ┃ ┃ ┃ ┣ 📜GUI.Treasure_Hunt_Solver.resources
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.AssemblyInfo.cs
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.assets.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.BuildWithSkipAnalyzers
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.CopyComplete
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.csproj.GenerateResource.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.designer.deps.json
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.designer.runtimeconfig.json
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.dll
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.genruntimeconfig.cache
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.GlobalUsings.g.cs
 ┃ ┃ ┃ ┣ 📜Tubes2_Euforia.pdb
 ┃ ┃ ┃ ┗ 📜Tubes2_Euforia.Properties.Resources.resources
 ┃ ┣ 📜project.assets.json
 ┃ ┣ 📜project.nuget.cache
 ┃ ┣ 📜Tubes2_Euforia.csproj.nuget.dgspec.json
 ┃ ┣ 📜Tubes2_Euforia.csproj.nuget.g.props
 ┃ ┗ 📜Tubes2_Euforia.csproj.nuget.g.targets
 ┣ 📂Properties
 ┃ ┣ 📜Resources.Designer.cs
 ┃ ┗ 📜Resources.resx
 ┣ 📂Resources
 ┃ ┣ 📜euforia logo.png
 ┃ ┗ 📜euforia logo1.png
 ┣ 📂src
 ┃ ┣ 📂Algorithm
 ┃ ┃ ┣ 📜BFSState.cs
 ┃ ┃ ┣ 📜DFSState.cs
 ┃ ┃ ┗ 📜MazeState.cs
 ┃ ┣ 📂GUI
 ┃ ┃ ┣ 📜Helper.cs
 ┃ ┃ ┣ 📜Treasure_Hunt_Solver.cs
 ┃ ┃ ┣ 📜Treasure_Hunt_Solver.Designer.cs
 ┃ ┃ ┗ 📜Treasure_Hunt_Solver.resx
 ┃ ┣ 📂IO
 ┃ ┃ ┗ 📜FileIO.cs
 ┃ ┣ 📜Program.cs
 ┃ ┗ 📜Testing.cs
 ┣ 📂test
 ┃ ┣ 📜sampel-1.txt
 ┃ ┣ 📜sampel-2.txt
 ┃ ┣ 📜sampel-3.txt
 ┃ ┣ 📜sampel-4.txt
 ┃ ┣ 📜sampel-5.txt
 ┃ ┣ 📜test.txt
 ┃ ┣ 📜test2.txt
 ┃ ┣ 📜test3.txt
 ┃ ┣ 📜test4.txt
 ┃ ┣ 📜test5.txt
 ┃ ┗ 📜test7.txt
 ┣ 📜.gitignore
 ┣ 📜README.md
 ┣ 📜Tubes2_Euforia.csproj
 ┣ 📜Tubes2_Euforia.csproj.user
 ┗ 📜Tubes2_Euforia.sln
 ```

## Requirements
* Microsoft Windows Operating System
* .NET 7.0 installation [Install .NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
## Cara Menjalankan Program
1. Clone folder with `git clone https://github.com/MarcelRyan/Tubes2_Euforia`
2. Go to the folder `cd Tubes2_Euforia`
3. Build release version `dotnet build --configuration Release Tubes2_Euforia.sln`
4. Go to build `cd bin/Release/net7.0-windows`
5. Run the program `Tubes2_Euforia` or `./Tubes2_Euforia`

## Dibuat Oleh
* Nama : Marcel Ryan Anthony
* NIM : 13521127
* Prodi/Jurusan : STEI/Teknik Informatika
* Profile Github : MarcelRyan
* Kelas : K01
##
* Nama: Raynard Tanadi
* NIM: 13521143
* Prodi/Jurusan: STEI/Teknik Informatika
* Profile Github : Raylouiss
* Kelas : K01
##
* Nama: Johannes Lee
* NIM: 13521148
* Prodi/Jurusan: STEI/Teknik Informatika
* Profile Github : Envilen26
* Kelas : K02
