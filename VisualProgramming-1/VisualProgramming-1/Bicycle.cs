using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bicycles
{
    public enum RideType {
        Mountain,
        Urban,
        Track,
        Pleasure
    }

    public enum Category
    {
        Small,
        Medium,
        Big
    }

    public class Bicycle
    {
        private String name;
        private Category category;

        private Boolean competition;
        private RideType rideType;
        private short numberOfBicycles;
        private decimal price;

        private List<String> bicycles1;
        private List<String> frame;
        private List<String> frameStyle;

        // Optional
        private Boolean custom;
        private Boolean gears;
        private Boolean pedalMounts;
        private Boolean lights;
        private Boolean diskBrakes;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Boolean Competition
        {
            get { return competition; }
            set { competition = value; }
        }
        public RideType RideType
        {
            get { return rideType; }
            set { rideType = value; }
        }
 
        public List<String> Bicycles1
        {
            get { return bicycles1; }
            set { bicycles1 = value; }
        }
        public List<String> Frame
        {
            get { return frame; }
            set { frame = value; }
        }

        public Boolean Custom
        {
            get { return custom; }
            set { custom = value; }
        }

        public Boolean Gears
        {
            get { return gears; }
            set { gears = value; }
        }

        public Boolean PedalMounts
        {
            get { return pedalMounts; }
            set { pedalMounts = value; }
        }

        public Boolean Lights
        {
            get { return lights; }
            set { lights = value; }
        }
        public Boolean DiskBrakes
        {
            get { return diskBrakes; }
            set { diskBrakes = value; }
        }

        public List<string> FrameStyle
        {
            get { return frameStyle; }
            set { frameStyle = value; }
        }

        public Category CatName { 
            get { return category; } 
            set { category = value; } 
        }

        public short NumberOfBicycles
        {
            get { return numberOfBicycles; }
            set { numberOfBicycles = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Bicycle()
        {
            bicycles1 = new List<string>();
            frame = new List<string>();
            frameStyle = new List<string>();
        }

        public void Save(string filePath)
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Bicycle));
                writer = new StreamWriter(filePath, false);
                serializer.Serialize(writer, this);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static Bicycle Load(string filePath)
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Bicycle));
                reader = new StreamReader(filePath);
                return (Bicycle)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
