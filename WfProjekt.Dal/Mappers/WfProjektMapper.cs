using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using WfProjekt.Model;

namespace WfProjekt.Dal.Mappers
{
    public class WfProjektMapper
    {
        public WfProjektModel FillFromReader(IDataReader pendingReader)
        {
            return new WfProjektModel(pendingReader.GetValue(0).ToString(), Convert.ToInt32(pendingReader.GetValue(1)), Convert.ToInt32(pendingReader.GetValue(3)), Convert.ToInt32(pendingReader.GetValue(2)),
                pendingReader.GetValue(5).ToString(), Convert.ToDouble(pendingReader.GetValue(4)), Convert.ToDouble(pendingReader.GetValue(6)), pendingReader.GetValue(7).ToString(), pendingReader.GetValue(8).ToString(), pendingReader.GetValue(9).ToString());
        }
    }
}
