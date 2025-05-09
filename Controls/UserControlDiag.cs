using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Tables;

using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace Schedully.Controls
{
    public partial class UserControlDiag : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        string fname, lname, mid,   age, gender, contact, address;
        string diseaseResult, sufferResult;
        public UserControlDiag()
        {
            InitializeComponent();
        }

        private void UserControlDiag_Load(object sender, EventArgs e)
        {
            clientnamesload();
        }

        private void clientnamesload()
        {
            string query = "SELECT Firstname, Lastname FROM Clients";

            List<string> clientNames = new List<string>();
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string firstName = reader["Firstname"].ToString();
                                string lastName = reader["Lastname"].ToString();
                                string fullName = $"{firstName} {lastName}";
                                clientNames.Add(fullName);
                            }
                        }
                    }

                    // Add names to the ComboBox
                    clientbox.Items.Clear();
                    clientbox.Items.AddRange(clientNames.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private int getclientid()
        {
            if (clientbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a client.");
                return -1; // Indicates no selection
            }

            string fullname = clientbox.SelectedItem.ToString();
            string[] nameParts = fullname.Split(' ');

            if (nameParts.Length < 2)
            {
                MessageBox.Show("Full name must include both first and last names.");
                return -1; // Indicates invalid name format
            }

            string firstname = nameParts[0];
            string lastname = nameParts[1];
            int clientId = -1;

            string query = "SELECT ClientID FROM Clients WHERE Firstname = ? AND Lastname = ?";

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", firstname);
                        cmd.Parameters.AddWithValue("?", lastname);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out clientId))
                        {
                            MessageBox.Show("ID: " + clientId);
                            return clientId;
                         
                        }   
                        else
                        {
                            MessageBox.Show("Client ID not found.");
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return -1;
                }
            }
        }
        private void patientdetails()
        {

            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb";
       
            string query = "SELECT * FROM Clients WHERE ClientID = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", getclientid());

                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fname = reader["Firstname"].ToString();
                           mid = reader["Midinitial"].ToString();
                           lname = reader["Lastname"].ToString();
                           address = reader["Address"].ToString();
                            age = reader["Age"].ToString();
                             gender = reader["Gender"].ToString();
                            contact = reader["Contact"].ToString();

                           

                                              }
                       
                    }
                }
            }


        }
        private void inputdiagnosis()
        {
            List<string> disease = new List<string>();
            string norm = "normal";


            foreach (Control control in diseasegroup.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {

                    disease.Add(checkbox.Text);
                }
            }
            diseaseResult = string.Join(", ", disease);

            List<string> suffer = new List<string>();


            foreach (Control control in suffergroup.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {

                    suffer.Add(checkbox.Text);
                }
            }
             sufferResult = string.Join(", ", suffer);




            string insertFullClientQuery = "INSERT INTO Client_DIagnosis (diagID, PastDisease, Suffering, Allergies, Hospitalization, Medication, illness, Accident, Bp, PR, Ht, Wt, Skin, EENT, Neck, Mouth, Chest, Lungs, Heart, Abdomen, Back, Genital, Reflexes, Extremities) " +
                                           "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";



            using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    myConn.Open();


                    using (OleDbCommand clientCmd = new OleDbCommand(insertFullClientQuery, myConn))
                    {
                        clientCmd.Parameters.AddWithValue("?", getclientid());
                        clientCmd.Parameters.AddWithValue("?", diseaseResult);
                        clientCmd.Parameters.AddWithValue("?", sufferResult);
                        clientCmd.Parameters.AddWithValue("?", allergiestext.Text);
                        clientCmd.Parameters.AddWithValue("?", hospitalizationtext.Text);
                        clientCmd.Parameters.AddWithValue("?", medicationtext.Text);
                        clientCmd.Parameters.AddWithValue("?", illnesstext.Text);
                        clientCmd.Parameters.AddWithValue("?", brokenbonestext.Text);
                        clientCmd.Parameters.AddWithValue("?", bptext.Text);
                        clientCmd.Parameters.AddWithValue("?", prtext.Text);
                        clientCmd.Parameters.AddWithValue("?", Httext.Text);
                        clientCmd.Parameters.AddWithValue("?", Wttext.Text);
                        if (skincheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", skinfindings.Text);
                        }


                        if (eentbox.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", eentfindings.Text);
                        }


                        if (neckcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", neckfindings.Text);
                        }


                        if (mouthcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", mouthfindings.Text);
                        }


                        if (chestcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {

                            clientCmd.Parameters.AddWithValue("?", chestfindings.Text);
                        }


                        if (lungcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", lungsfindings.Text);
                        }


                        if (heartcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", heartfindings.Text);
                        }


                        if (abdomencheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", abdomenfindings.Text);
                        }


                        if (backcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", backfindings.Text);
                        }


                        if (genitalcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", genitalfindings.Text);
                        }


                        if (reflexcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", reflexesfindings.Text);
                        }


                        if (extremcheck.Checked == true)
                        {
                            clientCmd.Parameters.AddWithValue("?", norm);
                        }
                        else
                        {
                            clientCmd.Parameters.AddWithValue("?", extremfindings.Text);
                        }


                        clientCmd.ExecuteNonQuery();
                    }

                   

                    MessageBox.Show("Saved Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            inputdiagnosis();
            patientdetails();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveDialog.Title = "Save Diagnosis PDF";
            saveDialog.FileName = "DiagnosisReport.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;
                createpdf(filePath);
            }
        }

        private void createpdf(string filepath)
        {
            Document document = new Document();

            Section section = document.AddSection();


            Paragraph title = section.AddParagraph("Diagnosis Report");
            title.Format.Font.Size = 18;
            title.Format.Font.Bold = true;
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.SpaceAfter = "1cm";

            Paragraph line = section.AddParagraph();
            line.Format.Borders.Bottom.Width = 1;
            line.Format.SpaceBefore = "0.5cm";
            line.Format.SpaceAfter = "0.5cm";

            Paragraph patientHeader = section.AddParagraph("Patient Details");
            patientHeader.Format.Font.Size = 14;
            patientHeader.Format.Font.Bold = true;
            patientHeader.Format.SpaceAfter = "0.5cm";

            // Add a table for patient details
            Table table = section.AddTable();
            table.Borders.Visible = false; // no borders

            // Define two columns
            Column col1 = table.AddColumn("7cm");
            Column col2 = table.AddColumn("7cm");

            // Add a row for Name and Gender
            Row row1 = table.AddRow();
            Paragraph p1 = row1.Cells[0].AddParagraph("Name: " + fname +" "+ mid +" "+ lname);
            Paragraph p2 = row1.Cells[1].AddParagraph("Gender: " + gender);
            p1.Format.Font.Size = 12;
            p2.Format.Font.Size = 12;


            // Add a row for Address and Age
            Row row2 = table.AddRow();
            Paragraph p3 = row2.Cells[0].AddParagraph("Address: " + address);
            Paragraph p4= row2.Cells[1].AddParagraph("Age: " + age);
            p3.Format.Font.Size = 12;
            p4.Format.Font.Size = 12;


            // Add a row for Contact (you can leave the right cell blank)
            Row row3 = table.AddRow();
            Paragraph p5 = row3.Cells[0].AddParagraph("Contact: " + contact);
            row3.Cells[1].AddParagraph(""); // blank for now
            p5.Format.Font.Size = 12;

            Paragraph line2 = section.AddParagraph();
            line2.Format.Borders.Bottom.Width = 1;
            line2.Format.SpaceBefore = "0.5cm";
            line2.Format.SpaceAfter = "0.5cm";

            // MEdical history nani dapita
            Paragraph patientHeader2 = section.AddParagraph("Medical History");
            patientHeader2.Format.Font.Size = 14;
            patientHeader2.Format.Font.Bold = true;
            patientHeader2.Format.SpaceAfter = "0.5cm";

            Table table2 = section.AddTable();
            Column colo1 = table2.AddColumn("7cm");
            Column colo2 = table2.AddColumn("7cm");

            Row rows1 = table2.AddRow();

           Paragraph p6 =  rows1.Cells[0].AddParagraph("Previous disease/s: " + diseaseResult);
            Paragraph p7 = rows1.Cells[1].AddParagraph("Suffers Frequently: " + sufferResult);
            p6.Format.Font.Size = 12;
            p7.Format.Font.Size = 12;


            Row rows2 = table2.AddRow();

            Paragraph p8 = rows2.Cells[0].AddParagraph("Allergies: " + allergiestext.Text);
            Paragraph p9= rows2.Cells[1].AddParagraph("Hospitalization: " + hospitalizationtext.Text);
            p8.Format.Font.Size = 12;
            p9.Format.Font.Size = 12;


            Row rows3 = table2.AddRow();

           Paragraph p10 =  rows3.Cells[0].AddParagraph("Medication: " + medicationtext.Text);
            Paragraph p11 = rows3.Cells[1].AddParagraph("Past illness: " + illnesstext.Text);
            p10.Format.Font.Size = 12;
            p11.Format.Font.Size = 12;


            Row rows4 = table2.AddRow();

            Paragraph p12 = rows4.Cells[0].AddParagraph("Accidents/Broken bones: " + brokenbonestext.Text);
            rows4.Cells[1].AddParagraph("");
            p12.Format.Font.Size = 12;


            Paragraph line3 = section.AddParagraph();
            line3.Format.Borders.Bottom.Width = 1;
            line3.Format.SpaceBefore = "0.5cm";
            line3.Format.SpaceAfter = "0.5cm";

            
            //for examiantion record

            Paragraph patientHeader3 = section.AddParagraph("Examination Record");
            patientHeader3.Format.Font.Size = 14;
            patientHeader3.Format.Font.Bold = true;
            patientHeader3.Format.SpaceAfter = "0.5cm";

            Table tableexam = section.AddTable();
            Column colexam1 = tableexam.AddColumn("7cm");
            Column colexamn2 = tableexam.AddColumn("7cm");
            Column colexam3 = tableexam.AddColumn("7cm");
            Column colexam4 = tableexam.AddColumn("7cm");

            Row rowexam1 = tableexam.AddRow();

            Paragraph p13 = rowexam1.Cells[0].AddParagraph("Bp: " + bptext.Text);
            Paragraph p14 = rowexam1.Cells[1].AddParagraph("PR: " + prtext.Text);
            Paragraph p15 = rowexam1.Cells[2].AddParagraph("Ht: " + Httext.Text);
            Paragraph p16 = rowexam1.Cells[3].AddParagraph("Wt: " + Wttext.Text);
            p13.Format.SpaceAfter = "0.5cm";
            p14.Format.SpaceAfter = "0.5cm";
            p15.Format.SpaceAfter = "0.5cm";
            p16.Format.SpaceAfter = "0.5cm";


            Row rowexam2 = tableexam.AddRow();

            Paragraph p17 = rowexam2.Cells[0].AddParagraph("");
            Paragraph p18 = rowexam2.Cells[1].AddParagraph("Normal");
            Paragraph p19 = rowexam2.Cells[2].AddParagraph("Findings");

            Row rowexam3 = tableexam.AddRow();

            Paragraph p20 = rowexam3.Cells[0].AddParagraph("Skin");


            if (skincheck.Checked == true)
            {
              
                Paragraph p21 = rowexam3.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p22 = rowexam3.Cells[2].AddParagraph("" + skinfindings.Text);
            }
        

            Row rowexam4 = tableexam.AddRow();

            Paragraph p23 = rowexam4.Cells[0].AddParagraph("EENT");


            if (eentbox.Checked == true)
            {
                Paragraph p24 = rowexam4.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p25 = rowexam4.Cells[2].AddParagraph("" + eentfindings.Text);
            }

       

            Row rowexam5 = tableexam.AddRow();

            Paragraph p26 = rowexam5.Cells[0].AddParagraph("Neck/Thyroid");

            if (neckcheck.Checked == true)
            {

                Paragraph p27 = rowexam5.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p28 = rowexam5.Cells[2].AddParagraph("" + neckfindings.Text);
            }

         

            Row rowexam6 = tableexam.AddRow();

            Paragraph p29 = rowexam6.Cells[0].AddParagraph("Mouth/Throat");

            if (mouthcheck.Checked == true)
            {

                Paragraph p30 = rowexam6.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p31 = rowexam6.Cells[2].AddParagraph("" + mouthfindings.Text);
            }
       

            Row rowexam7 = tableexam.AddRow();

            Paragraph p32 = rowexam7.Cells[0].AddParagraph("Chest/Breast/Axilas");

            if (chestcheck.Checked == true)
            {
                Paragraph p33 = rowexam7.Cells[1].AddParagraph("normal");

            }
            else
            {
                Paragraph p34 = rowexam7.Cells[2].AddParagraph("" + chestfindings.Text);
            }
      
            Row rowexam8 = tableexam.AddRow();

            Paragraph p35 = rowexam8.Cells[0].AddParagraph("Lungs");
            if (lungcheck.Checked == true)
            {

                Paragraph p36 = rowexam8.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p37 = rowexam8.Cells[2].AddParagraph("" + lungsfindings.Text);
            }
       
            Row rowexam9 = tableexam.AddRow();

            Paragraph p38 = rowexam9.Cells[0].AddParagraph("Heart");
            if (heartcheck.Checked == true)
            {

                Paragraph p39 = rowexam9.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p40 = rowexam9.Cells[2].AddParagraph("" + heartfindings.Text);

            }
         
            Row rowexam10 = tableexam.AddRow();

            Paragraph p41 = rowexam10.Cells[0].AddParagraph("Abdomen");
            if (abdomencheck.Checked == true)
            {

                Paragraph p42 = rowexam10.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p43 = rowexam10.Cells[2].AddParagraph("" + abdomenfindings.Text);

            }
      
            Row rowexam11 = tableexam.AddRow();

            Paragraph p44 = rowexam11.Cells[0].AddParagraph("Back");
            if (backcheck.Checked == true)
            {

                Paragraph p45 = rowexam11.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p46 = rowexam11.Cells[2].AddParagraph("" + backfindings.Text);

            }
               

            Row rowexam12 = tableexam.AddRow();

            Paragraph p47 = rowexam12.Cells[0].AddParagraph("Genital");
            if (genitalcheck.Checked == true)
            {

                Paragraph p48 = rowexam12.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p49 = rowexam12.Cells[2].AddParagraph("" + genitalfindings.Text);

            }
           

            Row rowexam13 = tableexam.AddRow();

            Paragraph p50 = rowexam13.Cells[0].AddParagraph("Reflexes");
            if (reflexcheck.Checked == true)
            {

                Paragraph p51 = rowexam13.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p52 = rowexam13.Cells[2].AddParagraph("" + reflexesfindings.Text);

            }
          
            Row rowexam14 = tableexam.AddRow();

            Paragraph p53 = rowexam14.Cells[0].AddParagraph("Extremities");
            if (extremcheck.Checked == true)
            {
                Paragraph p54 = rowexam14.Cells[1].AddParagraph("normal");
            }
            else
            {
                Paragraph p55 = rowexam14.Cells[2].AddParagraph("" + extremfindings.Text);

            }
         




            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true); 
            renderer.Document = document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filepath);


            MessageBox.Show("Succesful!");
        }

       
    }
}
