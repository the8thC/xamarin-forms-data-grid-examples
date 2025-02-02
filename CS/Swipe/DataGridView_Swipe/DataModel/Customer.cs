﻿using System;
using Xamarin.Forms;

namespace DataGridView_Swipe {
    public class Customer : ModelObject {
        string name;
        string resourceName;

        public string Name {
            get { return name; }
            set {
                name = value;
                if (Photo == null) {
                    resourceName = "DataGridView_Swipe.Images." + value.Replace(" ", "_") + ".jpg";
                    if (!String.IsNullOrEmpty(resourceName))
                        Photo = ImageSource.FromResource(resourceName);
                }
            }
        }

        public Customer(string name) {
            this.Name = name;
        }

        public ImageSource Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
