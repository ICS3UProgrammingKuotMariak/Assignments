namespace PizzaOrder_KuotM_
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.mnuPizzaOrder = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFrançais = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMainTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFUN = new System.Windows.Forms.ToolStripMenuItem();
            this.picMusic = new System.Windows.Forms.PictureBox();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.radXLarge = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.picOlives = new System.Windows.Forms.PictureBox();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picPepperoni = new System.Windows.Forms.PictureBox();
            this.grbSideDish = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radWings = new System.Windows.Forms.RadioButton();
            this.radFries = new System.Windows.Forms.RadioButton();
            this.picSalad = new System.Windows.Forms.PictureBox();
            this.picWings = new System.Windows.Forms.PictureBox();
            this.picFries = new System.Windows.Forms.PictureBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStateSubTotal = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblStateTotal = new System.Windows.Forms.Label();
            this.lblDeliveryOption = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.grbDelivery = new System.Windows.Forms.GroupBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radPickup = new System.Windows.Forms.RadioButton();
            this.mnuPizzaOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
            this.grbSize.SuspendLayout();
            this.grbToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOlives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).BeginInit();
            this.grbSideDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.grbDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPizzaOrder
            // 
            this.mnuPizzaOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniLanguage,
            this.mniMusic});
            this.mnuPizzaOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuPizzaOrder.Name = "mnuPizzaOrder";
            this.mnuPizzaOrder.Size = new System.Drawing.Size(1010, 24);
            this.mnuPizzaOrder.TabIndex = 0;
            this.mnuPizzaOrder.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniLanguage
            // 
            this.mniLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEnglish,
            this.mniFrançais,
            this.mniEspañol});
            this.mniLanguage.Name = "mniLanguage";
            this.mniLanguage.Size = new System.Drawing.Size(71, 20);
            this.mniLanguage.Text = "Language";
            // 
            // mniEnglish
            // 
            this.mniEnglish.Name = "mniEnglish";
            this.mniEnglish.Size = new System.Drawing.Size(117, 22);
            this.mniEnglish.Text = "English";
            this.mniEnglish.Click += new System.EventHandler(this.mniEnglish_Click);
            // 
            // mniFrançais
            // 
            this.mniFrançais.Name = "mniFrançais";
            this.mniFrançais.Size = new System.Drawing.Size(117, 22);
            this.mniFrançais.Text = "Français";
            this.mniFrançais.Click += new System.EventHandler(this.mniFrançais_Click);
            // 
            // mniEspañol
            // 
            this.mniEspañol.Name = "mniEspañol";
            this.mniEspañol.Size = new System.Drawing.Size(117, 22);
            this.mniEspañol.Text = "Español";
            this.mniEspañol.Click += new System.EventHandler(this.mniEspañol_Click);
            // 
            // mniMusic
            // 
            this.mniMusic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMainTheme,
            this.mniFUN});
            this.mniMusic.Name = "mniMusic";
            this.mniMusic.Size = new System.Drawing.Size(51, 20);
            this.mniMusic.Text = "Music";
            // 
            // mniMainTheme
            // 
            this.mniMainTheme.Name = "mniMainTheme";
            this.mniMainTheme.Size = new System.Drawing.Size(134, 22);
            this.mniMainTheme.Text = "Krusty Krab";
            this.mniMainTheme.Click += new System.EventHandler(this.mniMainTheme_Click);
            // 
            // mniFUN
            // 
            this.mniFUN.Name = "mniFUN";
            this.mniFUN.Size = new System.Drawing.Size(134, 22);
            this.mniFUN.Text = "F.U.N";
            this.mniFUN.Click += new System.EventHandler(this.mniFUN_Click);
            // 
            // picMusic
            // 
            this.picMusic.BackColor = System.Drawing.Color.White;
            this.picMusic.Image = global::PizzaOrder_KuotM_.Properties.Resources.SOUND_OFF;
            this.picMusic.Location = new System.Drawing.Point(890, 27);
            this.picMusic.Name = "picMusic";
            this.picMusic.Size = new System.Drawing.Size(120, 91);
            this.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMusic.TabIndex = 1;
            this.picMusic.TabStop = false;
            this.picMusic.Click += new System.EventHandler(this.picMusic_Click);
            // 
            // grbSize
            // 
            this.grbSize.BackColor = System.Drawing.Color.Transparent;
            this.grbSize.Controls.Add(this.radXLarge);
            this.grbSize.Controls.Add(this.radLarge);
            this.grbSize.Controls.Add(this.radMedium);
            this.grbSize.Controls.Add(this.radSmall);
            this.grbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.ForeColor = System.Drawing.SystemColors.Control;
            this.grbSize.Location = new System.Drawing.Point(29, 136);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(260, 282);
            this.grbSize.TabIndex = 3;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Pick your size:";
            // 
            // radXLarge
            // 
            this.radXLarge.AutoSize = true;
            this.radXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radXLarge.ForeColor = System.Drawing.Color.SteelBlue;
            this.radXLarge.Location = new System.Drawing.Point(10, 212);
            this.radXLarge.Name = "radXLarge";
            this.radXLarge.Size = new System.Drawing.Size(136, 28);
            this.radXLarge.TabIndex = 3;
            this.radXLarge.TabStop = true;
            this.radXLarge.Text = "Extra-Large";
            this.radXLarge.UseVisualStyleBackColor = true;
            this.radXLarge.CheckedChanged += new System.EventHandler(this.radXLarge_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.ForeColor = System.Drawing.Color.SteelBlue;
            this.radLarge.Location = new System.Drawing.Point(10, 153);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(81, 28);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.ForeColor = System.Drawing.Color.SteelBlue;
            this.radMedium.Location = new System.Drawing.Point(10, 94);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(103, 28);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.ForeColor = System.Drawing.Color.SteelBlue;
            this.radSmall.Location = new System.Drawing.Point(10, 41);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(79, 28);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.BackColor = System.Drawing.Color.Transparent;
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkBacon);
            this.grbToppings.Controls.Add(this.chkPepperoni);
            this.grbToppings.Controls.Add(this.picOlives);
            this.grbToppings.Controls.Add(this.picCheese);
            this.grbToppings.Controls.Add(this.picPepperoni);
            this.grbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.ForeColor = System.Drawing.SystemColors.Control;
            this.grbToppings.Location = new System.Drawing.Point(338, 136);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(295, 282);
            this.grbToppings.TabIndex = 4;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Pick your toppings:";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkOlives.Location = new System.Drawing.Point(16, 216);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(87, 28);
            this.chkOlives.TabIndex = 16;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkBacon.Location = new System.Drawing.Point(16, 134);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(88, 28);
            this.chkBacon.TabIndex = 15;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chkBacon_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkPepperoni.Location = new System.Drawing.Point(16, 62);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(126, 28);
            this.chkPepperoni.TabIndex = 6;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // picOlives
            // 
            this.picOlives.Image = global::PizzaOrder_KuotM_.Properties.Resources.Green_olives;
            this.picOlives.Location = new System.Drawing.Point(182, 176);
            this.picOlives.Name = "picOlives";
            this.picOlives.Size = new System.Drawing.Size(76, 64);
            this.picOlives.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOlives.TabIndex = 5;
            this.picOlives.TabStop = false;
            // 
            // picCheese
            // 
            this.picCheese.Image = ((System.Drawing.Image)(resources.GetObject("picCheese.Image")));
            this.picCheese.Location = new System.Drawing.Point(182, 94);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(76, 64);
            this.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheese.TabIndex = 4;
            this.picCheese.TabStop = false;
            // 
            // picPepperoni
            // 
            this.picPepperoni.Image = global::PizzaOrder_KuotM_.Properties.Resources.Pepperoni;
            this.picPepperoni.Location = new System.Drawing.Point(182, 25);
            this.picPepperoni.Name = "picPepperoni";
            this.picPepperoni.Size = new System.Drawing.Size(76, 61);
            this.picPepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPepperoni.TabIndex = 3;
            this.picPepperoni.TabStop = false;
            // 
            // grbSideDish
            // 
            this.grbSideDish.BackColor = System.Drawing.Color.Transparent;
            this.grbSideDish.Controls.Add(this.radSalad);
            this.grbSideDish.Controls.Add(this.radWings);
            this.grbSideDish.Controls.Add(this.radFries);
            this.grbSideDish.Controls.Add(this.picSalad);
            this.grbSideDish.Controls.Add(this.picWings);
            this.grbSideDish.Controls.Add(this.picFries);
            this.grbSideDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSideDish.ForeColor = System.Drawing.SystemColors.Control;
            this.grbSideDish.Location = new System.Drawing.Point(678, 136);
            this.grbSideDish.Name = "grbSideDish";
            this.grbSideDish.Size = new System.Drawing.Size(292, 282);
            this.grbSideDish.TabIndex = 5;
            this.grbSideDish.TabStop = false;
            this.grbSideDish.Text = "Pick your Side Dish:";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSalad.ForeColor = System.Drawing.Color.SteelBlue;
            this.radSalad.Location = new System.Drawing.Point(6, 248);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(80, 28);
            this.radSalad.TabIndex = 12;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad";
            this.radSalad.UseVisualStyleBackColor = true;
            // 
            // radWings
            // 
            this.radWings.AutoSize = true;
            this.radWings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWings.ForeColor = System.Drawing.Color.SteelBlue;
            this.radWings.Location = new System.Drawing.Point(6, 149);
            this.radWings.Name = "radWings";
            this.radWings.Size = new System.Drawing.Size(86, 28);
            this.radWings.TabIndex = 11;
            this.radWings.TabStop = true;
            this.radWings.Text = "Wings";
            this.radWings.UseVisualStyleBackColor = true;
            this.radWings.CheckedChanged += new System.EventHandler(this.radWings_CheckedChanged);
            // 
            // radFries
            // 
            this.radFries.AutoSize = true;
            this.radFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFries.ForeColor = System.Drawing.Color.SteelBlue;
            this.radFries.Location = new System.Drawing.Point(6, 62);
            this.radFries.Name = "radFries";
            this.radFries.Size = new System.Drawing.Size(148, 28);
            this.radFries.TabIndex = 10;
            this.radFries.TabStop = true;
            this.radFries.Text = "French Fries";
            this.radFries.UseVisualStyleBackColor = true;
            this.radFries.CheckedChanged += new System.EventHandler(this.radFries_CheckedChanged);
            // 
            // picSalad
            // 
            this.picSalad.Image = global::PizzaOrder_KuotM_.Properties.Resources.salad;
            this.picSalad.Location = new System.Drawing.Point(183, 199);
            this.picSalad.Name = "picSalad";
            this.picSalad.Size = new System.Drawing.Size(84, 77);
            this.picSalad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalad.TabIndex = 6;
            this.picSalad.TabStop = false;
            // 
            // picWings
            // 
            this.picWings.Image = global::PizzaOrder_KuotM_.Properties.Resources.chicken;
            this.picWings.Location = new System.Drawing.Point(183, 111);
            this.picWings.Name = "picWings";
            this.picWings.Size = new System.Drawing.Size(84, 66);
            this.picWings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWings.TabIndex = 5;
            this.picWings.TabStop = false;
            // 
            // picFries
            // 
            this.picFries.Image = global::PizzaOrder_KuotM_.Properties.Resources.fries;
            this.picFries.Location = new System.Drawing.Point(183, 25);
            this.picFries.Name = "picFries";
            this.picFries.Size = new System.Drawing.Size(84, 61);
            this.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFries.TabIndex = 4;
            this.picFries.TabStop = false;
            // 
            // picPizza
            // 
            this.picPizza.BackColor = System.Drawing.Color.Transparent;
            this.picPizza.Image = global::PizzaOrder_KuotM_.Properties.Resources.cheese_pizza;
            this.picPizza.Location = new System.Drawing.Point(181, 517);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(234, 209);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 6;
            this.picPizza.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSubTotal.Location = new System.Drawing.Point(694, 539);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(223, 31);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "label1";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTax.Location = new System.Drawing.Point(694, 593);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(223, 31);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "label2";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(694, 699);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 31);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label3";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateSubTotal
            // 
            this.lblStateSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblStateSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblStateSubTotal.Location = new System.Drawing.Point(410, 539);
            this.lblStateSubTotal.Name = "lblStateSubTotal";
            this.lblStateSubTotal.Size = new System.Drawing.Size(223, 31);
            this.lblStateSubTotal.TabIndex = 10;
            this.lblStateSubTotal.Text = "Subtotal:";
            this.lblStateSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateTax
            // 
            this.lblStateTax.BackColor = System.Drawing.Color.Transparent;
            this.lblStateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTax.ForeColor = System.Drawing.Color.White;
            this.lblStateTax.Location = new System.Drawing.Point(410, 593);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(223, 31);
            this.lblStateTax.TabIndex = 11;
            this.lblStateTax.Text = "HST(13%):";
            this.lblStateTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateTotal
            // 
            this.lblStateTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblStateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTotal.ForeColor = System.Drawing.Color.White;
            this.lblStateTotal.Location = new System.Drawing.Point(410, 699);
            this.lblStateTotal.Name = "lblStateTotal";
            this.lblStateTotal.Size = new System.Drawing.Size(223, 31);
            this.lblStateTotal.TabIndex = 12;
            this.lblStateTotal.Text = "Total:";
            this.lblStateTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeliveryOption
            // 
            this.lblDeliveryOption.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryOption.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDeliveryOption.Location = new System.Drawing.Point(694, 645);
            this.lblDeliveryOption.Name = "lblDeliveryOption";
            this.lblDeliveryOption.Size = new System.Drawing.Size(223, 31);
            this.lblDeliveryOption.TabIndex = 9;
            this.lblDeliveryOption.Text = "label3";
            this.lblDeliveryOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelivery
            // 
            this.lblDelivery.BackColor = System.Drawing.Color.Transparent;
            this.lblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.ForeColor = System.Drawing.Color.White;
            this.lblDelivery.Location = new System.Drawing.Point(410, 645);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(223, 31);
            this.lblDelivery.TabIndex = 13;
            this.lblDelivery.Text = "Pickup or Delivery";
            this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDelivery
            // 
            this.grbDelivery.BackColor = System.Drawing.Color.Transparent;
            this.grbDelivery.Controls.Add(this.radDelivery);
            this.grbDelivery.Controls.Add(this.radPickup);
            this.grbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDelivery.ForeColor = System.Drawing.Color.White;
            this.grbDelivery.Location = new System.Drawing.Point(12, 517);
            this.grbDelivery.Name = "grbDelivery";
            this.grbDelivery.Size = new System.Drawing.Size(163, 209);
            this.grbDelivery.TabIndex = 14;
            this.grbDelivery.TabStop = false;
            this.grbDelivery.Text = "Pick up or Delivery?";
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.ForeColor = System.Drawing.Color.SteelBlue;
            this.radDelivery.Location = new System.Drawing.Point(7, 114);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(95, 28);
            this.radDelivery.TabIndex = 1;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.radDelivery_CheckedChanged);
            // 
            // radPickup
            // 
            this.radPickup.AutoSize = true;
            this.radPickup.ForeColor = System.Drawing.Color.SteelBlue;
            this.radPickup.Location = new System.Drawing.Point(7, 67);
            this.radPickup.Name = "radPickup";
            this.radPickup.Size = new System.Drawing.Size(90, 28);
            this.radPickup.TabIndex = 0;
            this.radPickup.TabStop = true;
            this.radPickup.Text = "Pick up";
            this.radPickup.UseVisualStyleBackColor = true;
            this.radPickup.CheckedChanged += new System.EventHandler(this.radPickup_CheckedChanged);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaOrder_KuotM_.Properties.Resources.KrustyKrab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 738);
            this.Controls.Add(this.grbDelivery);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblStateTotal);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.lblStateSubTotal);
            this.Controls.Add(this.lblDeliveryOption);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.grbSideDish);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.picMusic);
            this.Controls.Add(this.mnuPizzaOrder);
            this.Controls.Add(this.picPizza);
            this.MainMenuStrip = this.mnuPizzaOrder;
            this.Name = "frmPizzaOrder";
            this.Text = "Krusty Krab Pizza";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.mnuPizzaOrder.ResumeLayout(false);
            this.mnuPizzaOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOlives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).EndInit();
            this.grbSideDish.ResumeLayout(false);
            this.grbSideDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.grbDelivery.ResumeLayout(false);
            this.grbDelivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPizzaOrder;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniLanguage;
        private System.Windows.Forms.ToolStripMenuItem mniEnglish;
        private System.Windows.Forms.ToolStripMenuItem mniFrançais;
        private System.Windows.Forms.ToolStripMenuItem mniEspañol;
        private System.Windows.Forms.ToolStripMenuItem mniMusic;
        private System.Windows.Forms.ToolStripMenuItem mniMainTheme;
        private System.Windows.Forms.ToolStripMenuItem mniFUN;
        private System.Windows.Forms.PictureBox picMusic;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.GroupBox grbSideDish;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStateSubTotal;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblStateTotal;
        private System.Windows.Forms.Label lblDeliveryOption;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.RadioButton radXLarge;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.PictureBox picOlives;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picPepperoni;
        private System.Windows.Forms.PictureBox picSalad;
        private System.Windows.Forms.PictureBox picWings;
        private System.Windows.Forms.PictureBox picFries;
        private System.Windows.Forms.GroupBox grbDelivery;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radPickup;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.RadioButton radFries;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radWings;
    }
}

