using System.IO;
using System.Xml.Serialization;

namespace AutoTranslateResxFiles
{



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {
        public root() { }
        public static root Load(FileInfo stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(root));

            return (root)serializer.Deserialize(stream.OpenRead());
        }

        public void SerializeTo(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(root));
            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer.BaseStream, this);
        }
        private rootResheader[] resheaderField;

        private rootData[] dataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resheader")]
        public rootResheader[] resheader
        {
            get
            {
                return this.resheaderField;
            }
            set
            {
                this.resheaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data")]
        public rootData[] data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootResheader
    {

        private string valueField;

        private string nameField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootData
    {

        private string valueField;

        private string[] textField;

        private string nameField;

        private string spaceField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }
    }




}
