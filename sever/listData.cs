using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sever
{
    public class listData
    {
        private static listData _instance;
        public static listData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new listData();
                return _instance;
            }
        }
        private listData() { }
        public List<tabledata> load(int i, string check_stirng)
        {
            //string check_stirng = Client.data_ofTable;
            List<tabledata> table = new List<tabledata>();
            while (i < check_stirng.Length)
            {
                /*int id = int.Parse(built_string(i, check_stirng));
                string name = built_string(i,check_stirng);
                int cn = int.Parse(built_string(i, check_stirng));
                int ddt = int.Parse(built_string(i, check_stirng));
                int hp = int.Parse(built_string(i, check_stirng)); 
                int tv = int.Parse(built_string(i, check_stirng));
                tabledata p = new tabledata(id, name, cn, ddt, hp, tv);
                table.Add(p);
                i++;*/
                string tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                int id = int.Parse(tabledata);
                i++;
                tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                string name = tabledata;
                i++;
                tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                int cn = int.Parse(tabledata);
                i++;
                tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                int ddt = int.Parse(tabledata);
                i++;
                tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                int hp = int.Parse(tabledata);
                i++;
                tabledata = "";
                while (check_stirng[i] != '|' && check_stirng[i] != '*')
                {
                    tabledata += check_stirng[i];
                    i++;
                }
                int tv = int.Parse(tabledata);
                i++;
                tabledata p = new tabledata(id, name, cn, ddt, hp, tv);
                table.Add(p);
            }
            return table;
        }
    }
}
