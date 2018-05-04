using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions1
{
  public  class Diary
    {

        //public string Date { get; set; }
        //public string Site { get; set; }
        //public string Diary { get; set; }


      /// <summary>
      /// 写入方法
      /// </summary>
      /// <param name="date"></param>
      /// <param name="Site"></param>
      /// <param name="Diary"></param>
      public void record(string date, string Site, string Diary)
      {
          try
          { 
              //创建流                                                      追加
              FileStream fs = new FileStream("D:\\"+Site+".txt", FileMode.Append);
              //创建写入器
              StreamWriter sw = new StreamWriter(fs);
              sw.WriteLine();
              //写入
              sw.WriteLine("日期："+date+"    "+"地点："+Site+"    "+"日志："+Diary);
              sw.WriteLine();
              //关闭写入器
              sw.Close();
              //关闭流
              fs.Close();
              //提示
              System.Windows.Forms.MessageBox.Show("保存成功");
          }
          catch (Exception)
          {

              System.Windows.Forms.MessageBox.Show("系统异常！");
          }
        
      
      }


      //public void read(string date, string Site, string Diary)
      //{
      //    FileStream fs = new FileStream("D:\\Diary.txt", FileMode.Create);
      //    StreamReader sr = new StreamReader(fs);
      //    string Total = sr.ReadToEnd();
      //    sr.Close();
      //    fs.Close();

      //}


    }
}
