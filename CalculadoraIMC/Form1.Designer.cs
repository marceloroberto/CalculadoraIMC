namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            label3 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtPeso
            // 
            resources.ApplyResources(txtPeso, "txtPeso");
            txtPeso.Name = "txtPeso";
            // 
            // txtAltura
            // 
            resources.ApplyResources(txtAltura, "txtAltura");
            txtAltura.Name = "txtAltura";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnCalcular
            // 
            resources.ApplyResources(btnCalcular, "btnCalcular");
            btnCalcular.Name = "btnCalcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // lblResultado
            // 
            resources.ApplyResources(lblResultado, "lblResultado");
            lblResultado.Name = "lblResultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(txtPeso);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label label2;
        private Button btnCalcular;
        private Label label3;
        private Label lblResultado;
    }
}
