using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Main : Form
    {
        const string CORRECT = "√";
        const string WRONG = "x";
        private readonly int COUNT;
        private List<Calculation> calculations;
        private Action OnCalculationsChanged;

        public List<Calculation> Calculations
        {
            get
            {
                if (calculations == null)
                {
                    calculations = new List<Calculation>();
                }
                return calculations;
            }
            set
            {
                calculations = value;
                if (this.OnCalculationsChanged != null)
                {
                    this.OnCalculationsChanged();
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            this.COUNT = GetNumberFromConfig("count", 10);
            this.lblScore.Visible = false;
            this.cmbRange.SelectedIndex = GetNumberFromConfig("rangeTop", 10) == 10 ? 0 : 1;
            if (GetNumberFromConfig("background", 19) == 24)
            {
                this.panel3.BackgroundImage = Properties.Resources._24;
            }
            else
            {
                this.panel3.BackgroundImage = Properties.Resources._19;
            }
            this.OnCalculationsChanged = Calculations_Changed;
            this.OnCalculationsChanged();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var core = new Generator(GetNumberFromConfig("rangeBottom", 0), GetSafeNumber(this.cmbRange.Text, 10));
            if (this.rdoAdd.Checked)
            {
                this.Calculations = core.GetAdditions(COUNT);
            }
            else if (this.rdoSubtract.Checked)
            {
                this.Calculations = core.GetSubtractions(COUNT);
            }
            else
            {
                var calculations = core.GetAdditions(COUNT);
                calculations.AddRange(core.GetSubtractions(COUNT));
                var random = new Random();
                var numbers = Enumerable.Range(0, COUNT * 2);
                var shuffle = numbers.OrderBy(a => random.NextDouble());
                this.Calculations = new List<Calculation>();
                foreach (var n in shuffle)
                {
                    this.Calculations.Add(calculations[n]);
                    if (this.Calculations.Count >= COUNT)
                    {
                        break;
                    }
                }
                this.OnCalculationsChanged();
            }

            this.txtCalculations.Text = "";
            this.txtUserAnswers.Text = "";
            foreach (var c in this.Calculations)
            {
                if (this.txtCalculations.Text.Length > 0)
                {
                    this.txtCalculations.Text += Environment.NewLine;
                    this.txtUserAnswers.Text += Environment.NewLine;
                }
                this.txtCalculations.Text += c.ToString();
            }

            this.txtAnswers.Text = "";
            this.lblScore.Visible = false;
            this.txtUserAnswers.Focus();
            this.txtUserAnswers.SelectionStart = 0;
            this.txtUserAnswers.SelectionLength = 0;
        }

        private void btnSeeAnswers_Click(object sender, EventArgs e)
        {
            int corrects = 0;
            this.txtAnswers.Text = "";
            var userAnswers = this.txtUserAnswers.Text.Replace(Environment.NewLine, "|").Split('|');
            for (int i = 0; i < this.Calculations.Count; i++)
            {
                var answer = WRONG;
                if (userAnswers.Length > i && userAnswers[i] == this.Calculations[i].Result.ToString())
                {
                    answer = CORRECT;
                    corrects++;
                }
                if (i > 0)
                {
                    this.txtAnswers.Text += Environment.NewLine;
                }
                this.txtAnswers.Text += answer;
            }

            string comment;
            var score = corrects * 100 / this.Calculations.Count;
            if (score == 100)
            {
                comment = "太棒了，满分^_^";
            }
            else if (score >= 90)
            {
                comment = "很棒！";
            }
            else if (score >= 80)
            {
                comment = "不错，继续努力！";
            }
            else if (score >= 70)
            {
                comment = "错的有点多，需要努力啊！";
            }
            else if (score >= 60)
            {
                comment = "刚及格，争取下次考好。";
            }
            else if (score > 0)
            {
                comment = "表现不好哦:(";
            }
            else
            {
                comment = "太差了，考了个鸭蛋！！！";
            }
            Color color;
            if (score >= 80)
            {
                color = Color.Green;
            }
            else if (score >= 60)
            {
                color = Color.Orange;
            }
            else
            {
                color = Color.Red;
            }
            if (GetNumberFromConfig("background", 19) == 24)
            {
                color = Color.White;
            }
            this.lblScore.Text = string.Format("你得了{0}分，{1}{2}", score, Environment.NewLine, comment);
            this.lblScore.ForeColor = color;
            this.lblScore.Visible = true;
        }

        private void Calculations_Changed()
        {
            this.btnSeeAnswers.Enabled = this.Calculations.Count > 0;
        }

        private void txtUserAnswers_KeyPress(object sender, KeyPressEventArgs e)
        {
            var handled = false;
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (e.KeyChar == '\r' || e.KeyChar == '\n')
                {
                    handled = true;
                }
            }
            if (!handled)
            {
                // Enter at the last answer
                if (e.KeyChar == '\r' || e.KeyChar == '\n')
                {
                    var enterCount = this.txtUserAnswers.Text.Count(x => x == '\n');
                    if (enterCount == this.COUNT - 1)
                    {
                        if (this.txtUserAnswers.Text.LastIndexOf('\n') < this.txtUserAnswers.SelectionStart)
                        {
                            handled = true;
                        }
                    }
                }
            }
            if (handled)
            {
                btnSeeAnswers_Click(null, null);
                e.Handled = true;
            }
        }

        private void txtUserAnswers_KeyUp(object sender, KeyEventArgs e)
        {
            var cursorPosition = this.txtUserAnswers.SelectionStart;
            var userAnswers = this.txtUserAnswers.Text.Replace(Environment.NewLine, "|").Split('|');
            if (userAnswers.Length != this.COUNT)
            {
                var text = string.Empty;
                for (int i = 0; i < this.COUNT && i < userAnswers.Length; i++)
                {
                    if (i > 0)
                    {
                        text += Environment.NewLine;
                    }
                    text += userAnswers[i];
                }
                if (userAnswers.Length < this.COUNT)
                {
                    for (int i = 0; i < this.COUNT - userAnswers.Length; i++)
                    {
                        text += Environment.NewLine;
                    }
                }
                this.txtUserAnswers.Text = text;
                this.txtUserAnswers.SelectionStart = cursorPosition;
                this.txtUserAnswers.SelectionLength = 0;
            }
        }

        private void cmbRange_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerate_Click(null, null);
            }
        }

        private int GetNumberFromConfig(string key, int defaultValue)
        {
            return GetSafeNumber(ConfigurationManager.AppSettings[key], defaultValue);
        }

        private int GetSafeNumber(string value, int defaultValue)
        {
            int number;
            if (!int.TryParse(value, out number))
            {
                number = defaultValue;
            }
            return number;
        }
    }
}
