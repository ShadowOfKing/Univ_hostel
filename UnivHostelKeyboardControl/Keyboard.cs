using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivHostelKeyboardControl
{
    public partial class Keyboard: UserControl
    {
		private TextBoxBase _textBox { get; set; }
		private bool _shiftPressed { get; set; }
		private bool _isEng { get; set; }
		private List<KeyboardButton> _buttons { get; set; }
		public Keyboard()
        {
            InitializeComponent();
			var keys = new List<List<KeyValuePair<string, string>>>
			{
				new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("0",null),
					new KeyValuePair<string, string>("1",null),
					new KeyValuePair<string, string>("2",null),
					new KeyValuePair<string, string>("3",null),
					new KeyValuePair<string, string>("4",null),
					new KeyValuePair<string, string>("5",null),
					new KeyValuePair<string, string>("6",null),
					new KeyValuePair<string, string>("7",null),
					new KeyValuePair<string, string>("8",null),
					new KeyValuePair<string, string>("9",null),
					new KeyValuePair<string, string>("-",null)
				},
				new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("й","q"),
					new KeyValuePair<string, string>("ц","w"),
					new KeyValuePair<string, string>("у","e"),
					new KeyValuePair<string, string>("к","r"),
					new KeyValuePair<string, string>("е","t"),
					new KeyValuePair<string, string>("н","y"),
					new KeyValuePair<string, string>("г","u"),
					new KeyValuePair<string, string>("ш","i"),
					new KeyValuePair<string, string>("щ","o"),
					new KeyValuePair<string, string>("з","p"),
					new KeyValuePair<string, string>("х","\"")
				},
				new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("ф","a"),
					new KeyValuePair<string, string>("ы","s"),
					new KeyValuePair<string, string>("в","d"),
					new KeyValuePair<string, string>("а","f"),
					new KeyValuePair<string, string>("п","g"),
					new KeyValuePair<string, string>("р","h"),
					new KeyValuePair<string, string>("о","j"),
					new KeyValuePair<string, string>("л","k"),
					new KeyValuePair<string, string>("д","l"),
					new KeyValuePair<string, string>("ж",":"),
					new KeyValuePair<string, string>("э",",")
				},
				new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("я","z"),
					new KeyValuePair<string, string>("ч","x"),
					new KeyValuePair<string, string>("с","c"),
					new KeyValuePair<string, string>("м","v"),
					new KeyValuePair<string, string>("и","b"),
					new KeyValuePair<string, string>("т","n"),
					new KeyValuePair<string, string>("ь","m"),
					new KeyValuePair<string, string>("б",";"),
					new KeyValuePair<string, string>("ю","."),
					new KeyValuePair<string, string>("ё","?"),
					new KeyValuePair<string, string>("ъ","!")
				},
			};
			_buttons = new List<KeyboardButton>();
			var x = 0;
			var y = 0;
			foreach (var row in keys)
			{
				x = 0;
				foreach (var key in row)
				{
					var button = new KeyboardButton(key.Key, key.Value);
					button.Left = 0;
					button.Top = 0;
					button.Width = 10;
					button.Height = 10;
					button.Row = y;
					button.Col = x;
					AddButton(button);
					x++;
				}
				y ++;
			}
			x = 0;
			y = 0;
			var lang = new KeyboardButton("Сменить язык", "", KeyboardButtonType.Lang, x, y, 10, 10);
			var shift = new KeyboardButton("↑ Верхний регистр", "", KeyboardButtonType.Shift, x, y, 100, 10);
			var space = new KeyboardButton("Пробел", "", KeyboardButtonType.Space, x, y, 10, 10);
			var backspace = new KeyboardButton("← Удалить", "", KeyboardButtonType.Backspace, x, y, 10, 10);
			var enter = new KeyboardButton("↓ Новая строка", "", KeyboardButtonType.Enter, x, y, 10, 10);
			AddButton(lang);
			AddButton(shift);
			AddButton(space);
			AddButton(backspace);
			AddButton(enter);
			ResizeWindow(null, null);
			Resize += ResizeWindow;
			//SetForm(null);
		}

		private void ResizeWindow(object sender, EventArgs args)
		{
			var fullWidth = Width / 11;
			var deltaX = fullWidth / 11;
			var fullHeight = Height / 5;
			var deltaY = fullHeight / 5;
			var height = fullHeight * 4 / 5;
			var altWidth = Width * 19 / 100;
			var spaceWidth = Width * 24 / 100;
			var x = deltaX / 2;
			var y = deltaY / 2;
			foreach (var button in _buttons)
			{
				button.Left = x;
				button.Top = y;
				switch (button.Type)
				{
					case KeyboardButtonType.Backspace:
						button.Left += altWidth * 3 + spaceWidth;
						button.Top += fullHeight * 4;
						button.Width = altWidth;
						break;
					case KeyboardButtonType.Enter:
						button.Left += altWidth * 2 + spaceWidth;
						button.Top += fullHeight * 4;
						button.Width = altWidth;
						break;
					case KeyboardButtonType.Lang:
						button.Top +=  fullHeight * 4;
						button.Width = altWidth;
						break;
					case KeyboardButtonType.Letter:
						button.Left += button.Col * fullWidth;
						button.Top += button.Row * fullHeight;
						button.Width = fullWidth;
						button.Font = new Font("Microsoft Sans Serif", (float)(height / 1.5), FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
						break;
					case KeyboardButtonType.Shift:
						button.Left += altWidth;
						button.Top += fullHeight * 4;
						button.Width = altWidth;
						break;
					case KeyboardButtonType.Space:
						button.Left += altWidth * 2;
						button.Top += fullHeight * 4;
						button.Width = spaceWidth;
						break;
				}
				if (button.Type != KeyboardButtonType.Letter)
				{
					button.Font = new Font("Microsoft Sans Serif", Math.Max((float)(height / 4), (float)((altWidth -deltaY) / 18)), FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
				}
				button.Width -= deltaX;
				button.Height = height;
			}
		}

		private void AddButton(KeyboardButton button)
		{
			button.FlatAppearance.BorderSize = 0;
			button.FlatStyle = FlatStyle.Flat;
			button.UseVisualStyleBackColor = true;
			button.MouseDown += ButtonKeyDown;
			button.MouseUp += ButtonKeyUp;
			button.BackColor = SystemColors.ControlLight;
			Controls.Add(button);
			_buttons.Add(button);
		}

		//public void SetForm(Form form)
		//{
		//	_currentForm = form;
		//	//TODO: DEV
		//	if (_currentForm == null)
		//	{
		//		_currentForm = new Form();
		//		TextBoxBase textBox = new TextBox();
		//		textBox.Left = 200;
		//		textBox.Top = 50;
		//		textBox.Width = 400;
		//		textBox.Height = 50;
		//		_currentForm.Controls.Add(textBox);
		//		AddControl(textBox);
		//		textBox = new RichTextBox();
		//		textBox.Left = 200;
		//		textBox.Top = 150;
		//		textBox.Width = 400;
		//		textBox.Height = 200;
		//		_currentForm.Controls.Add(textBox);
		//		AddControl(textBox);
		//		_currentForm.Width = 700;
		//		_currentForm.Height = 500;
		//		_currentForm.Show();
		//	}
		//}
		private void FocusControl(object sender, EventArgs args)
		{
			if (sender is TextBoxBase tb)
			{
				_textBox = tb;
			}
		}
		public void AddControl(TextBoxBase control)
		{
			control.Enter += FocusControl;
		}
		public void RemoveControl(TextBoxBase control)
		{
			control.Enter -= FocusControl;
		}
		private void UpdateButtons()
		{
			foreach (var button in _buttons.Where(b => b.Type == KeyboardButtonType.Letter))
			{
				button.Text = _isEng ? button.Eng : button.Rus;
				if (button.Eng == "")
				{
					button.Visible = !_isEng;
				}
				button.Text = _shiftPressed ? button.Text.ToUpper() : button.Text.ToLower();
			}
		}

		private void ButtonKeyDown(object sender, EventArgs e)
		{
			var button = (KeyboardButton)sender;
			button.BackColor = SystemColors.Highlight;
		}
		private void ButtonKeyUp(object sender, EventArgs e)
		{
			var button = (KeyboardButton)sender;
			Color color = SystemColors.ControlLight;
			if (button.Type == KeyboardButtonType.Shift)
			{
				_shiftPressed = !_shiftPressed;
				if (_shiftPressed)
				{
					color = SystemColors.ActiveCaption;
				}
				UpdateButtons();
			}
			else if (button.Type == KeyboardButtonType.Lang)
			{
				_isEng = !_isEng;
				UpdateButtons();
				if (_isEng)
				{
					color = SystemColors.ActiveCaption;
				}
			}
			else
			{
				AddTextToControl(button);
			}
			button.BackColor = color;
		}
		private void AddTextToControl(KeyboardButton button)
		{
			if (/*_currentForm == null &&*/ _textBox == null)
			{
				return;
			}
			Control control = _textBox;
			//foreach (Control c in _currentForm.Controls)
			//{
			//	if (control != null)
			//	{
			//		break;
			//	}
			//	control = c.FindFocusedComponent();
			//}
			if (control == null || !(control is TextBoxBase)) {
				return;
			}
			var textBox = (TextBoxBase)control;
			var index = textBox.SelectionStart;
			var selected = textBox.SelectionLength > 0;
			if (selected)
			{
				textBox.Text = textBox.Text.Remove(index, textBox.SelectionLength);
			}
			switch (button.Type)
			{
				case KeyboardButtonType.Backspace:
					if (!selected && index > 0)
					{
						textBox.Text = textBox.Text.Remove(index - 1, 1);
						index--;
					}
					index--;
					break;
				case KeyboardButtonType.Enter:
					if (textBox is RichTextBox)
					{
						textBox.Text = textBox.Text.Insert(index, "\n");
					} else
					{
						index--;
					}
					break;
				case KeyboardButtonType.Letter:
					textBox.Text = textBox.Text.Insert(index, button.Text);
					break;
				case KeyboardButtonType.Space:
					textBox.Text = textBox.Text.Insert(index, " ");
					break;
			}
			textBox.SelectionStart = Math.Min(index + 1, textBox.Text.Length);
			textBox.Focus();
		}
    }
}
