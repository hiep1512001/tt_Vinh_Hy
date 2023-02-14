using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoThuctap.DTO
{
    public class Product
    {
       private String id;
       private String Name;

        public Product()
        {
        }
        public Product(string id, string name)
        {
            this.id = id;
            Name = name;
        }
        public String getId()
        {
            return this.id;
        }
        public String getName()
        {
            return this.Name;
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public void setName(String name)
        {
            this.Name = name;
        }
    }
}