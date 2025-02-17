﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Project40.DataLayer.Entity;

namespace Project40.DataLayer.DatabaseType
{
    public class DataBaseTK
    {
        private string path = string.Empty;
        public DataBaseTK(string path)
        {
            this.path = path;
        }
        //ham doc file tu text
        public List<User> ReadListUser()
        {
            List<User> users = null;
            //cau truc doc file
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))//lỗi
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    User user;
                    users = new List<User>();
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            user = new User()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TaiKhoan = vs[1],
                                MatKhau = vs[2],
                                HoVaTen = vs[3],
                                NhoMatKhau = Convert.ToBoolean(vs[4])
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
        //ham ghi vao file txt user
        public bool WriteUsertoFile(List<User> users)
        {
            bool result = false;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (User item in users)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                    result = true;
                }
            }
            return result;
        }

    }

}
