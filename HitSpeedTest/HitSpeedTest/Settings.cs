using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
namespace HitSpeedTest
{
    public class Settings
    {
        public bool K1On = true;
        public bool K2On = true;
        public bool M1On = false;
        public bool M2On = false;
        public Keys K1 = Keys.X;
        public Keys K2 = Keys.Z;
        public Keys M1 = Keys.LButton;
        public Keys M2 = Keys.RButton;
        public Settings()
        {
        }
        public void Save()
        {
            Stream stream = File.Create("settings.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            serializer.Serialize(stream, this);
            stream.Close();
        }

        /// <summary>
        /// Loads settings from a file
        /// </summary>
        /// <param name="filename">The filename to load</param>
        public static Settings Load()
        {
            Stream stream = null;
            try
            {
                stream = File.OpenRead("settings.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                return (Settings)serializer.Deserialize(stream);
            }
            catch (Exception e)
            {
                return new Settings();
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }
    }
}
