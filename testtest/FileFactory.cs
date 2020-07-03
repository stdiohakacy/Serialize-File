using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace testtest
{
    public class FileFactory
    {
        public static bool saveFile(List<Student> listStudent, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listStudent);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Student> readFile(string path)
        {
            List<Student> listStudent = new List<Student>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                listStudent = data as List<Student>;
                fs.Close();
                return listStudent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
