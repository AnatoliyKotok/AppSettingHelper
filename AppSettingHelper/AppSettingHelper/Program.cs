using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettingHelper_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Setting.txt";
            AppSettingHelper.AppSettingHelper.WriteSetting(fname);
            AppSettingHelper.AppSettingHelper.ReadSetting(fname);
        }
    }
}
