using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    class BasicElement<T> 
    {
        public string Name { get; set; }
        public List<BasicElement<T>> Elements { get; set; }

        public BasicElement(string _name, List<BasicElement<T>> _elements)
        {
            this.Name = _name;
            this.Elements = _elements;
        }

        //adding new elements into the item
        public void AddNewElements(List<BasicElement<T>> addingObjects)
        { 
            foreach (BasicElement<T> newObject in addingObjects)
            {
                //check new topics for uniqueness
                foreach (BasicElement<T> oldObject in Elements)
                {
                    if (newObject.Name == oldObject.Name)
                        continue;
                    else
                        Elements.Add(newObject);
                }
            }
        }

        //delete checking objects
        public void DeleteElements(List<BasicElement<T>> deletedObjects)
        {
            foreach (BasicElement<T> deleteElement in deletedObjects)
            {
                Elements.Remove(deleteElement);
            }
        }

        //rename object
        public void RenameElement<T>(BasicElement<T> renameObject, string newName)
        {
            renameObject.Name = newName;
        }

        


    }
}