using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCPF_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBoxAno_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Dados obj = new Dados();//CRIR OBJETO DADOS
            obj.nome = textNome.Text;//RECEBER VALOR, O PROGRAMA SABE QUE É UM SET;
            obj.rg = textRG.Text;
            obj.cpf = maskedTextBoxCPF.Text;
            obj.rua = textRua.Text;
            //obj.num = int.Parse(textNumCasa.Text);//INTEIRO
            obj.bairro = textBairro.Text;
            obj.cidade = textCidade.Text;
            obj.uf = comboBoxUF.Text;
            //obj.cep = int.Parse(maskedTextBoxCEP.Text);//INTEIRO
            obj.curso = comboBoxCurso.Text;
            obj.cidade = comboBoxPeriodo.Text;
            //obj.ano = int.Parse(textBoxAno.Text);
            
            MessageBox.Show(obj.rg,obj.nome);
            //MOSTRAR VALOR, O PROGRAMA SABE QUE É GET
            MessageBox.Show(obj.rua);
            MessageBox.Show(obj.bairro);
            MessageBox.Show(obj.cidade);
            MessageBox.Show(obj.uf);
        }

        
    }
}
