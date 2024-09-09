using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using DevExpress.Utils.Extensions;

namespace UniqueRowToggle
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            CreatePathDockPanel();
        }
        public class DataHelper
        {
            public static string[] companies = new string[] { "Hanari Carnes", "Que Delícia", "Romero y tomillo", "Mère Paillarde",
            "Comércio Mineiro", "Reggiani Caseifici", "Maison Dewey" };
            public static BindingList<Record> GetData(int count)
            {
                BindingList<Record> records = new BindingList<Record>();
                Random rnd = new Random();
                for (int i = 0; i < count; i++)
                {
                    int n = rnd.Next(10);
                    records.Add(new Record()
                    {
                        ID = i + 100,
                        CompanyName = companies[i % companies.Length],
                        RequiredDate = DateTime.Today.AddDays(n - 5),
                        Value = i % 2 == 0 ? (i + 1) * 123 : i * 231
                    });
                };
                return records;
            }
        }
        public class Record : INotifyPropertyChanged
        {
            public Record()
            {
            }
            int id;
            public int ID
            {
                get { return id; }
                set
                {
                    if (id != value)
                    {
                        id = value;
                        OnPropertyChanged();
                    }
                }
            }

            string text;
            [DisplayName("Company")]
            public string CompanyName
            {
                get { return text; }
                set
                {
                    if (text != value)
                    {
                        if (string.IsNullOrEmpty(value))
                            throw new Exception();
                        text = value;
                        OnPropertyChanged();
                    }
                }
            }
            Nullable<decimal> val;
            [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
            [DisplayName("Payment")]
            public Nullable<decimal> Value
            {
                get { return val; }
                set
                {
                    if (val != value)
                    {
                        val = value;
                        OnPropertyChanged();
                    }
                }
            }
            DateTime dt;
            [DisplayFormat(DataFormatString = "d")]
            public DateTime RequiredDate
            {
                get { return dt; }
                set
                {
                    if (dt != value)
                    {
                        dt = value;
                        OnPropertyChanged();
                    }
                }
            }
            bool state;
            public bool Processed
            {
                get { return state; }
                set
                {
                    if (state != value)
                    {
                        state = value;
                        OnPropertyChanged();
                    }
                }
            }

            public override string ToString()
            {
                return string.Format("ID = {0}, Text = {1}", ID, CompanyName);
            }

            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void CreatePathDockPanel()
        {
            GridControl gridControl = new GridControl()
            {
                Name = "gridControl1",
                Dock = DockStyle.Fill
            };
            gridControl.DataSource = DataHelper.GetData(30);
            this.pathManagerDockPanel.ControlContainer.AddControl(gridControl);

            // 创建 GridView
            DevExpress.XtraGrid.Views.Grid.GridView gridView = new DevExpress.XtraGrid.Views.Grid.GridView(gridControl);
            gridControl.MainView = gridView;
            gridView.CellValueChanging += GridView_CellValueChanging;
        }
        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "Processed")
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view == null) return;
                bool newValue = (bool)e.Value;
                if (newValue)
                {
                    // 遍历所有行，取消当前行之外的所有行的勾选
                    for (int i = 0; i < view.RowCount; i++)
                    {
                        if (i != e.RowHandle)
                        {
                            view.SetRowCellValue(i, "Processed", false);
                        }
                    }
                }
                else
                {
                    // 如果用户试图取消选中，我们阻止这个操作
                    view.SetRowCellValue(e.RowHandle, "Processed", true);
                }
                // 刷新视图以显示更改
                view.RefreshData();
            }
        }
    }
}
