using System;
using System.Drawing;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public class TextboxPlaceHolderConfigurator
    {
        private readonly TextBox _textBox;
        private readonly string _placeHolderText;

        public TextboxPlaceHolderConfigurator(TextBox textBox, string placeHolderText)
        {
            this._textBox = textBox;
            this._placeHolderText = placeHolderText;
        }

        public void ConfigureTextBox()
        {
            ChangeColor();
            SetPlaceHolderText();
            AddEvents();
        }
        private void ChangeColor()
        {
            _textBox.ForeColor = SystemColors.InactiveCaption;
        }

        private void SetPlaceHolderText()
        {
            _textBox.Text = _placeHolderText;
        }

        private void AddEvents()
        {
            _textBox.Enter += TextBox_Enter;
            _textBox.Leave += TextBox_Leave;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (_textBox.Text == _placeHolderText)
            {
                _textBox.Text = "";
                _textBox.ForeColor = Color.Black;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (_textBox.Text == "")
            {
                _textBox.Text = _placeHolderText;
                _textBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
    }
}
