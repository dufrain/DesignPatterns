using System;

namespace Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox _articlesListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public void RegisterControls(ListBox listBox, TextBox textBox, Button button)
        {
            _articlesListBox = listBox;
            _titleTextBox = textBox;
            _saveButton = button;
        }

        public void Simulate()
        {
            _articlesListBox.SetSelector("Article 1");
            _titleTextBox.SetContent("");
            _articlesListBox.SetSelector("Article 2");
            Console.WriteLine("textbox: " + _titleTextBox.GetContent());
            Console.WriteLine("button: " + _saveButton.GetEnabled());
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                articleSelected();
            }
            else if (control == _titleTextBox)
            {
                titleChanged();
            }
        }

        private void titleChanged()
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = string.IsNullOrEmpty(content);
            _saveButton.SetEnabled(!isEmpty);
        }

        private void articleSelected()
        {
            _titleTextBox.SetContent(_articlesListBox.GetSelector());
        }
    }
}
