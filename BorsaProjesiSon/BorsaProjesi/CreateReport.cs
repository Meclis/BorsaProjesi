using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace BorsaProjesi
{
    public partial class CreateReport : Form
    {
        List<User> users;
        int UserIndex;
        SqlConnect sqlConnect = new SqlConnect();
        SqlConnection con;
        public CreateReport(List<User> users2,int index)
        {
            InitializeComponent();
            users = users2;
            UserIndex = index;
        }

        private void CreateReport_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-Q3V1DGN9\\SQLEXPRESS;Initial Catalog=YazilimYapimi;Integrated Security=True");
        }

   
    

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            PdfPTable pdfTable = new PdfPTable(4);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText=="Tarih" || column.HeaderText == "UrunAdi" || column.HeaderText == "UrunFiyati" || column.HeaderText == "UrunBirimi")
                {
                  
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontNormal));
                    pdfTable.AddCell(cell);
                }
               
            }

            int row = dataGridView1.Rows.Count;
            int cell2 = dataGridView1.Rows[1].Cells.Count;

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (j==0 || j==1 || j==3 || j==4)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = "null";
                        }
                        pdfTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                  
                }
            }


            //PDF'e Aktarma
            string folderPath = @"C:\pdf\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "rapor.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("PDF başarıyla oluşturuldu! " + folderPath);

        }

        DataTable DataListById()
        {
            string sql = "Select *from SatinAlmaGecmisi where Tarih BETWEEN @tar1 and @tar2 and UrunAliciId=@p1 or UrunSaticiId=@p2";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@tar1", SqlDbType.Date).Value = dateTimePicker1.Value.ToString();
            dataAdapter.SelectCommand.Parameters.AddWithValue("@tar2", SqlDbType.Date).Value = dateTimePicker2.Value.ToString();
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p1", UserIndex+1);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@p2", UserIndex+1);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            return dataTable;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            DataListById();

        }
    }
}
