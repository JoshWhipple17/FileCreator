using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TextFileMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string dir = @"C:\Users\Josh\Desktop\Files\";

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSubject.Focus();
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "") {
                // check if the directory exists, if not then its created
                CheckForDirectory();

                // create the path
                string path = dir + GetFileName(".txt");
                
                // if the file exists then an exception is thrown
                try
                {
                    // create a file stream and write to the file
                    StreamWriter textContent = new StreamWriter(
                        new FileStream(path, FileMode.CreateNew, FileAccess.Write));

                    // write to the file
                    textContent.Write(txtSubject.Text + "|");
                    textContent.WriteLine(txtContent.Text);

                    // close the stream, clear the boxes, and display a confirmation message
                    textContent.Close();
                    ClearBoxes(GetFileName(".txt"));
                    
                }
                catch (IOException ex)
                {
                    MessageBox.Show("This file already exists. " +
                        "Please rename the file by changing the subject", "File Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a subject.");
            }
        }

        private void btnXMLFile_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "")
            {
                // check if the directory exists, if not then its created
                CheckForDirectory();

                // create the path
                string path = dir + GetFileName(".xml");

                if (!File.Exists(path))
                {
                    // create the XmlWriterSettings object
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.IndentChars = ("    ");

                    // create the XmlWriter object
                    XmlWriter xmlOut = XmlWriter.Create(path, settings);

                    // write the start of the document
                    xmlOut.WriteStartDocument();
                    xmlOut.WriteStartElement("FileContents");

                    //write each part of the file to the xml document
                    xmlOut.WriteElementString("Subject", txtSubject.Text);
                    xmlOut.WriteElementString("Content", txtContent.Text);

                    // write the end tag for the root element
                    xmlOut.WriteEndElement();

                    // close the XmlWriter object
                    xmlOut.Close();

                    // clear the boxes and display a confirmation message
                    ClearBoxes(GetFileName(".xml"));
                }
                else
                {
                    MessageBox.Show("This file already exists. " +
                        "Please rename the file by changing the subject", "File Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a subject.");
            }
        }

        private void btnBinaryFile_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "")
            {
                // check if the directory exists, if not then its created
                CheckForDirectory();

                // create the path
                string path = dir + GetFileName(".dat");

                // if the file exists then an exception is thrown
                try
                {
                    // create a file stream
                    BinaryWriter binaryOut = new BinaryWriter(
                        new FileStream(path, FileMode.CreateNew, FileAccess.Write));

                    // write to the file
                    binaryOut.Write(txtSubject.Text);
                    binaryOut.Write(txtContent.Text);

                    // close the stream
                    binaryOut.Close();

                    // clear the boxes and display a confirmation message
                    ClearBoxes(GetFileName(".dat"));

                }
                catch (IOException ex)
                {
                    MessageBox.Show("This file already exists. " +
                        "Please rename the file by changing the subject", "File Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a subject.");
            }
        }

        private string GetFileName(string fileType)
        {
            string fileName = txtSubject.Text;

            // capitalize the letter after any spaces
            char[] arr = fileName.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] == ' ') && (i + 1 < arr.Length))
                {
                    arr[i + 1] = Convert.ToChar(fileName.Substring(i + 1, 1).ToUpper());
                }
            }

            // create the formatted file name
            fileName = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    fileName += arr[i];
                }
            }

            return fileName + fileType;
        }

        private void ClearBoxes(string fileName)
        {
            MessageBox.Show(fileName + " was created.");
            txtSubject.Text = "";
            txtContent.Text = "";
        }

        private void CheckForDirectory()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

       
    }
}
