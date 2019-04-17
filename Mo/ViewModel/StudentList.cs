using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mo.ViewModel
{
    public class StudentList
    {
        public int ID { get; set; }//学生编号
        public string StudentName { get; set; }//姓名
        public string Password { get; set; }//密码
        public string  Gender { get; set; }//性别
        public string Phone { get; set; }//电话
        public string CardID { get; set; }//身份证号
        public string Address { get; set; }//住址
        public string Email { get; set; }//邮箱
        public DateTime Borndate { get; set; }//出生日期
        public DateTime CreateTime { get; set; }//入学时间
        public string XueLi { get; set; }//学历
        public string MinZu { get; set; }//民族
        public string ZhengMian { get; set; }//政治面貌
        public string ClassName { get; set; }//班级编号

        

    }
}
