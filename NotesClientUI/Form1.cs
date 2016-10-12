using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesClient;


namespace NotesClientUI
{

    public partial class Form1 : Form
    {
        //TODO: present array of available note id's to numeric updowns
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGetNote_Click(object sender, EventArgs e)
        {

            var clientAPI = new NotesAPIClient();

            var noteID = numNoteID.Text;

            if (!string.IsNullOrWhiteSpace(noteID))
            {
                var result = clientAPI.GetNote(noteID);


                if (result.description == "The server has not found anything matching the request URI")
                {
                    MessageBox.Show(result.description);
                }
                else
                {

                    var sb = new StringBuilder();
                    sb.Append("Id: " + result.id + "\r\n");
                    sb.Append("Title: " + result.title + "\r\n");
                    sb.Append("Description: " + result.description + "\r\n");

                    var noteToTextBox = sb.ToString();
                    txtNoteDetails.Text = noteToTextBox;

                    txtUpdateTitle.Text = result.title;
                    txtUpdateDescription.Text = result.description;
                    numDelete.Text = result.id;
                    numUpdateId.Text = result.id;

                }
            }
            else
            {
                MessageBox.Show("Please enter a note Id");
            }

        }

        private void btnListAllNotes_Click(object sender, EventArgs e)
        {
            txtNoteDetails.Text = "";

            var clientAPI = new NotesAPIClient();

            var result = clientAPI.GetAllNotes();

            var sb = new StringBuilder();

            foreach (var note in result)
            {
                sb.Append("Id: " + note.id + "\r\n");
                sb.Append("Title: " + note.title + "\r\n");
                sb.Append("\r\n");
            }

            var noteToTextBox = sb.ToString();
            txtNoteDetails.Text = noteToTextBox;
            txtUpdateTitle.Text = "";
            txtUpdateDescription.Text = "";
            numDelete.Text = "";
            numUpdateId.Text = "";
            numNoteID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var clientAPI = new NotesAPIClient();

            var title = txtUpdateTitle.Text;
            var description = txtUpdateDescription.Text;

            string id = numUpdateId.Text;
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description))
                {
                    //TODO: check if title or descriptions differ

                    var result = clientAPI.UpdateNote(id, title, description);

                    if (result.description == "The server has not found anything matching the request URI")
                    {
                        MessageBox.Show(result.description);
                    }
                    else
                    {
                        txtNoteDetails.Text = "";
                        var sb = new StringBuilder();
                        sb.Append("Updated note:" + "\r\n");
                        sb.Append("Id: " + result.id + "\r\n");
                        sb.Append("Title: " + result.title + "\r\n");
                        sb.Append("Description: " + result.description + "\r\n");

                        var noteToTextBox = sb.ToString();
                        txtNoteDetails.Text = noteToTextBox;

                        txtUpdateTitle.Text = result.title;
                        txtUpdateDescription.Text = result.description;
                        numDelete.Text = result.id;
                        numNoteID.Text = result.id;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a new title and a description.");

                }
            }
            else
            {
                MessageBox.Show("Please enter a Note id.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var clientAPI = new NotesAPIClient();

            string noteId = numDelete.Text;

            if (!string.IsNullOrWhiteSpace(noteId))
            {
                string message = $"Really delete note with id {noteId}?";

                DialogResult result1 = MessageBox.Show(message, "Delete Note", MessageBoxButtons.OKCancel);

                var deleteSuccess = false;

                if (result1 == DialogResult.OK)
                {
                    deleteSuccess = clientAPI.XDeleteNote(noteId);

                }

                if (deleteSuccess)
                {
                    MessageBox.Show("Note with id " + noteId + " deleted.");
                    btnListAllNotes_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Note with id " + noteId + " not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Note Id");
            }
            
            numDelete.Text = "1";

        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
           
            txtNoteDetails.Text = "";

            string title = txtCreateTitle.Text;
            string description = txtCreateDescription.Text;
            
            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description))
            {
                var clientProgram = new NotesAPIClient();
                var result = clientProgram.CreateNote(title, description);

                var sb = new StringBuilder();

                sb.Append("Created note: \r\n");
                sb.Append("Id: " + result.id + "\r\n");
                sb.Append("Title: " + result.title + "\r\n");
                sb.Append("Description: " + result.description);

                var noteToTextBox = sb.ToString();
                txtNoteDetails.Text = noteToTextBox;

                txtCreateTitle.Text = "";
                txtCreateDescription.Text = "";
                numDelete.Text = result.id;
                numNoteID.Text = result.id;
                numUpdateId.Text = result.id;

            }
            else
            {
                MessageBox.Show("Please enter a title and a description.");
            }
        
            
        }

        
    }
}
