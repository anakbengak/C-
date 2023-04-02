## Inisialisasi Project menggunakan terminal
```bash
dotnet new [projectType] -o ProjectName
```
Misal : Untuk membuat Console Project (program yang berjalan pada terminal/cli)
```bash
dotnet new console -o NamaProject
```
Berikut  syntax template lengkapnya (gunakan Short Name untuk projectType nya):

|Template Name                               |Short Name         |Language   |Tags
|--------------------------------------------|-------------------|-----------|------------------------
|ASP.NET Core Empty                          |web                |[C#],F#    |Web/Empty
|ASP.NET Core gRPC Service                   |grpc               |[C#]       |Web/gRPC
|ASP.NET Core Web API                        |webapi             |[C#],F#    |Web/WebAPI
|ASP.NET Core Web App                        |webapp,razor       |[C#]       |Web/MVC/Razor Pages
|ASP.NET Core Web App (Model-View-Controller)|mvc                |[C#],F#    |Web/MVC
|ASP.NET Core with Angular                   |angular            |[C#]       |Web/MVC/SPA
|ASP.NET Core with React.js                  |react              |[C#]       |Web/MVC/SPA
|Blazor Server App                           |blazorserver       |[C#]       |Web/Blazor
|Blazor WebAssembly App                      |blazorwasm         |[C#]       |Web/Blazor/WebAssembly/PWA
|Class Library                               |classlib           |[C#],F#,VB |Common/Library
|Console App                                 |console            |[C#],F#,VB |Common/Console
|dotnet gitignore file                       |gitignore          |           |Config
|Dotnet local tool manifest file             |tool-manifest      |           |Config
|EditorConfig file                           |editorconfig       |           |Config
|global.json file                            |globaljson         |           |Config
|MSTest Test Project                         |mstest             |[C#],F#,VB |Test/MSTest
|MVC ViewImports                             |viewimports        |[C#]       |Web/ASP.NET
|MVC ViewStart                               |viewstart          |[C#]       |Web/ASP.NET
|NuGet Config                                |nugetconfig        |           |Config
|NUnit 3 Test Item                           |nunit-test         |[C#],F#,VB |Test/NUnit
|NUnit 3 Test Project                        |nunit              |[C#],F#,VB |Test/NUnit
|Protocol Buffer File                        |proto              |           |Web/gRPC
|Razor Class Library                         |razorclasslib      |[C#]       |Web/Razor/Library
|Razor Component                             |razorcomponent     |[C#]       |Web/ASP.NET
|Razor Page                                  |page               |[C#]       |Web/ASP.NET
|Solution File                               |sln,solution       |           |Solution
|Web Config                                  |webconfig          |           |Config
|Windows Forms App                           |winforms           |[C#],VB    |Common/WinForms
|Windows Forms Class Library                 |winformslib        |[C#],VB    |Common/WinForms
|Windows Forms Control Library               |winformscontrollib |[C#],VB    |Common/WinForms
|Worker Service                              |worker             |[C#],F#    |Common/Worker/Web
|WPF Application                             |wpf                |[C#],VB    |Common/WPF
|WPF Class Library                           |wpflib             |[C#],VB    |Common/WPF
|WPF Custom Control Library                  |wpfcustomcontrollib|[C#],VB    |Common/WPF
|WPF User Control Library                    |wpfusercontrollib  |[C#],VB    |Common/WPF
|xUnit Test Project                          |xunit              |[C#],F#,VB |Test/xUnit


## Daftar Isi
1. [Cara Mendefinisikan Variabel](#cara-mendefinisikan-variabel)
2. [Tipe Data](#tipe-data)
3. [Manipulasi String](#manipulasi-string)
4. [Manipulasi Angka](#manipulasi-angka)
5. [Mendapatkan Input dari User](#mendapatkan-input-dari-user)
6. [Bekerja dengan Array Sederhana](#bekerja-dengan-array-sederhara)
7. [Cara Menggunakan Method](#cara-menggunakan-method)
8. [Menggunakan Return](#menggunakan-return)
9. [ifStatement](#ifstatement)
10. [ifConditioned](#ifconditioned)
11. [Menggunakan Switch](#menggunakan-switch)
12. [Menggunakan Loops](#menggunakan-loops)
13. [menggunakan For](#menggunakan-for)
14. [exponentMethod](#exponentmethod)
15. [arrayDuaDimensi](#arrayduadimensi)
16. [Menangani Exception](#menangani-exception)
17. [Kelas dan Objek](#kelas-dan-objek)
18. [menggunakan Konstruktor](#menggunakan-konstruktor)
19. [Object dan Methods](#object-dan-methods)
20. [getSet](#getset)
21. [Static Class Attributes](#static-class-attributes)
22. [Static Methods and Classes](#static-methods-and-classes)
23. [Cara Inheritance](#cara-inheritance)


## Cara Mendefinisikan Variabel
## Tipe Data
## Manipulasi String
## Manipulasi Angka
## Mendapatkan Input dari User
## Bekerja dengan Array Sederhana
## Cara Menggunakan Method
## Menggunakan Return
## ifStatement
## ifConditioned
## Menggunakan Switch
## Menggunakan Loops
## menggunakan For
## exponentMethod
## arrayDuaDimensi
## Menangani Exception
## Kelas dan Objek
Dalam C#, class dapat menjadi tipe data baru.
Penamaan Class menggunakan huruf Besar pada setiap awal kata.
misal : class buku, ditulis "Buku"
```C#
class Buku{

}
```
Dalam setiap class, terdapat attributes.
Attributes adalah sekumpulan data tertentu yang spesifik untuk class tersebut.
penulisan attributes menggunakan huruf kecil pada awal kata pertama, lalu menggunakan huruf besar pada setiap awal kata berikutnya.
Misal : attribute judul buku ditulis "judulBuku". Attribute jumlah halaman ditulis "jumlahHalaman".
Jika kita gabungkan dengan class Buku, maka menjadi:
```C#
namespace TheBasics{
	class Buku{
		public string judulBuku;
		public int jumlahHalaman;
		public string penulis;
		
	}
}
```
Object adalah entitas yang dihasilkan dengan menginputkan nilai tertentu ke dalam sebuah kelas.
Misalkan kita telah membuat class Buku, lalu kita ingin membuat object dari class tersebut.
Ingat, class Buku telah menjadi tipe data baru.
Inisialisasinya adalah sebagai berikut:
```C#
using System;

namespace TheBasics
{
	class MenggunakanClassDanObject
	{
		static void Main(string[] args)
		{
			Buku bukuSatu = new Buku();
			bukusatu.judulBuku="Buku Saku";
			bukusatu.jumlahHalaman=129;
			bukusatu.penulis="Penulis Buku Saku";
			
			Console.WriteLine(bukusatu.judulBuku);
			Console.ReadLine();
		}
	}
}


```
Note: Membuat Class file
- Visual Studio :
	Di bagian Solusion Explorer (sebelah kanan), klik kanan pada nama project->add->new item.
	Pilih "Class".
	Beri nama class, misal untuk class Buku: Buku.cs
	
- VS Code :
	Klik Kanan pada Folder Project di bagian Explorer -> new File
	Beri nama Buku.cs
	
Selengkapnya cek di direktori [TheBasics/MenggunakanClassDanObject](https://github.com/anakbengak/C-Sharp/tree/main/TheBasics/MenggunakanClassDanObject)


## menggunakan Konstruktor
## Object dan Methods
## getSet
## Static Class Attributes
## Static Methods and Classes
## Cara Inheritance
