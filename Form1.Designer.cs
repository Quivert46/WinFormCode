namespace WinFormsApp2
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

        private TextBox txtName;
        private DateTimePicker dtpBirth;
        private ComboBox cboCourse;
        private Button btnRegister;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private RadioButton rdoUndefined;
        private CheckBox chkConfirm;
        private MaskedTextBox mtxtPhone;
    }
}
