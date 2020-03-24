using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

// Fernando Francisco de Arruda
// RGM 11181501989

namespace DataGridView
{
    public partial class Form1 : Form
    {
        // coleção de objetos da classe Pessoa
        List<Pessoa> lista = new List<Pessoa>();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void preencherDataGridView()
        {

            // limpa DataGridView
            dgvClientes.Rows.Clear();
           
            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == 'F' ? "Feminino" : "Masculino",
                    lista[i].CPF,
                    lista[i].RG,
                    lista[i].NecessidadeEspeciais == false ? "Nao" : "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }
            if (lista.Count > 0)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        public void limpaCampos()
        {
            // limpa os campos após inserção
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            
            cmbSexo.SelectedIndex = 0;
            if (rbSim.Checked.Equals(true))
            {
                rbSim.Checked = false;
               
            }
            else
            {
                rbNao.Checked = false;
               
            }
            mtxCPF.Clear();
            mtxRG.Clear();
        }

        public void verificar()
        {
            if (picNome.Visible && picSexo.Visible && picCPF.Visible && picRG.Visible && picNecEsp.Visible == true) 
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

            private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;

            if (cmbSexo.SelectedIndex == 0)
            {
                pessoa.Sexo = 'M';
            }
            else
            {
                pessoa.Sexo = 'F';
            }

            pessoa.DataNascimento = dtpDataNascimento.Text;

            if (rbSim.Checked)
                {
                    pessoa.NecessidadeEspeciais = true;
                }
                else
                {
                    pessoa.NecessidadeEspeciais = false;
                }

                pessoa.RG = mtxRG.Text;
                pessoa.CPF = mtxCPF.Text;

                // adiciona na lista de objetos
                lista.Add(pessoa);

                //chama o método
                preencherDataGridView();
                limpaCampos();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Deseja realmente excluir o cliente", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                // recupera o indice da linha selecionada
                int indicelinha = dgvClientes.CurrentRow.Index;

                // remove da lista
                lista.RemoveAt(indicelinha);

                // chama o metodo limpar campos
                limpaCampos();

                // atulaiza grid
                preencherDataGridView();

            }
          
                      
           

            
        }

        public void txtNome_TextChanged(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(txtNome.Text, @"^[\p{L}\p{M}' \.\-]+$")) && (Regex.IsMatch(txtNome.Text, @"[\s][aA-zZ]")))
            {
               // if (Regex.IsMatch(txtNome.Text, @"[\s][aA-zZ]"))
               // {
                    picNome.Visible = true;
                                  
                   
                //}
            }
            else
            {
                picNome.Visible = false;
            }
            verificar();
        }

        public void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(mtxCPF.Text, @"^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$"))
            {
                picCPF.Visible = true;
            }
            else
            {
                picCPF.Visible = false;
            }
            verificar();
        }

        public void mtxRG_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(mtxRG.Text, @"^(\d{2}.\d{3}.\d{3}.\d{1})|(\d{9})$"))
            {
                picRG.Visible = true;
            }
            else
            {
                picRG.Visible = false;
            }
            verificar();
        }

        public void dtpDataNascimento_FormatChanged(object sender, EventArgs e)
        {/*
            DateTime datavalida;
            if (DateTime.TryParse(dtpDataNascimento.Text, out datavalida))
            {
                if (Regex.IsMatch(dtpDataNascimento.Text, @"^(\d{2}/\d{2}/\d{4})$")) //@"^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$"))
                {
                    picDtNasc.Visible = true;
                }
            }
            else
            {
                picDtNasc.Visible = false;

            }
            verificar();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            picNome.Visible = false;
            picCPF.Visible = false;
            picRG.Visible = false;
            picSexo.Visible = false;
            picNecEsp.Visible = false;
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSim.Checked.Equals(true))
            {
                picNecEsp.Visible = true;
            }
            else
            {
                picNecEsp.Visible = false;
            }
            verificar();
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbSexo.SelectedIndex.Equals(1)) || (cmbSexo.SelectedIndex.Equals(2)))
            {
                picSexo.Visible = true;
            }
            else if (cmbSexo.SelectedIndex.Equals(0))
            {
                picSexo.Visible = false;
            }
            verificar();
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNao.Checked.Equals(true)) 
            {
                picNecEsp.Visible = true;
            }
            else
            {
                picNecEsp.Visible = false;
            }
            verificar();
        }

        private void btnFecharForm1_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
            this.Visible = false;
        }
    }
}
