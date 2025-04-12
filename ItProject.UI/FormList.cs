using OfficeOpenXml;
using ItProject.UI.Client;
using ItProject.UI.FormDialog;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ItProject.UI;

public partial class FormList : Form
{
    private object _data;
    private readonly SendToBack _apiClient;
    private readonly FormMain _formMain;

    public FormList(FormMain formMain, SendToBack apiClient, object data)
    {
        InitializeComponent();
        _apiClient = apiClient;
        _formMain = formMain;
        _data = data;
        if (_data is not null)
        {
            UploadDataAsync(_data);
        }
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
    }

    public async Task UploadDataAsync(object data)
    {
        guna2DataGridView1.DataSource = data;
    }

    private void guna2ControlBox2_Click(object sender, EventArgs e)
    {
        this.Close();
    }


    private async void guna2Button4_Click_1(object sender, EventArgs e)
    {
        
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        
    }

    private async void guna2Button2_Click(object sender, EventArgs e)
    {
        
    }

    private void _txtFirstName_TextChanged(object sender, EventArgs e)
    {
        
    }

    private async void FormList_FormClosed(object sender, FormClosedEventArgs e)
    {
    }
}
