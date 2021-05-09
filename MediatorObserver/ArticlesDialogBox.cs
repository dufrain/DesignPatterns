using System;
 
namespace MediatorObserver
{
    public class ArticlesDialogBox
    {
        private ListBox _articlesListBox = new ListBox();
        private TextBox _titleTextBox = new TextBox();
        private Button _saveButton = new Button();

        public ArticlesDialogBox()
        {
            //_articlesListBox.Attach(); // come back when you know more about event handler
        }

        public void Simulate()
        {
            _articlesListBox.SetSelector("Article 1");
            _titleTextBox.SetContent("");
            _articlesListBox.SetSelector("Article 2");
            Console.WriteLine("textbox: " + _titleTextBox.GetContent());
            Console.WriteLine("button: " + _saveButton.GetEnabled());
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
