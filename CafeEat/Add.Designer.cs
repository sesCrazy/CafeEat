
namespace CafeEat
{
    partial class Add
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label единицы_измеренияLabel;
            System.Windows.Forms.Label количество_товара_на_остаткахLabel;
            System.Windows.Forms.Label количество_тавара_в_чекеLabel;
            System.Windows.Forms.Label цена_за_единицуLabel;
            System.Windows.Forms.Label сумма_в_покупкеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.cafeDataSet = new CafeEat.CafeDataSet();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeTableAdapter = new CafeEat.CafeDataSetTableAdapters.CafeTableAdapter();
            this.tableAdapterManager = new CafeEat.CafeDataSetTableAdapters.TableAdapterManager();
            this.cafeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cafeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.единицы_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.количество_товара_на_остаткахTextBox = new System.Windows.Forms.TextBox();
            this.количество_тавара_в_чекеTextBox = new System.Windows.Forms.TextBox();
            this.цена_за_единицуTextBox = new System.Windows.Forms.TextBox();
            this.сумма_в_покупкеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            кодLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            единицы_измеренияLabel = new System.Windows.Forms.Label();
            количество_товара_на_остаткахLabel = new System.Windows.Forms.Label();
            количество_тавара_в_чекеLabel = new System.Windows.Forms.Label();
            цена_за_единицуLabel = new System.Windows.Forms.Label();
            сумма_в_покупкеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingNavigator)).BeginInit();
            this.cafeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(13, 74);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(37, 17);
            кодLabel.TabIndex = 1;
            кодLabel.Text = "Код:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(13, 102);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 17);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // единицы_измеренияLabel
            // 
            единицы_измеренияLabel.AutoSize = true;
            единицы_измеренияLabel.Location = new System.Drawing.Point(13, 130);
            единицы_измеренияLabel.Name = "единицы_измеренияLabel";
            единицы_измеренияLabel.Size = new System.Drawing.Size(147, 17);
            единицы_измеренияLabel.TabIndex = 5;
            единицы_измеренияLabel.Text = "Единицы измерения:";
            // 
            // количество_товара_на_остаткахLabel
            // 
            количество_товара_на_остаткахLabel.AutoSize = true;
            количество_товара_на_остаткахLabel.Location = new System.Drawing.Point(13, 158);
            количество_товара_на_остаткахLabel.Name = "количество_товара_на_остаткахLabel";
            количество_товара_на_остаткахLabel.Size = new System.Drawing.Size(222, 17);
            количество_товара_на_остаткахLabel.TabIndex = 7;
            количество_товара_на_остаткахLabel.Text = "Количество товара на остатках:";
            // 
            // количество_тавара_в_чекеLabel
            // 
            количество_тавара_в_чекеLabel.AutoSize = true;
            количество_тавара_в_чекеLabel.Location = new System.Drawing.Point(13, 186);
            количество_тавара_в_чекеLabel.Name = "количество_тавара_в_чекеLabel";
            количество_тавара_в_чекеLabel.Size = new System.Drawing.Size(186, 17);
            количество_тавара_в_чекеLabel.TabIndex = 9;
            количество_тавара_в_чекеLabel.Text = "Количество тавара в чеке:";
            // 
            // цена_за_единицуLabel
            // 
            цена_за_единицуLabel.AutoSize = true;
            цена_за_единицуLabel.Location = new System.Drawing.Point(13, 214);
            цена_за_единицуLabel.Name = "цена_за_единицуLabel";
            цена_за_единицуLabel.Size = new System.Drawing.Size(125, 17);
            цена_за_единицуLabel.TabIndex = 11;
            цена_за_единицуLabel.Text = "Цена за единицу:";
            // 
            // сумма_в_покупкеLabel
            // 
            сумма_в_покупкеLabel.AutoSize = true;
            сумма_в_покупкеLabel.Location = new System.Drawing.Point(13, 242);
            сумма_в_покупкеLabel.Name = "сумма_в_покупкеLabel";
            сумма_в_покупкеLabel.Size = new System.Drawing.Size(122, 17);
            сумма_в_покупкеLabel.TabIndex = 13;
            сумма_в_покупкеLabel.Text = "Сумма в покупке:";
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "CafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeBindingSource
            // 
            this.cafeBindingSource.DataMember = "Cafe";
            this.cafeBindingSource.DataSource = this.cafeDataSet;
            // 
            // cafeTableAdapter
            // 
            this.cafeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTableAdapter = this.cafeTableAdapter;
            this.tableAdapterManager.UpdateOrder = CafeEat.CafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cafeBindingNavigator
            // 
            this.cafeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cafeBindingNavigator.BindingSource = this.cafeBindingSource;
            this.cafeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cafeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cafeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cafeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cafeBindingNavigatorSaveItem});
            this.cafeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cafeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cafeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cafeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cafeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cafeBindingNavigator.Name = "cafeBindingNavigator";
            this.cafeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cafeBindingNavigator.Size = new System.Drawing.Size(382, 27);
            this.cafeBindingNavigator.TabIndex = 0;
            this.cafeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cafeBindingNavigatorSaveItem
            // 
            this.cafeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cafeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cafeBindingNavigatorSaveItem.Image")));
            this.cafeBindingNavigatorSaveItem.Name = "cafeBindingNavigatorSaveItem";
            this.cafeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cafeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cafeBindingNavigatorSaveItem.Click += new System.EventHandler(this.cafeBindingNavigatorSaveItem_Click);
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(239, 74);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(131, 22);
            this.кодTextBox.TabIndex = 2;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(239, 102);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(131, 22);
            this.названиеTextBox.TabIndex = 4;
            // 
            // единицы_измеренияTextBox
            // 
            this.единицы_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Единицы измерения", true));
            this.единицы_измеренияTextBox.Location = new System.Drawing.Point(239, 130);
            this.единицы_измеренияTextBox.Name = "единицы_измеренияTextBox";
            this.единицы_измеренияTextBox.Size = new System.Drawing.Size(131, 22);
            this.единицы_измеренияTextBox.TabIndex = 6;
            // 
            // количество_товара_на_остаткахTextBox
            // 
            this.количество_товара_на_остаткахTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Количество товара на остатках", true));
            this.количество_товара_на_остаткахTextBox.Location = new System.Drawing.Point(239, 158);
            this.количество_товара_на_остаткахTextBox.Name = "количество_товара_на_остаткахTextBox";
            this.количество_товара_на_остаткахTextBox.Size = new System.Drawing.Size(131, 22);
            this.количество_товара_на_остаткахTextBox.TabIndex = 8;
            // 
            // количество_тавара_в_чекеTextBox
            // 
            this.количество_тавара_в_чекеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Количество тавара в чеке", true));
            this.количество_тавара_в_чекеTextBox.Location = new System.Drawing.Point(239, 186);
            this.количество_тавара_в_чекеTextBox.Name = "количество_тавара_в_чекеTextBox";
            this.количество_тавара_в_чекеTextBox.Size = new System.Drawing.Size(131, 22);
            this.количество_тавара_в_чекеTextBox.TabIndex = 10;
            // 
            // цена_за_единицуTextBox
            // 
            this.цена_за_единицуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Цена за единицу", true));
            this.цена_за_единицуTextBox.Location = new System.Drawing.Point(239, 214);
            this.цена_за_единицуTextBox.Name = "цена_за_единицуTextBox";
            this.цена_за_единицуTextBox.Size = new System.Drawing.Size(131, 22);
            this.цена_за_единицуTextBox.TabIndex = 12;
            // 
            // сумма_в_покупкеTextBox
            // 
            this.сумма_в_покупкеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "Сумма в покупке", true));
            this.сумма_в_покупкеTextBox.Location = new System.Drawing.Point(157, 242);
            this.сумма_в_покупкеTextBox.Name = "сумма_в_покупкеTextBox";
            this.сумма_в_покупкеTextBox.Size = new System.Drawing.Size(131, 22);
            this.сумма_в_покупкеTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(сумма_в_покупкеLabel);
            this.Controls.Add(this.сумма_в_покупкеTextBox);
            this.Controls.Add(цена_за_единицуLabel);
            this.Controls.Add(this.цена_за_единицуTextBox);
            this.Controls.Add(количество_тавара_в_чекеLabel);
            this.Controls.Add(this.количество_тавара_в_чекеTextBox);
            this.Controls.Add(количество_товара_на_остаткахLabel);
            this.Controls.Add(this.количество_товара_на_остаткахTextBox);
            this.Controls.Add(единицы_измеренияLabel);
            this.Controls.Add(this.единицы_измеренияTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(this.cafeBindingNavigator);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingNavigator)).EndInit();
            this.cafeBindingNavigator.ResumeLayout(false);
            this.cafeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource cafeBindingSource;
        private CafeDataSetTableAdapters.CafeTableAdapter cafeTableAdapter;
        private CafeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cafeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cafeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox единицы_измеренияTextBox;
        private System.Windows.Forms.TextBox количество_товара_на_остаткахTextBox;
        private System.Windows.Forms.TextBox количество_тавара_в_чекеTextBox;
        private System.Windows.Forms.TextBox цена_за_единицуTextBox;
        private System.Windows.Forms.TextBox сумма_в_покупкеTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}