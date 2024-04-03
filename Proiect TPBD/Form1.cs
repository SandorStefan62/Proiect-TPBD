using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        OracleConnection Connection = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=tpbd;PERSIST SECURITY INFO=True;USER ID=TPBD");
        OracleCommand Command;
        OracleDataAdapter DataAdapter;
        OracleParameter Param1, Param2, Param3, Param4, Param5, Param6, Param7;

        private bool IsEditingAngajatTable = false;
        private bool IsEditingVariabileTable = false;

        private void buttonCautareFunctie_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxFunctie.Text))
            {
                string ErrorMessage = "Eroare, campul Functie trebuie sa fie completat inainte de cautare";
                MessageBox.Show(ErrorMessage, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connection.Open();

                Param1 = new OracleParameter(":1", OracleDbType.Varchar2);

                Param1.Value = textBoxFunctie.Text;

                string Query = "select * from angajat where functie = :1";

                Command = new OracleCommand(Query, Connection);

                Command.Parameters.Add(Param1);

                DataAdapter = new OracleDataAdapter(Command);
                dataSet1.Clear();
                DataAdapter.Fill(dataSet1, "angajat");
                dataGridView1.DataSource = dataSet1.Tables["angajat"].DefaultView;

                textBoxFunctie.Text = string.Empty;

                Connection.Close();
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (IsEditingAngajatTable)
            {
                if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToString() == "SALAR_BAZA" ||
                    dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToString() == "SPOR" ||
                    dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToString() == "PREMII_BRUTE" ||
                    dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToString() == "RETINERI")
                {
                    string newValue = e.FormattedValue.ToString();
                    decimal parsedDecimal;
                    if (!decimal.TryParse(newValue, out parsedDecimal) || parsedDecimal < 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Eroare: Valoarea trebuie sa fie un numar zecimal pozitiv.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(IsEditingAngajatTable)
            {
                try
                {
                    string NewValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string OriginalValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag?.ToString();
                    int PrimaryKey = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    string ColumnName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

                    Console.WriteLine(ColumnName.ToString() == "SALAR_BAZA");

                    if (NewValue != OriginalValue)
                    {
                        BeginInvoke(new Action(() => {
                            try
                            {
                                string Query = $"update angajat set {ColumnName} = :1 where nr_crt = :2";
                                Command = new OracleCommand(Query, Connection);

                                if (ColumnName.ToString() == "SALAR_BAZA" || ColumnName.ToString() == "SPOR" || ColumnName.ToString() == "PREMII_BRUTE" || ColumnName.ToString() == "RETINERI")
                                {
                                    Console.WriteLine("ramura salar spor premii retineri");

                                    Param1 = new OracleParameter(":1", OracleDbType.Decimal);
                                    Param2 = new OracleParameter(":2", OracleDbType.Int32);

                                    Param1.Value = NewValue;
                                    Param2.Value = PrimaryKey;

                                    Command.Parameters.Add(Param1);
                                    Command.Parameters.Add(Param2);

                                    Connection.Open();
                                    Command.ExecuteNonQuery();
                                    DisplayData();
                                    Connection.Close();
                                }
                                else
                                {
                                    Console.WriteLine("Ramura nume prenume functie");
                                    Param1 = new OracleParameter(":1", OracleDbType.Varchar2);
                                    Param2 = new OracleParameter(":2", OracleDbType.Int32);

                                    Param1.Value = NewValue;
                                    Param2.Value = PrimaryKey;

                                    Command.Parameters.Add(Param1);
                                    Command.Parameters.Add(Param2);

                                    Connection.Open();
                                    Command.ExecuteNonQuery();
                                    DisplayData();
                                    Connection.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }));  
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a modificat nimic", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Exception)
                {
                    Console.WriteLine(Exception.Message.ToString());
                    MessageBox.Show("Eroare: " + Exception.Message.ToString());
                }
                finally
                {
                    IsEditingAngajatTable = false;
                    Connection.Close();
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            IsEditingAngajatTable = true;
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult Result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti acesti angajati?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Result == DialogResult.Yes)
                    {
                        Connection.Open();

                        foreach(DataGridViewRow Row in dataGridView1.SelectedRows)
                        {
                            Param1 = new OracleParameter(":1", OracleDbType.Int32);

                            Param1.Value = Convert.ToInt32(Row.Cells[0].Value);

                            string Query = "delete from angajat where nr_crt = :1";

                            Command = new OracleCommand(Query, Connection);

                            Command.Parameters.Add(Param1);

                            Command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Stergere realizata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataSet1.Tables["angajat"].Clear();
                        DisplayData();
                        Connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Va rugam sa selectati un angajat pentru stergere.", "Selectare angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string newValue = e.FormattedValue.ToString();
            decimal parsedDecimal;
            if (!decimal.TryParse(newValue, out parsedDecimal) || parsedDecimal < 0 || parsedDecimal > 100)
            {
                e.Cancel = true;
                MessageBox.Show("Eroare: Valoarea trebuie să fie un număr zecimal pozitiv și să se încadreze în intervalul [0, 100].", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            IsEditingVariabileTable = true;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(IsEditingVariabileTable)
            {
                try
                {
                    string NewValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string OriginalValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag?.ToString();
                    int PrimaryKey = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                    string ColumnName = dataGridView2.Columns[e.ColumnIndex].DataPropertyName;

                    using (var PasswordDialog = new FormPassword())
                    {
                        if(PasswordDialog.ShowDialog() == DialogResult.OK)
                        {
                            string EnteredPassword = PasswordDialog.EnteredPassword;
                            string StoredPassword = null;

                            string PasswordQuery = "select parola from variabile where id=1";

                            Command = new OracleCommand(PasswordQuery, Connection);

                            Connection.Open();
                            OracleDataReader Reader = Command.ExecuteReader();

                            if(Reader.Read())
                            {
                                StoredPassword = Reader["parola"].ToString();
                            }

                            Connection.Close();

                            if(EnteredPassword == StoredPassword)
                            {
                                if (NewValue != OriginalValue)
                                {
                                    BeginInvoke(new Action(() =>
                                    {
                                        string Query = $"update variabile set {ColumnName} = :1 where id = :2";
                                        Command = new OracleCommand(Query, Connection);

                                        Param1 = new OracleParameter(":1", OracleDbType.Int32);
                                        Param2 = new OracleParameter(":2", OracleDbType.Int32);

                                        Param1.Value = Convert.ToInt32(NewValue);
                                        Param2.Value = PrimaryKey;

                                        Command.Parameters.Add(Param1);
                                        Command.Parameters.Add(Param2);

                                        Connection.Open();
                                        Command.ExecuteNonQuery();
                                        DisplayVariabile();
                                        DisplayData();
                                        Connection.Close();
                                    }));
                                }
                                else
                                {
                                    Connection.Open();
                                    DisplayVariabile();
                                    DisplayData();
                                    Connection.Close();
                                    MessageBox.Show("Nu s-a modificat nimic", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Parola Incorecta. Campul nu a fost modificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Connection.Open();
                                DisplayVariabile();
                                Connection.Close();
                            }
                        }
                        else
                        {
                            Connection.Open();
                            DisplayVariabile();
                            Connection.Close();
                        }
                    }
                }
                catch(Exception Exception)
                {
                    MessageBox.Show("Eroare: " + Exception.Message.ToString());
                }
                finally
                {
                    IsEditingVariabileTable = false;
                    Connection.Close();
                }
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> emptyFields = new List<string>();
                if (string.IsNullOrWhiteSpace(textBoxNume.Text))
                    emptyFields.Add("Nume");
                if (string.IsNullOrWhiteSpace(textBoxPrenume.Text))
                    emptyFields.Add("Prenume");

                if(emptyFields.Any())
                {
                    string ErrorMessage = "Eroare, campurile ";
                    ErrorMessage += string.Join(", ", emptyFields);
                    ErrorMessage += " trebuie sa fie completate inainte de cautare";
                    MessageBox.Show(ErrorMessage, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Connection.Open();
                    Param1 = new OracleParameter(":1", OracleDbType.Varchar2);
                    Param2 = new OracleParameter(":2", OracleDbType.Varchar2);

                    Param1.Value = textBoxNume.Text;
                    Param2.Value = textBoxPrenume.Text;

                    string Query = "select * from angajat where nume = :1 and prenume = :2";

                    Command = new OracleCommand(Query, Connection);

                    Command.Parameters.Add(Param1);
                    Command.Parameters.Add(Param2);

                    //Console.WriteLine(Param1.Value + " " + Param2.Value);

                    DataAdapter = new OracleDataAdapter(Command);
                    dataSet1.Clear();
                    DataAdapter.Fill(dataSet1, "angajat");
                    //foreach(DataRow Row in dataSet1.Tables["angajat"].Rows)
                    //{
                    //    foreach(var item in Row.ItemArray)
                    //    {
                    //        Console.Write(item.ToString() + " ");
                    //    }
                    //    Console.Write("\n");
                    //}
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dataSet1.Tables["angajat"].DefaultView;

                    textBoxNume.Text = string.Empty;
                    textBoxPrenume.Text = string.Empty;
                    Connection.Close();
                }
            }
            catch(Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Console.WriteLine(e.Exception.ToString());
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionBackColor = Color.LightGray;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    e.FormattingApplied = true;
                }
            }
        }

        private void buttonInserare_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> emptyFields = new List<string>();
                if (string.IsNullOrWhiteSpace(textBoxNume.Text))
                    emptyFields.Add("Nume");
                if (string.IsNullOrWhiteSpace(textBoxPrenume.Text))
                    emptyFields.Add("Prenume");
                if (string.IsNullOrWhiteSpace(textBoxFunctie.Text))
                    emptyFields.Add("Functie");
                if (string.IsNullOrWhiteSpace(textBoxSalarBaza.Text))
                    emptyFields.Add("Salar Baza");
                if (string.IsNullOrWhiteSpace(textBoxSpor.Text))
                    emptyFields.Add("Spor");
                if (string.IsNullOrWhiteSpace(textBoxPremiiBrute.Text))
                    emptyFields.Add("Premii Brute");
                if (string.IsNullOrWhiteSpace(textBoxRetineri.Text))
                    emptyFields.Add("Retineri");

                if (emptyFields.Any())
                {
                    string errorMessage = "Eroare, campurile ";
                    errorMessage += string.Join(", ", emptyFields);
                    errorMessage += " trebuie sa fie completate inainte de a insera datele";
                    MessageBox.Show(errorMessage, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Connection.Open();

                Param1 = new OracleParameter(":1", OracleDbType.Varchar2);
                Param2 = new OracleParameter(":2", OracleDbType.Varchar2);
                Param3 = new OracleParameter(":3", OracleDbType.Varchar2);
                Param4 = new OracleParameter(":4", OracleDbType.Decimal);
                Param5 = new OracleParameter(":5", OracleDbType.Decimal);
                Param6 = new OracleParameter(":6", OracleDbType.Decimal);
                Param7 = new OracleParameter(":7", OracleDbType.Decimal);

                Param1.Value = textBoxNume.Text;
                Param2.Value = textBoxPrenume.Text;
                Param3.Value = textBoxFunctie.Text;
                Param4.Value = decimal.Parse(textBoxSalarBaza.Text);
                Param5.Value = decimal.Parse(textBoxSpor.Text);
                Param6.Value = decimal.Parse(textBoxPremiiBrute.Text);
                Param7.Value = decimal.Parse(textBoxRetineri.Text);

                string Query = "insert into angajat (nume, prenume, functie, salar_baza, spor, premii_brute, retineri) values (:1, :2, :3, :4, :5, :6, :7)";

                Command = new OracleCommand(Query, Connection);

                Command.Parameters.Add(Param1);
                Command.Parameters.Add(Param2);
                Command.Parameters.Add(Param3);
                Command.Parameters.Add(Param4);
                Command.Parameters.Add(Param5);
                Command.Parameters.Add(Param6);
                Command.Parameters.Add(Param7);

                Command.ExecuteNonQuery();
                DisplayData();

                MessageBox.Show("Inregistrarea a fost adaugata cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNume.Text = string.Empty;
                textBoxPrenume.Text = string.Empty;
                textBoxFunctie.Text = string.Empty;
                textBoxSalarBaza.Text = string.Empty;
                textBoxSpor.Text = "0";
                textBoxPremiiBrute.Text = "0";
                textBoxRetineri.Text = "0";

                Connection.Close();
            }
            catch(Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        private void buttonGenerareStatPlata_Click(object sender, EventArgs e)
        {
            CrystalReport3 Report = new CrystalReport3();
            Report.SetDataSource(dataSet1.Tables["angajat"]);
            crystalReportViewer1.ReportSource = Report;
        }

        private void buttonFluturasi_Click(object sender, EventArgs e)
        {
            CrystalReport4 Report = new CrystalReport4();
            DataSet NewDataSet = new DataSet();

            DataTable DataTable = dataSet1.Tables["angajat"]; // Get the DataTable directly from your DataSet

            bool anyRowSelected = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    anyRowSelected = true;
                    break;
                }
            }

            if (anyRowSelected)
            {
                DataTable SelectedDataTable = DataTable.Clone();
                foreach (DataGridViewRow SelectedRow in dataGridView1.SelectedRows)
                {
                    DataRowView SelectedRowView = (DataRowView)SelectedRow.DataBoundItem;
                    SelectedDataTable.ImportRow(SelectedRowView.Row);
                }

                SelectedDataTable.TableName = "angajat";

                NewDataSet.Tables.Add(SelectedDataTable);

                Report.SetDataSource(NewDataSet.Tables["angajat"]);
                crystalReportViewer1.ReportSource = Report;
            }
            else
            {
                NewDataSet.Tables.Add(DataTable.Copy()); // Create a copy of the DataTable

                Report.SetDataSource(NewDataSet.Tables["angajat"]);
                crystalReportViewer1.ReportSource = Report;
            }
        }

        private void DisplayVariabile()
        {
            try
            {
                string VariabileQuery = "select * from variabile";
                DataAdapter = new OracleDataAdapter(VariabileQuery, Connection);
                DataAdapter.Fill(dataSet2, "variabile");
                dataGridView2.DataSource = dataSet2.Tables["variabile"].DefaultView;
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
        }

        private void DisplayData()
        {
            try
            {
                string Query = "select * from angajat";
                DataAdapter = new OracleDataAdapter(Query, Connection);
                DataAdapter.Fill(dataSet1, "angajat");
                dataGridView1.DataSource = dataSet1.Tables["angajat"].DefaultView;
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Clear();
                Connection.Open();
                string Query = "select * from angajat";
                DataAdapter = new OracleDataAdapter(Query, Connection);
                DataAdapter.Fill(dataSet1, "angajat");
                dataGridView1.DataSource = dataSet1.Tables["angajat"].DefaultView;
                Connection.Close();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Eroare: " + Exception.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.VARIABILE' table. You can move, or remove it, as needed.
            this.vARIABILETableAdapter.Fill(this.dataSet2.VARIABILE);
            // TODO: This line of code loads data into the 'dataSet1.ANGAJAT' table. You can move, or remove it, as needed.
            this.aNGAJATTableAdapter.Fill(this.dataSet1.ANGAJAT);

            SetReadOnlyColumns(dataGridView1, new int[] { 0, 7, 8, 9, 10, 11, 13 });

            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void SetReadOnlyColumns(DataGridView dataGridView, int[] readOnlyColumns)
        {
            foreach (int columnIndex in readOnlyColumns)
            {
                DataGridViewColumn column = dataGridView.Columns[columnIndex];

                column.ReadOnly = true;

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = SystemColors.Control;
                column.DefaultCellStyle = cellStyle;
            }
        }
    }
}
