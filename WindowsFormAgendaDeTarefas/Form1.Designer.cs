
namespace WindowsFormAgendaDeTarefas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_nomeTarefa = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_horaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txt_horaFim = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lst_tarefa = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME DA TAREFA ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIÇÃO DA TAREFA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATA";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(43, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_nomeTarefa
            // 
            this.txt_nomeTarefa.Location = new System.Drawing.Point(43, 105);
            this.txt_nomeTarefa.Name = "txt_nomeTarefa";
            this.txt_nomeTarefa.Size = new System.Drawing.Size(126, 20);
            this.txt_nomeTarefa.TabIndex = 4;
            this.txt_nomeTarefa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(40, 144);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(129, 20);
            this.txt_descricao.TabIndex = 5;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(40, 183);
            this.txt_data.Mask = "00/00/0000";
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(129, 20);
            this.txt_data.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HORA INICIO";
            // 
            // txt_horaInicio
            // 
            this.txt_horaInicio.Location = new System.Drawing.Point(43, 222);
            this.txt_horaInicio.Mask = "00:00";
            this.txt_horaInicio.Name = "txt_horaInicio";
            this.txt_horaInicio.Size = new System.Drawing.Size(70, 20);
            this.txt_horaInicio.TabIndex = 9;
            // 
            // txt_horaFim
            // 
            this.txt_horaFim.Location = new System.Drawing.Point(43, 261);
            this.txt_horaFim.Mask = "00:00";
            this.txt_horaFim.Name = "txt_horaFim";
            this.txt_horaFim.Size = new System.Drawing.Size(70, 20);
            this.txt_horaFim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HORA FIM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "BUSCAR TAREFA";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(603, 102);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 14;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(230, 105);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(367, 20);
            this.txt_buscar.TabIndex = 15;
            // 
            // lst_tarefa
            // 
            this.lst_tarefa.HideSelection = false;
            this.lst_tarefa.Location = new System.Drawing.Point(230, 128);
            this.lst_tarefa.MultiSelect = false;
            this.lst_tarefa.Name = "lst_tarefa";
            this.lst_tarefa.Size = new System.Drawing.Size(448, 130);
            this.lst_tarefa.TabIndex = 16;
            this.lst_tarefa.UseCompatibleStateImageBehavior = false;
            this.lst_tarefa.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lst_tarefa_ItemSelectionChanged);
            this.lst_tarefa.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 325);
            this.Controls.Add(this.lst_tarefa);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_horaFim);
            this.Controls.Add(this.txt_horaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_nomeTarefa);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CADASTRO DE TAREFAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_nomeTarefa;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.MaskedTextBox txt_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_horaInicio;
        private System.Windows.Forms.MaskedTextBox txt_horaFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ListView lst_tarefa;
    }
}

