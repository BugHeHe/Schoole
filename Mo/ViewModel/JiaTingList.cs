using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mo.ViewModel
{
    public class JiaTingList
    {
        public int ID { get; set; }
        public string StudentName { get; set; }//引用学生ID
        public string Name { get; set; }//家庭人员名称
        public string Phone { get; set; }//联系方式 多个， 隔开
        public string Guan { get; set; }//与学生之间的关系
        public string Job { get; set; }//工作单位
        public string Zhi { get; set; }//
    }
}
