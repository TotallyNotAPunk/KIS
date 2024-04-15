namespace MySQL_Interfece
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.labelAllProductCost = new System.Windows.Forms.Label();
            this.labelProductList = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonNextProduct = new System.Windows.Forms.Button();
            this.buttonPrevProduct = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.labelWebStoreProduct = new System.Windows.Forms.Label();
            this.labelCostProduct = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTitelProduct = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonCost = new System.Windows.Forms.RadioButton();
            this.radioButtonWebStore = new System.Windows.Forms.RadioButton();
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTitel = new System.Windows.Forms.RadioButton();
            this.radioButtonDeveloper = new System.Windows.Forms.RadioButton();
            this.radioButtonPublisher = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labelWebStoreGame = new System.Windows.Forms.Label();
            this.labelReleaseYearGame = new System.Windows.Forms.Label();
            this.labelPublisherGame = new System.Windows.Forms.Label();
            this.labelDeveloperGame = new System.Windows.Forms.Label();
            this.labelReviewsGame = new System.Windows.Forms.Label();
            this.labelCostGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGameList = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonNextGame = new System.Windows.Forms.Button();
            this.buttonPrevGame = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDescriptionGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitelGame = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(191, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 534);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonRemoveProduct);
            this.panel4.Controls.Add(this.labelAllProductCost);
            this.panel4.Controls.Add(this.labelProductList);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.buttonNextProduct);
            this.panel4.Controls.Add(this.buttonPrevProduct);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(3, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 312);
            this.panel4.TabIndex = 14;
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(95, 277);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(84, 28);
            this.buttonRemoveProduct.TabIndex = 26;
            this.buttonRemoveProduct.Text = "Убрать";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // labelAllProductCost
            // 
            this.labelAllProductCost.AutoSize = true;
            this.labelAllProductCost.Location = new System.Drawing.Point(137, 221);
            this.labelAllProductCost.Name = "labelAllProductCost";
            this.labelAllProductCost.Size = new System.Drawing.Size(19, 16);
            this.labelAllProductCost.TabIndex = 24;
            this.labelAllProductCost.Text = "---";
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Location = new System.Drawing.Point(126, 257);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(25, 16);
            this.labelProductList.TabIndex = 18;
            this.labelProductList.Text = "0/0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Общая стоимость:";
            // 
            // buttonNextProduct
            // 
            this.buttonNextProduct.Location = new System.Drawing.Point(223, 251);
            this.buttonNextProduct.Name = "buttonNextProduct";
            this.buttonNextProduct.Size = new System.Drawing.Size(56, 23);
            this.buttonNextProduct.TabIndex = 17;
            this.buttonNextProduct.Text = "След";
            this.buttonNextProduct.UseVisualStyleBackColor = true;
            this.buttonNextProduct.Click += new System.EventHandler(this.buttonNextProduct_Click);
            // 
            // buttonPrevProduct
            // 
            this.buttonPrevProduct.Location = new System.Drawing.Point(3, 251);
            this.buttonPrevProduct.Name = "buttonPrevProduct";
            this.buttonPrevProduct.Size = new System.Drawing.Size(62, 23);
            this.buttonPrevProduct.TabIndex = 16;
            this.buttonPrevProduct.Text = "Прев";
            this.buttonPrevProduct.UseVisualStyleBackColor = true;
            this.buttonPrevProduct.Click += new System.EventHandler(this.buttonPrevProduct_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.labelWebStoreProduct);
            this.panel5.Controls.Add(this.labelCostProduct);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.labelTitelProduct);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(3, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 190);
            this.panel5.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 16);
            this.label23.TabIndex = 23;
            this.label23.Text = "Название:";
            // 
            // labelWebStoreProduct
            // 
            this.labelWebStoreProduct.AutoSize = true;
            this.labelWebStoreProduct.Location = new System.Drawing.Point(79, 26);
            this.labelWebStoreProduct.Name = "labelWebStoreProduct";
            this.labelWebStoreProduct.Size = new System.Drawing.Size(19, 16);
            this.labelWebStoreProduct.TabIndex = 22;
            this.labelWebStoreProduct.Text = "---";
            // 
            // labelCostProduct
            // 
            this.labelCostProduct.AutoSize = true;
            this.labelCostProduct.Location = new System.Drawing.Point(55, 161);
            this.labelCostProduct.Name = "labelCostProduct";
            this.labelCostProduct.Size = new System.Drawing.Size(19, 16);
            this.labelCostProduct.TabIndex = 21;
            this.labelCostProduct.Text = "---";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(103, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Товар";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Цена:";
            // 
            // labelTitelProduct
            // 
            this.labelTitelProduct.Location = new System.Drawing.Point(8, 79);
            this.labelTitelProduct.Name = "labelTitelProduct";
            this.labelTitelProduct.Size = new System.Drawing.Size(263, 80);
            this.labelTitelProduct.TabIndex = 15;
            this.labelTitelProduct.Text = "Текст";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Магазин: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Корзина покупок";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButtonCost);
            this.panel2.Controls.Add(this.radioButtonWebStore);
            this.panel2.Controls.Add(this.FindButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButtonTitel);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.radioButtonDeveloper);
            this.panel2.Controls.Add(this.radioButtonPublisher);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 208);
            this.panel2.TabIndex = 8;
            // 
            // radioButtonCost
            // 
            this.radioButtonCost.AutoSize = true;
            this.radioButtonCost.Location = new System.Drawing.Point(6, 173);
            this.radioButtonCost.Name = "radioButtonCost";
            this.radioButtonCost.Size = new System.Drawing.Size(100, 20);
            this.radioButtonCost.TabIndex = 11;
            this.radioButtonCost.TabStop = true;
            this.radioButtonCost.Text = "Цена ниже ";
            this.radioButtonCost.UseVisualStyleBackColor = true;
            // 
            // radioButtonWebStore
            // 
            this.radioButtonWebStore.AutoSize = true;
            this.radioButtonWebStore.Location = new System.Drawing.Point(6, 147);
            this.radioButtonWebStore.Name = "radioButtonWebStore";
            this.radioButtonWebStore.Size = new System.Drawing.Size(85, 20);
            this.radioButtonWebStore.TabIndex = 10;
            this.radioButtonWebStore.TabStop = true;
            this.radioButtonWebStore.Text = "Магазин";
            this.radioButtonWebStore.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(203, 3);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по";
            // 
            // radioButtonTitel
            // 
            this.radioButtonTitel.AutoSize = true;
            this.radioButtonTitel.Location = new System.Drawing.Point(6, 66);
            this.radioButtonTitel.Name = "radioButtonTitel";
            this.radioButtonTitel.Size = new System.Drawing.Size(94, 20);
            this.radioButtonTitel.TabIndex = 3;
            this.radioButtonTitel.TabStop = true;
            this.radioButtonTitel.Text = "Название";
            this.radioButtonTitel.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeveloper
            // 
            this.radioButtonDeveloper.AutoSize = true;
            this.radioButtonDeveloper.Location = new System.Drawing.Point(6, 93);
            this.radioButtonDeveloper.Name = "radioButtonDeveloper";
            this.radioButtonDeveloper.Size = new System.Drawing.Size(115, 20);
            this.radioButtonDeveloper.TabIndex = 4;
            this.radioButtonDeveloper.TabStop = true;
            this.radioButtonDeveloper.Text = "Разработчик";
            this.radioButtonDeveloper.UseVisualStyleBackColor = true;
            // 
            // radioButtonPublisher
            // 
            this.radioButtonPublisher.AutoSize = true;
            this.radioButtonPublisher.Location = new System.Drawing.Point(6, 120);
            this.radioButtonPublisher.Name = "radioButtonPublisher";
            this.radioButtonPublisher.Size = new System.Drawing.Size(92, 20);
            this.radioButtonPublisher.TabIndex = 5;
            this.radioButtonPublisher.TabStop = true;
            this.radioButtonPublisher.Text = "Издатель";
            this.radioButtonPublisher.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonAddProduct);
            this.panel3.Controls.Add(this.labelWebStoreGame);
            this.panel3.Controls.Add(this.labelReleaseYearGame);
            this.panel3.Controls.Add(this.labelPublisherGame);
            this.panel3.Controls.Add(this.labelDeveloperGame);
            this.panel3.Controls.Add(this.labelReviewsGame);
            this.panel3.Controls.Add(this.labelCostGame);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelGameList);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.buttonNextGame);
            this.panel3.Controls.Add(this.buttonPrevGame);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelDescriptionGame);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelTitelGame);
            this.panel3.Controls.Add(this.label98);
            this.panel3.Location = new System.Drawing.Point(309, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 534);
            this.panel3.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(106, 500);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(99, 28);
            this.buttonAddProduct.TabIndex = 25;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // labelWebStoreGame
            // 
            this.labelWebStoreGame.AutoSize = true;
            this.labelWebStoreGame.Location = new System.Drawing.Point(83, 9);
            this.labelWebStoreGame.Name = "labelWebStoreGame";
            this.labelWebStoreGame.Size = new System.Drawing.Size(19, 16);
            this.labelWebStoreGame.TabIndex = 24;
            this.labelWebStoreGame.Text = "---";
            // 
            // labelReleaseYearGame
            // 
            this.labelReleaseYearGame.AutoSize = true;
            this.labelReleaseYearGame.Location = new System.Drawing.Point(113, 413);
            this.labelReleaseYearGame.Name = "labelReleaseYearGame";
            this.labelReleaseYearGame.Size = new System.Drawing.Size(19, 16);
            this.labelReleaseYearGame.TabIndex = 20;
            this.labelReleaseYearGame.Text = "---";
            // 
            // labelPublisherGame
            // 
            this.labelPublisherGame.AutoSize = true;
            this.labelPublisherGame.Location = new System.Drawing.Point(94, 387);
            this.labelPublisherGame.Name = "labelPublisherGame";
            this.labelPublisherGame.Size = new System.Drawing.Size(19, 16);
            this.labelPublisherGame.TabIndex = 19;
            this.labelPublisherGame.Text = "---";
            // 
            // labelDeveloperGame
            // 
            this.labelDeveloperGame.AutoSize = true;
            this.labelDeveloperGame.Location = new System.Drawing.Point(117, 357);
            this.labelDeveloperGame.Name = "labelDeveloperGame";
            this.labelDeveloperGame.Size = new System.Drawing.Size(19, 16);
            this.labelDeveloperGame.TabIndex = 18;
            this.labelDeveloperGame.Text = "---";
            // 
            // labelReviewsGame
            // 
            this.labelReviewsGame.AutoSize = true;
            this.labelReviewsGame.Location = new System.Drawing.Point(83, 329);
            this.labelReviewsGame.Name = "labelReviewsGame";
            this.labelReviewsGame.Size = new System.Drawing.Size(19, 16);
            this.labelReviewsGame.TabIndex = 17;
            this.labelReviewsGame.Text = "---";
            // 
            // labelCostGame
            // 
            this.labelCostGame.AutoSize = true;
            this.labelCostGame.Location = new System.Drawing.Point(66, 303);
            this.labelCostGame.Name = "labelCostGame";
            this.labelCostGame.Size = new System.Drawing.Size(19, 16);
            this.labelCostGame.TabIndex = 16;
            this.labelCostGame.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Магазин: ";
            // 
            // labelGameList
            // 
            this.labelGameList.AutoSize = true;
            this.labelGameList.Location = new System.Drawing.Point(141, 478);
            this.labelGameList.Name = "labelGameList";
            this.labelGameList.Size = new System.Drawing.Size(25, 16);
            this.labelGameList.TabIndex = 13;
            this.labelGameList.Text = "0/0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Год выпуска:";
            // 
            // buttonNextGame
            // 
            this.buttonNextGame.Location = new System.Drawing.Point(244, 472);
            this.buttonNextGame.Name = "buttonNextGame";
            this.buttonNextGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNextGame.TabIndex = 11;
            this.buttonNextGame.Text = "След";
            this.buttonNextGame.UseVisualStyleBackColor = true;
            this.buttonNextGame.Click += new System.EventHandler(this.buttonNextGame_Click);
            // 
            // buttonPrevGame
            // 
            this.buttonPrevGame.Location = new System.Drawing.Point(0, 472);
            this.buttonPrevGame.Name = "buttonPrevGame";
            this.buttonPrevGame.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevGame.TabIndex = 10;
            this.buttonPrevGame.Text = "Прев";
            this.buttonPrevGame.UseVisualStyleBackColor = true;
            this.buttonPrevGame.Click += new System.EventHandler(this.buttonPrevGame_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Издатель:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Разработчик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Отзывы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена:";
            // 
            // labelDescriptionGame
            // 
            this.labelDescriptionGame.Location = new System.Drawing.Point(13, 169);
            this.labelDescriptionGame.Name = "labelDescriptionGame";
            this.labelDescriptionGame.Size = new System.Drawing.Size(316, 124);
            this.labelDescriptionGame.TabIndex = 6;
            this.labelDescriptionGame.Text = "Текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Описание";
            // 
            // labelTitelGame
            // 
            this.labelTitelGame.Location = new System.Drawing.Point(13, 81);
            this.labelTitelGame.Name = "labelTitelGame";
            this.labelTitelGame.Size = new System.Drawing.Size(316, 48);
            this.labelTitelGame.TabIndex = 4;
            this.labelTitelGame.Text = "Текст";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(13, 51);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(73, 16);
            this.label98.TabIndex = 3;
            this.label98.Text = "Название";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(273, 552);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 586);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTitel;
        private System.Windows.Forms.RadioButton radioButtonDeveloper;
        private System.Windows.Forms.RadioButton radioButtonPublisher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitelGame;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDescriptionGame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonNextGame;
        private System.Windows.Forms.Button buttonPrevGame;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGameList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonNextProduct;
        private System.Windows.Forms.Button buttonPrevProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTitelProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelWebStoreProduct;
        private System.Windows.Forms.Label labelCostProduct;
        private System.Windows.Forms.Label labelReleaseYearGame;
        private System.Windows.Forms.Label labelPublisherGame;
        private System.Windows.Forms.Label labelDeveloperGame;
        private System.Windows.Forms.Label labelReviewsGame;
        private System.Windows.Forms.Label labelCostGame;
        private System.Windows.Forms.Label labelAllProductCost;
        private System.Windows.Forms.Label labelWebStoreGame;
        private System.Windows.Forms.RadioButton radioButtonWebStore;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.RadioButton radioButtonCost;
        private System.Windows.Forms.Button buttonExit;
    }
}

