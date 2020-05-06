using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ConsoleAppSerializeDemo
{
    public class FileDemo
    {

        public static void Serialization()
        {
            Person p = new Person("Martin", "Roskilde");

            IFormatter formatter = new BinaryFormatter();

            Stream stream = null;

            stream = new FileStream("C:/filedemo/person.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, p);

            if (stream != null)
                stream.Close();
        }

        public static void Deserialization()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = null;

            stream = new FileStream("C:/filedemo/person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            Person p1 = new Person();

            p1 = (Person)formatter.Deserialize(stream);

            Console.WriteLine(p1.ToString());

            if (stream != null)
                stream.Close();

        }

        public static void SerializationPersons()
        {
            Person p1 = new Person("Anders And", "Andeby");
            Person p2 = new Person("Martin", "Roskilde");
            Person p3 = new Person("Charlotte", "Vordingborg");

            List<Person> personer = new List<Person>();
            personer.Add(p1);
            personer.Add(p2);
            personer.Add(p3);


            IFormatter formatter = new BinaryFormatter();

            Stream stream = null;

            stream = new FileStream("C:/filedemo/personliste.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, personer);

            if (stream != null)
                stream.Close();

        }

        public static void DesirializationPerson()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = null;

            stream = new FileStream("C:/filedemo/personliste.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            List<Person> listepersoner = new List<Person>();

            listepersoner = (List<Person>)formatter.Deserialize(stream);

            if (stream != null)
                stream.Close();

            foreach (var person in listepersoner)
            {
                Console.WriteLine(person);
            }


        }


    }
}
