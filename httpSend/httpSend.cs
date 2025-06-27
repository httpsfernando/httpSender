using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpSend
{
    public partial class httpSend : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private string respostaHttp;
        public httpSend()
        {
            InitializeComponent();
        }

        private async Task reqHttp(string url)
        {
            try
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    respostaHttp = content;
                }
                else
                {
                    MessageBox.Show("Erro ao fazer a requisição: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            string url = endpoint1.Text;
            this.endpoint1.ReadOnly = true;
        }

        private async void enviar1_Click(object sender, EventArgs e)
        {
            string url = endpoint1.Text;
            await reqHttp(url);
            respostaHttpBox.Text = respostaHttp;
        }
    }
}       

