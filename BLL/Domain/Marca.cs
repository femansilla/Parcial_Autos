using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Marca
    {
        public Int32 Id { set; get; }
        public String mMarca { set; get; }

        public Marca() { }

        public Marca(string marca, Int32 id) {
            this.Id = id;
            this.mMarca = marca;
        }

        public override string ToString()
        {
            return mMarca;
        }

    }
}
