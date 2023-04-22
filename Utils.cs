using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Utils
{
    public static void WriteFile(string path, string s)
    {
        // 打开文件
        using (FileStream file = new FileStream("a.txt", FileMode.Create))
        {
            // 字符串s转byte[]
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            // 写入byte[]到文件
            file.Write(bytes, 0, bytes.Length);
        }
    }

    public static string ReadFile(string path)
    {
        string s = " ";
        using (FileStream file = new FileStream("a.txt", FileMode.Open))
        {
            byte[] bytes = new byte[10240];

            // 这里的大小是我们人为设定的，大小不能超过10k
            // realReadLen是实际读取的字节数
            int realReadLen = file.Read(bytes, 0, 10240);    // file.Read(字节数组，开始下标，最多读取的字节数）

            s = Encoding.UTF8.GetString(bytes, 0, realReadLen);
        }
        return s;
    }

}

