namespace HomeWorkLesson6
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAddArrray = new System.Windows.Forms.Button();
			this.textBoxViewResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDimensionArray = new System.Windows.Forms.TextBox();
			this.buttonSortArray = new System.Windows.Forms.Button();
			this.buttonSearchDesiredEkement = new System.Windows.Forms.Button();
			this.textBoxAddSearchElement = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonBinSearch = new System.Windows.Forms.Button();
			this.buttonBinSearchRucursion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddArrray
			// 
			this.buttonAddArrray.ForeColor = System.Drawing.Color.Black;
			this.buttonAddArrray.Location = new System.Drawing.Point(505, 51);
			this.buttonAddArrray.Name = "buttonAddArrray";
			this.buttonAddArrray.Size = new System.Drawing.Size(169, 59);
			this.buttonAddArrray.TabIndex = 0;
			this.buttonAddArrray.Text = "Заполнение массива";
			this.buttonAddArrray.UseVisualStyleBackColor = true;
			this.buttonAddArrray.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxViewResult
			// 
			this.textBoxViewResult.Location = new System.Drawing.Point(13, 25);
			this.textBoxViewResult.Name = "textBoxViewResult";
			this.textBoxViewResult.Size = new System.Drawing.Size(776, 20);
			this.textBoxViewResult.TabIndex = 1;
			this.textBoxViewResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Размерность массива";
			// 
			// textBoxDimensionArray
			// 
			this.textBoxDimensionArray.Location = new System.Drawing.Point(155, 71);
			this.textBoxDimensionArray.Name = "textBoxDimensionArray";
			this.textBoxDimensionArray.Size = new System.Drawing.Size(138, 20);
			this.textBoxDimensionArray.TabIndex = 3;
			this.textBoxDimensionArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonSortArray
			// 
			this.buttonSortArray.ForeColor = System.Drawing.Color.Black;
			this.buttonSortArray.Location = new System.Drawing.Point(505, 116);
			this.buttonSortArray.Name = "buttonSortArray";
			this.buttonSortArray.Size = new System.Drawing.Size(169, 59);
			this.buttonSortArray.TabIndex = 4;
			this.buttonSortArray.Text = "Сортировка массива";
			this.buttonSortArray.UseVisualStyleBackColor = true;
			this.buttonSortArray.Click += new System.EventHandler(this.buttonSortArray_Click);
			// 
			// buttonSearchDesiredEkement
			// 
			this.buttonSearchDesiredEkement.ForeColor = System.Drawing.Color.Black;
			this.buttonSearchDesiredEkement.Location = new System.Drawing.Point(155, 249);
			this.buttonSearchDesiredEkement.Name = "buttonSearchDesiredEkement";
			this.buttonSearchDesiredEkement.Size = new System.Drawing.Size(169, 59);
			this.buttonSearchDesiredEkement.TabIndex = 5;
			this.buttonSearchDesiredEkement.Text = "Поиск перебором";
			this.buttonSearchDesiredEkement.UseVisualStyleBackColor = true;
			this.buttonSearchDesiredEkement.Click += new System.EventHandler(this.buttonSearchDesiredEkement_Click);
			// 
			// textBoxAddSearchElement
			// 
			this.textBoxAddSearchElement.Location = new System.Drawing.Point(155, 205);
			this.textBoxAddSearchElement.Name = "textBoxAddSearchElement";
			this.textBoxAddSearchElement.Size = new System.Drawing.Size(138, 20);
			this.textBoxAddSearchElement.TabIndex = 7;
			this.textBoxAddSearchElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Искомый элемент";
			// 
			// buttonBinSearch
			// 
			this.buttonBinSearch.ForeColor = System.Drawing.Color.Black;
			this.buttonBinSearch.Location = new System.Drawing.Point(330, 249);
			this.buttonBinSearch.Name = "buttonBinSearch";
			this.buttonBinSearch.Size = new System.Drawing.Size(169, 59);
			this.buttonBinSearch.TabIndex = 8;
			this.buttonBinSearch.Text = "Бинарный поиск While";
			this.buttonBinSearch.UseVisualStyleBackColor = true;
			this.buttonBinSearch.Click += new System.EventHandler(this.buttonBinSearch_Click);
			// 
			// buttonBinSearchRucursion
			// 
			this.buttonBinSearchRucursion.ForeColor = System.Drawing.Color.Black;
			this.buttonBinSearchRucursion.Location = new System.Drawing.Point(505, 249);
			this.buttonBinSearchRucursion.Name = "buttonBinSearchRucursion";
			this.buttonBinSearchRucursion.Size = new System.Drawing.Size(169, 59);
			this.buttonBinSearchRucursion.TabIndex = 9;
			this.buttonBinSearchRucursion.Text = "Бинарный поиск Rucursion";
			this.buttonBinSearchRucursion.UseVisualStyleBackColor = true;
			this.buttonBinSearchRucursion.Click += new System.EventHandler(this.buttonBinSearchRucursion_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonBinSearchRucursion);
			this.Controls.Add(this.buttonBinSearch);
			this.Controls.Add(this.textBoxAddSearchElement);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSearchDesiredEkement);
			this.Controls.Add(this.buttonSortArray);
			this.Controls.Add(this.textBoxDimensionArray);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxViewResult);
			this.Controls.Add(this.buttonAddArrray);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAddArrray;
		private System.Windows.Forms.TextBox textBoxViewResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDimensionArray;
		private System.Windows.Forms.Button buttonSortArray;
		private System.Windows.Forms.Button buttonSearchDesiredEkement;
		private System.Windows.Forms.TextBox textBoxAddSearchElement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonBinSearch;
		private System.Windows.Forms.Button buttonBinSearchRucursion;
	}
}

