*
* Created by SharpDevelop.
* User: Rm20222930058
* Date: 29/03/2023
* Time: 10:30* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
usingSystem;
usingSystem.Collections.Generic;usingSystem.Drawing;
usingSystem.Windows.Forms;
namespaceContribuições
{
  publicpartialclassMainForm : Form
  {
    publicMainForm()
    {
      InitializeComponent();
    }
    voidMainFormLoad(objectsender, EventArgs e)
    {
      try
      {
        richTextBox1.LoadFile("contribuições.txt", RichTextBoxStreamType.PlainText);
      }catch{
      
      }
    }
    float[] b = newfloat[1];
    string[] a = newstring[3];
    float[]soma = newfloat[1];
    floatp = 0;float[]valorG = newfloat[1];
    float[]valorV = newfloat[1];
    float[]valorE = newfloat[1];
    float[]valorC = newfloat[1];
    float[]valorR = newfloat[1];
    voidButton1Click(objectsender, EventArgs e)
    {
      if(textBox1.Text != ""&& comboBox1.Text != ""&& textBox2.Text != "")
      {
        a[0] = textBox1.Text;
        a[1] = comboBox1.Text;
        b[0] = float.Parse(textBox2.Text);
        richTextBox1.Text += a[0] + "\t"+ a[1] + "\t"+ b[0].ToString() + "\n";
        richTextBox1.SaveFile("c4ontribuições.txt", RichTextBoxStreamType.PlainText);
        p++;
        soma[0] += b[0];
        if(a[1]=="Gerência")
        {
          valorG[0] += b[0];
        }
        if(a[1]=="Vendas")
        {
          valorV[0] += b[0];
        }
        if(a[1]=="Estoque")
        {
          valorE[0] += b[0];
        }
        if(a[1]=="Contabilidade")
        {
          valorC[0] += b[0];
        }
        if(a[1]=="RH")
        {
          valorR[0] += b[0];
        }
        MessageBox.Show("Registro gravado com sucesso!");
        textBox1.Clear();
        comboBox1.Text = "";
        textBox2.Clear();
        textBox1.Focus();
      }
      else
        MessageBox.Show("Preencha todos os campos!");
    }
    voidButton2Click(objectsender, EventArgs e)
    {
      string[] dados = richTextBox1.Text.Split('\t');
      if(comboBox2.SelectedIndex.Equals(0))
      {
        listBox1.Items.Add("Gerência: "+ valorG[0]);
      }
      if(comboBox2.SelectedIndex.Equals(1)) 
      {
        listBox1.Items.Add("Vendas: "+ valorV[0]);
      }
      if(comboBox2.SelectedIndex.Equals(2))
      {
        listBox1.Items.Add("Estoque: "+ valorE[0]);
      }
      if(comboBox2.SelectedIndex.Equals(3))
      {
        listBox1.Items.Add("Contabilidadde: "+ valorC[0]);
      }
      if(comboBox2.SelectedIndex.Equals(4))
      {
        listBox1.Items.Add("RH: "+ valorR[0]);
      }
    }
    voidButton3Click(objectsender, EventArgs e)
    {
      float soma = 0;
      for(int i = 0; i < richTextBox1.Lines.Length-1; i++)
      {
        string[] dados = richTextBox1.Lines[i].Split('\t');
        soma += float.Parse(dados[2]);
      }
      label4.Text = "Total: "+ soma.ToString("R$ #,###,##0,00");
      floatmedia = soma / (richTextBox1.Lines.Length-1);
      label5.Text = "Média: "+ media.ToString("R$,#,###,##0,00");
    }
  }
}
