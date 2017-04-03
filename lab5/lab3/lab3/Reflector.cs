using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml;

namespace lab3
{
    static class Reflector
    {
        static public void Write(string cs)
        {
            Type myType = Type.GetType("lab3." + cs, false, true);

            File.WriteAllText("a.txt", "\tМетоды класса " + myType.Name + ":");
            foreach (MethodInfo m in myType.GetRuntimeMethods())
            {
                string mod = "";
                if (m.IsStatic)
                    mod += "static ";
                if (m.IsVirtual)
                    mod += "virtual ";
                File.AppendAllText("a.txt", "\r\n" + mod + m.ReturnType.Name + " " + m.Name + " (");
                // Get all params
                ParameterInfo[] parameters = m.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    File.AppendAllText("a.txt", parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) File.AppendAllText("a.txt", ", ");
                }
                File.AppendAllText("a.txt", ")");
            }

            File.AppendAllText("a.txt", "\r\n\tПоля:");
            foreach (FieldInfo field in myType.GetFields())
            {
                File.AppendAllText("a.txt", "\r\n " + field.FieldType + " — " + field.Name);
            }

            File.AppendAllText("a.txt", "\r\n\tСвойства:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                File.AppendAllText("a.txt", "\r\n " + prop.PropertyType + " — " + prop.Name);
            }
        }
        static public void WriteAllPublicMethods(string objName)
        {
            Type myType = Type.GetType("lab3." + objName, false, true);

            File.WriteAllText("b.txt", "\tМетоды класса " + myType.Name + ":");
            foreach (MethodInfo method in myType.GetMethods())
            {
                File.AppendAllText("b.txt", "\r\n" + method.ReturnType.Name + " " + method.Name + " (");
                
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    File.AppendAllText("b.txt", parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) File.AppendAllText("b.txt", ", ");
                }
                File.AppendAllText("b.txt", ")");
            }
        }
        static public void WriteFieldAndProperties(string objName)
        {
            Type myType = Type.GetType("lab3." + objName, false, true);

            File.WriteAllText("c.txt", "Поля:");
            foreach (FieldInfo field in myType.GetFields())
            {
                File.AppendAllText("c.txt", "\r\n" + field.FieldType + " — " + field.Name);
            }

            File.AppendAllText("c.txt", "\r\n\r\nСвойства:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                File.AppendAllText("c.txt", "\r\n " + prop.PropertyType + " — " + prop.Name);
            }
        }
        static public void WriteImplementedInterfaces(string objName)
        {
            Type myType = Type.GetType("lab3." + objName, false, true);

            File.WriteAllText("d.txt", "Реализованные интерфейсы:");
            foreach (Type i in myType.GetInterfaces())
            {
                File.AppendAllText("d.txt", "\r\n " + i.Name);
            }
        }
        static public void WriteNameOfMethodsWithSpecifiedType(string objName, string specifiedType)
        {
            Type myType = Type.GetType("lab3." + objName, false, true);

            File.WriteAllText("e.txt", "Methods with specified type " + specifiedType + ":");
            foreach (MethodInfo method in myType.GetMethods())
            {
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.Name == specifiedType)
                        File.AppendAllText("e.txt", "\r\n\t" + method.Name);
                }
            }
        }
        static public void ReadArgsMethodFromFile(string className, string methodName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("6.Method.xml");
            XmlNodeList ordersList = doc.DocumentElement.ChildNodes;

            object[] param = new object[4];
            int i = 0;

            foreach (XmlNode n in ordersList)
            {
                if (n.Name == "method" && n.Attributes["id"].Value == "Color_Message")
                {
                    foreach (XmlNode tmp in n)
                    {
                        param[i] = tmp.InnerText;
                        i++;
                    }
                }
            }
            Type myClass = Type.GetType(className);
            MethodInfo mi = myClass.GetMethod(methodName);
            mi.Invoke(null, new object[] { param });
        }
    }

    public static class MyClass
    {
        public static void Color_Message(params object[] message)
        {
            // Set color
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
            // reset collor settings
            Console.ResetColor();
        }
    }
}

