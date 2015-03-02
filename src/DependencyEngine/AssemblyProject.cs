using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DependencyEngine
{
    public class AssemblyProject
    {
        private string id;
        private string name;
        private string version;
        private string culture;
        private string publicKeyToken;

        #region Constructors
        public AssemblyProject(string name)
        {
            this.name = name;
            this.version = "";
            this.id = this.name + this.version;
            this.culture = "";
            this.publicKeyToken = "";
        }

        public AssemblyProject(string name, string version)
        {
            this.name = name;
            this.version = version;
            this.id = this.name + this.version;
            this.culture = "";
            this.publicKeyToken = "";
        }

        public AssemblyProject(string name, string version, string culture)
        {
            this.name = name;
            this.version = version;
            this.id = this.name + this.version;
            this.culture = culture;
            this.publicKeyToken = "";
        }
        public AssemblyProject(string name, string version, string culture, string publicKeyToken)
        {
            this.name = name;
            this.version = version;
            this.id = this.name + this.version;
            this.culture = culture;
            this.publicKeyToken = publicKeyToken;
        }


        #endregion

        #region Public overriden methods

        public override string ToString()
        {
            if (!String.IsNullOrEmpty(this.version))
                return this.name + "(" + this.version + ")";
            else
                return this.name;
        }

        #endregion

        #region Properties

        [Category("General")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [Category("General")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Properties")]
        public string Culture
        {
            get { return culture; }
            set { culture = value; }
        }

        [Category("Properties")]
        public string PublicKeyToken
        {
            get { return publicKeyToken; }
            set { publicKeyToken = value; }
        }

        [Category("Properties")]
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        #endregion
    }
}
