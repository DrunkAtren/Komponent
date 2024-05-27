using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komponent;

namespace Komponent
{
    public interface IMainApp
    {

        DataGridViewRowCollection GetRows();

        DataGridViewColumnCollection GetColumns();

        DataGridViewRow GetRowById(int Index);

        List<string> GetColumnData(string columnName);

        DataGridViewColumn GetColumnById(int Index);

        imp_dat = new import_datas(dgvDataSetMainApp);

        int GetRowCount();

        int GetColumnCount();

        List<string> GetColumnNames();

        void AddDataToColumn(string columnName, List<string> data);
    }
}
