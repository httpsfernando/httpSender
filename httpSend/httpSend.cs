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
            if (this.endpoint1.ReadOnly == false)
            {
                if (endpoint1.Text != "")
                {
                    string url = endpoint1.Text;
                    this.endpoint1.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("O campo está vazio!");
                }

            }
            else
            {
                this.endpoint1.ReadOnly = false;
                endpoint1.Text = "";
            }
        }

        private async void enviar1_Click(object sender, EventArgs e)
        {
            string url = endpoint1.Text;
            await reqHttp(url);
            respostaHttpBox.Text = respostaHttp;
        }

        private void salvar2_Click(object sender, EventArgs e)
        {
            if (this.endpoint2.ReadOnly == false)
            {
                if(endpoint2.Text != "")
                {
                    string url = endpoint2.Text;
                    this.endpoint2.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("O campo está vazio!");
                }
                
            }
            else
            {
                this.endpoint2.ReadOnly = false;
                endpoint2.Text = "";
            }
            
        }

        private async void enviar2_Click(object sender, EventArgs e)
        {
            string url = endpoint2.Text;
            await reqHttp(url);
            respostaHttpBox.Text = respostaHttp;
        }

        private void salvar3_Click(object sender, EventArgs e)
        {
            if (this.endpoint3.ReadOnly == false)
            {
                if (endpoint3.Text != "")
                {
                    string url = endpoint3.Text;
                    this.endpoint3.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("O campo está vazio!");
                }

            }
            else
            {
                this.endpoint3.ReadOnly = false;
                endpoint3.Text = "";
            }
        }

        private async void enviar3_Click(object sender, EventArgs e)
        {
            string url = endpoint3.Text;
            await reqHttp(url);
            respostaHttpBox.Text = respostaHttp;
        }

        private void salvar4_Click(object sender, EventArgs e)
        {
            if (this.endpoint4.ReadOnly == false)
            {
                if (endpoint4.Text != "")
                {
                    string url = endpoint4.Text;
                    this.endpoint4.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("O campo está vazio!");
                }

            }
            else
            {
                this.endpoint4.ReadOnly = false;
                endpoint4.Text = "";
            }
        }

        private async void enviar4_Click(object sender, EventArgs e)
        {
            string url = endpoint4.Text;
            await reqHttp(url);
            respostaHttpBox.Text = respostaHttp;
        }
    }
}       

