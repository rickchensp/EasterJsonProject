
namespace PokedexForm.App
{
    partial class Form1
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
            this.pokemonIMG = new System.Windows.Forms.PictureBox();
            this.NextPokemon = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.NumLabel = new System.Windows.Forms.Label();
            this.SpawnChanceLabel = new System.Windows.Forms.Label();
            this.SpawnTimeLabel = new System.Windows.Forms.Label();
            this.PrevEvoLabel = new System.Windows.Forms.Label();
            this.NextEvoLabel = new System.Windows.Forms.Label();
            this.PrevPokemon = new System.Windows.Forms.Button();
            this.SortByCombo = new System.Windows.Forms.ComboBox();
            this.PokemonMenu = new System.Windows.Forms.ComboBox();
            this.OrderByCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonIMG
            // 
            this.pokemonIMG.ImageLocation = "http://www.serebii.net/pokemongo/pokemon/001.png";
            this.pokemonIMG.Location = new System.Drawing.Point(208, 46);
            this.pokemonIMG.Name = "pokemonIMG";
            this.pokemonIMG.Size = new System.Drawing.Size(265, 253);
            this.pokemonIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemonIMG.TabIndex = 0;
            this.pokemonIMG.TabStop = false;
            // 
            // NextPokemon
            // 
            this.NextPokemon.Location = new System.Drawing.Point(845, 75);
            this.NextPokemon.Name = "NextPokemon";
            this.NextPokemon.Size = new System.Drawing.Size(108, 83);
            this.NextPokemon.TabIndex = 1;
            this.NextPokemon.Text = "Next Pokemon";
            this.NextPokemon.UseVisualStyleBackColor = true;
            this.NextPokemon.Click += new System.EventHandler(this.NextPokemon_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(501, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 20);
            this.NameLabel.TabIndex = 2;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(501, 106);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(0, 20);
            this.TypeLabel.TabIndex = 3;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(501, 149);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(0, 20);
            this.HeightLabel.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(501, 194);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(0, 20);
            this.WeightLabel.TabIndex = 5;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(513, 23);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(0, 20);
            this.NumLabel.TabIndex = 6;
            // 
            // SpawnChanceLabel
            // 
            this.SpawnChanceLabel.AutoSize = true;
            this.SpawnChanceLabel.Location = new System.Drawing.Point(501, 230);
            this.SpawnChanceLabel.Name = "SpawnChanceLabel";
            this.SpawnChanceLabel.Size = new System.Drawing.Size(0, 20);
            this.SpawnChanceLabel.TabIndex = 7;
            // 
            // SpawnTimeLabel
            // 
            this.SpawnTimeLabel.AutoSize = true;
            this.SpawnTimeLabel.Location = new System.Drawing.Point(501, 266);
            this.SpawnTimeLabel.Name = "SpawnTimeLabel";
            this.SpawnTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.SpawnTimeLabel.TabIndex = 8;
            // 
            // PrevEvoLabel
            // 
            this.PrevEvoLabel.AutoSize = true;
            this.PrevEvoLabel.Location = new System.Drawing.Point(501, 334);
            this.PrevEvoLabel.Name = "PrevEvoLabel";
            this.PrevEvoLabel.Size = new System.Drawing.Size(0, 20);
            this.PrevEvoLabel.TabIndex = 9;
            // 
            // NextEvoLabel
            // 
            this.NextEvoLabel.AutoSize = true;
            this.NextEvoLabel.Location = new System.Drawing.Point(501, 303);
            this.NextEvoLabel.Name = "NextEvoLabel";
            this.NextEvoLabel.Size = new System.Drawing.Size(0, 20);
            this.NextEvoLabel.TabIndex = 10;
            // 
            // PrevPokemon
            // 
            this.PrevPokemon.Location = new System.Drawing.Point(845, 183);
            this.PrevPokemon.Name = "PrevPokemon";
            this.PrevPokemon.Size = new System.Drawing.Size(108, 83);
            this.PrevPokemon.TabIndex = 11;
            this.PrevPokemon.Text = "Previous Pokemon";
            this.PrevPokemon.UseVisualStyleBackColor = true;
            this.PrevPokemon.Click += new System.EventHandler(this.PrevPokemon_Click);
            // 
            // SortByCombo
            // 
            this.SortByCombo.FormattingEnabled = true;
            this.SortByCombo.Items.AddRange(new object[] {
            "ID",
            "Spawn Time",
            "Rarity"});
            this.SortByCombo.Location = new System.Drawing.Point(60, 47);
            this.SortByCombo.Name = "SortByCombo";
            this.SortByCombo.Size = new System.Drawing.Size(117, 28);
            this.SortByCombo.TabIndex = 12;
            this.SortByCombo.Text = "Sort By:";
            this.SortByCombo.SelectedIndexChanged += new System.EventHandler(this.SortByCombo_SelectedIndexChanged);
            // 
            // PokemonMenu
            // 
            this.PokemonMenu.FormattingEnabled = true;
            this.PokemonMenu.Location = new System.Drawing.Point(975, 75);
            this.PokemonMenu.Name = "PokemonMenu";
            this.PokemonMenu.Size = new System.Drawing.Size(239, 28);
            this.PokemonMenu.TabIndex = 13;
            this.PokemonMenu.Text = "Selection Menu";
            this.PokemonMenu.SelectedIndexChanged += new System.EventHandler(this.PokemonMenu_SelectedIndexChanged);
            // 
            // OrderByCombo
            // 
            this.OrderByCombo.FormattingEnabled = true;
            this.OrderByCombo.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.OrderByCombo.Location = new System.Drawing.Point(60, 98);
            this.OrderByCombo.Name = "OrderByCombo";
            this.OrderByCombo.Size = new System.Drawing.Size(117, 28);
            this.OrderByCombo.TabIndex = 14;
            this.OrderByCombo.Text = "Order By:";
            this.OrderByCombo.SelectedIndexChanged += new System.EventHandler(this.OrderByCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.OrderByCombo);
            this.Controls.Add(this.PokemonMenu);
            this.Controls.Add(this.SortByCombo);
            this.Controls.Add(this.PrevPokemon);
            this.Controls.Add(this.NextEvoLabel);
            this.Controls.Add(this.PrevEvoLabel);
            this.Controls.Add(this.SpawnTimeLabel);
            this.Controls.Add(this.SpawnChanceLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NextPokemon);
            this.Controls.Add(this.pokemonIMG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemonIMG;
        private System.Windows.Forms.Button NextPokemon;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label SpawnChanceLabel;
        private System.Windows.Forms.Label SpawnTimeLabel;
        private System.Windows.Forms.Label PrevEvoLabel;
        private System.Windows.Forms.Label NextEvoLabel;
        private System.Windows.Forms.Button PrevPokemon;
        private System.Windows.Forms.ComboBox SortByCombo;
        private System.Windows.Forms.ComboBox PokemonMenu;
        private System.Windows.Forms.ComboBox OrderByCombo;
    }
}

