namespace tamagochi
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
            this.components = new System.ComponentModel.Container();
            this.starve = new System.Windows.Forms.ProgressBar();
            this.thirst = new System.Windows.Forms.ProgressBar();
            this.feed = new System.Windows.Forms.Button();
            this.drink = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.next_animal = new System.Windows.Forms.Button();
            this.tame = new System.Windows.Forms.Button();
            this.kind_animal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starve
            // 
            this.starve.Location = new System.Drawing.Point(112, 384);
            this.starve.Name = "starve";
            this.starve.Size = new System.Drawing.Size(466, 29);
            this.starve.TabIndex = 0;
            // 
            // thirst
            // 
            this.thirst.Location = new System.Drawing.Point(112, 330);
            this.thirst.Name = "thirst";
            this.thirst.Size = new System.Drawing.Size(466, 29);
            this.thirst.TabIndex = 1;
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(643, 44);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(94, 29);
            this.feed.TabIndex = 2;
            this.feed.Text = "feed";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Click += new System.EventHandler(this.feed_Click);
            // 
            // drink
            // 
            this.drink.Location = new System.Drawing.Point(643, 91);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(94, 29);
            this.drink.TabIndex = 3;
            this.drink.Text = "drink";
            this.drink.UseVisualStyleBackColor = true;
            this.drink.Click += new System.EventHandler(this.drink_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(643, 142);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(94, 29);
            this.play.TabIndex = 4;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // next_animal
            // 
            this.next_animal.Location = new System.Drawing.Point(353, 211);
            this.next_animal.Name = "next_animal";
            this.next_animal.Size = new System.Drawing.Size(147, 40);
            this.next_animal.TabIndex = 5;
            this.next_animal.Text = "next_enimal";
            this.next_animal.UseVisualStyleBackColor = true;
            this.next_animal.Click += new System.EventHandler(this.next_animal_Click);
            // 
            // tame
            // 
            this.tame.Location = new System.Drawing.Point(139, 211);
            this.tame.Name = "tame";
            this.tame.Size = new System.Drawing.Size(147, 40);
            this.tame.TabIndex = 6;
            this.tame.Text = "tame";
            this.tame.UseVisualStyleBackColor = true;
            this.tame.Click += new System.EventHandler(this.tame_Click);
            // 
            // kind_animal
            // 
            this.kind_animal.AutoSize = true;
            this.kind_animal.Location = new System.Drawing.Point(383, 96);
            this.kind_animal.Name = "kind_animal";
            this.kind_animal.Size = new System.Drawing.Size(50, 20);
            this.kind_animal.TabIndex = 7;
            this.kind_animal.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kind_animal);
            this.Controls.Add(this.tame);
            this.Controls.Add(this.next_animal);
            this.Controls.Add(this.play);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.thirst);
            this.Controls.Add(this.starve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar starve;
        private ProgressBar thirst;
        private Button feed;
        private Button drink;
        private Button play;
        private System.Windows.Forms.Timer timer1;
        private Button next_animal;
        private Button tame;
        private Label kind_animal;
    }
}