using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidTextFileHelper))]
namespace DatenSpeichernUndLaden.Droid
{
    public class AndroidTextFileHelper : ITextFileHelper
    {
        public string LoadTextFile()
        {
            string fullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "demo.txt");
            return File.ReadAllText(fullPath);
        }

        public void SaveTextFile(string content)
        {
            // Android.OS.Environment  <---- Wenns auf der SD Karte ist -> WRITE_EXTERNAL_STORAGE
            // System.Environment.SpecialFolder
            // PersonalFolder -> /data/data/[appliaktionsname]/files

            string fullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "demo.txt");
            File.WriteAllText(fullPath, content);
        }
    }
}