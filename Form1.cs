using Microsoft.VisualBasic.Devices;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Course> courses = new List<Course>()
        {
            new Course(1, "Lap trinh C#"),
            new Course(2, "Co so du lieu"),
            new Course(3, "Lap trinh Java"),
            new Course(4, "Triet hoc Mac-Lenin")
        };
        private void InitializeComponent()
        {
            txtName = new TextBox();
            dtpBirth = new DateTimePicker();
            cboCourse = new ComboBox();
            btnRegister = new Button();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            rdoUndefined = new RadioButton();
            chkConfirm = new CheckBox();
            mtxtPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 27);
            txtName.TabIndex = 0;
            // 
            // dtpBirth
            // 
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(12, 276);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 27);
            dtpBirth.TabIndex = 2;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(12, 12);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(326, 28);
            cboCourse.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(326, 29);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Dang ky";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(12, 176);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 5;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(12, 206);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(49, 24);
            rdoFemale.TabIndex = 6;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nu";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoUndefined
            // 
            rdoUndefined.AutoSize = true;
            rdoUndefined.Location = new Point(12, 236);
            rdoUndefined.Name = "rdoUndefined";
            rdoUndefined.Size = new Size(81, 24);
            rdoUndefined.TabIndex = 7;
            rdoUndefined.TabStop = true;
            rdoUndefined.Text = "Chua ro";
            rdoUndefined.UseVisualStyleBackColor = true;
            // 
            // chkConfirm
            // 
            chkConfirm.AutoSize = true;
            chkConfirm.Location = new Point(12, 326);
            chkConfirm.Name = "chkConfirm";
            chkConfirm.Size = new Size(151, 24);
            chkConfirm.TabIndex = 8;
            chkConfirm.Text = "Xac nhan dang ky ";
            chkConfirm.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(12, 124);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(326, 27);
            mtxtPhone.TabIndex = 9;
            // 
            // Form1
            // 
            ClientSize = new Size(621, 508);
            Controls.Add(mtxtPhone);
            Controls.Add(chkConfirm);
            Controls.Add(rdoUndefined);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(btnRegister);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirth);
            Controls.Add(txtName);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        public class Course
        {
            public int id { get; set; }
            public string name { get; set; }

            public Course(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "name";
            cboCourse.ValueMember = "id";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mon = cboCourse.Text;
            string ten = txtName.Text;
            string sdt = mtxtPhone.Text;
            string gioi;
            if(rdoMale.Checked)
            {
                gioi = "Nam";
            }
            else if(rdoFemale.Checked)
            {
                gioi = "Nu";
            }
            else
            {
                gioi = "Chua ro";
            }
            string sinh = dtpBirth.Value.ToString("dd/MM/yyyy");

            MessageBox.Show(
                "Mon hoc dang ky: " + mon + "\n" +
                "Ho ten: " + ten + "\n" +
                "So dien thoai: " + sdt + "\n" +
                "Gioi tinh: " + gioi + "\n" +
                "Ngay sinh: " + sinh);
        }
    }
}
