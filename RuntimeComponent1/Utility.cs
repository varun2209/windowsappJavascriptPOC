using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
    public sealed class Utility
    {
        public static dynamic createResponseNode(string nameSpaceQualifiedObjectType)
        {
            dynamic resultantObjectType;
            Type objectType = Type.GetType(nameSpaceQualifiedObjectType);
            if (objectType != null)
            {
                resultantObjectType = Activator.CreateInstance(objectType);
            }
            else
            {
                string[] classNameArray = nameSpaceQualifiedObjectType.Split('_');
                objectType = Type.GetType(string.Join("", classNameArray.Select(s => char.ToUpperInvariant(s[0]) + s.Substring(1))));
                resultantObjectType = Activator.CreateInstance(objectType);
            }
            return resultantObjectType;
        }

        public static void addToList(dynamic itemList, dynamic listItem)
        {
            itemList.Add(listItem);
        }
    }
}
