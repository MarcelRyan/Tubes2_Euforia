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
* .NET 7.0 installation https://dotnet.microsoft.com/en-us/download/dotnet/7.0
## Cara Compile dan Menjalankan Program
1. Clone folder with `git clone https://github.com/MarcelRyan/Tubes2_Euforia`
2. Go to the folder `cd Tubes2_Euforia`
3. Build release version `dotnet build --configuration Release Tubes2_Euforia.sln`
4. Go to build `cd bin/Release/net7.0-windows`
5. Run the program `Tubes2_Euforia` or `./Tubes2_Euforia`

## Cara Menggunakan Program
Sistem menerima masukan file sebagai konfigurasi peta labirin yang akan dicari solusinya. Masukan dapat berupa nama file pada text box ataupun menggunakan file explorer dengan menekan ikon file di kanan text box tersebut. Jika masukan nama file menggunakan text box, file akan dicari menggunakan path yang relatif terhadap folder test sistem. Masukan menggunakan file explorer akan membuat sistem mencari file tersebut berdasarkan letak file sebenarnya. Perlu diperhatikan bahwa sistem secara otomatis mendeteksi file extension (semua karakter setelah tanda titik) pada nama file dan menggantinya menjadi format txt.
Pengguna dapat langsung melakukan visualisasi peta jika file sudah dimasukkan. Kesalahan nama ataupun  isi file akan menyebabkan sistem menampilkan pesan error di layar. Terdapat beberapa kesalahan file yang membuat sistem gagal melakukan visualisasi:

1. file tidak ditemukan;
2. file kosong;
3. ada spasi pada akhir baris dalam file;
4. panjang baris tidak seragam;
5. karakter tidak dipisah spasi;
6. file mengandung karakter selain K, T, R, X (tidak case sensitive)
7. file tidak memiliki karakter K
8. file mengandung lebih dari satu karakter K

Walaupun visualisasi dapat dilakukan setelah memasukkan file, pencarian solusi mewajibkan pengguna setidaknya memilih algoritma BFS atau DFS (pengguna hanya dapat memilih salah satu). Untuk masing-masing algoritma tersebut, terdapat juga pilihan untuk memperbolehkan ataupun tidak memperbolehkan  rute solusi untuk melewati grid yang sama lebih dari sekali. Selain itu, pengguna juga dapat memilih mode TSP sehingga solusi yang dihasilkan merupakan rute untuk mendapatkan seluruh treasure dan kemudian kembali ke titik awal. Jika salah satu algoritma BFS atau DFS sudah dipilih, pengguna dapat menekan tombol solve untuk mendapatkan solusi pencarian.
Tombol show progress digunakan untuk menunjukkan proses pencarian berdasarkan algoritma yang dipilih. Jika tombol tersebut ditekan, akan muncul kotak masukan waktu jeda tampilan dalam menampilkan progress pencarian tersebut (dalam milisekon). Masukan waktu ini dapat diubah selama proses pencarian untuk  mempercepat ataupun memperlambat proses yang ditampilkan. Tombol show progress perlu ditekan sebelum menekan solve. (Masukan waktu 0 ms akan menyebabkan proses tidak memberikan jeda antar perpindahan kecuali pada algoritma BFS untuk no multiple visits yang memiliki jeda waktu independen terhadap masukan tersebut. Jeda waktu independen ini ditambahkan untuk kejelasan proses dan bukan karena masalah performa).

Apabila sistem sudah menemukan solusi, sistem akan menampilkan informasi eksekusi dan pencarian pada kanan dan bawah tampilan. Pada kanan tampilan ditunjukkan waktu eksekusi pencarian (termasuk waktu yang dibutuhkan untuk menampilkan progress jika dipilih), jumlah node/grid yang diperiksa selama pencarian (grid yang ditelusuri lebih dari sekali akan tetap dihitung sebagai 1 node/grid), serta jumlah langkah yang diperlukan dalam solusi akhir. Bagian bawah layar menampilkan rute solusi akhir berupa arah perjalanan rute tersebut menggunakan simbol U, R, D, dan L untuk up, right, down, left.

## Dibuat Oleh
* Nama : Marcel Ryan Antony
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
* Nama: Johanes Lee
* NIM: 13521148
* Prodi/Jurusan: STEI/Teknik Informatika
* Profile Github : Enliven26
* Kelas : K02
