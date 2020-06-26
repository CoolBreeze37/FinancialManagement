using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        Char[] char_temp = new char[102];
        UInt16 char_temp_cnt = 0;
        UInt16 char_temp_amt = 0;

        Char[] data_temp = new char[102];
        UInt16 data_temp_cnt = 0;
        UInt16 data_temp_amt = 0;

        Char[] pos_temp = new char[102];
        UInt16 pos_temp_cnt = 0;

        float[] sum_temp = new float[102];
        UInt16 sum_temp_cnt = 0;

        public void addnum(Char num)
        {
            textBox1.Text = textBox1.Text + num;  //将点击的字符 加到文本框中显示
            char_temp[char_temp_amt++] = num;  //将点击的字符 存储到数组中
        }

        public bool Pos_Cmp(char ch) //判断是否是运算符
        {
            switch (ch)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                case '#':
                    return true;
                default:
                    return false;
            }
        }//判断ch是否为运算符

        public int Opid(char op1)
        {
            switch (op1)
            {
                case '+': return 0;
                case '-': return 1;
                case '*': return 2;
                case '/': return 3;
                case '(': return 4;
                case ')': return 5;
                case '#': return 6;
                default: return -123456;
            }
        }

        public char[,] Prior = new char[7, 7]
        { // 运算符优先级表   
                  // '+' '-'   '*'  '/'  '('  ')'  '#'    
            /*'+'*/{ '>', '>', '<', '<', '<', '>', '>' },
            /*'-'*/{ '>', '>', '<', '<', '<', '>', '>' },
            /*'*'*/{ '>', '>', '>', '>', '<', '>', '>' },
            /*'/'*/{ '>', '>', '>', '>', '<', '>', '>' },
            /*'('*/{ '<', '<', '<', '<', '<', '=', '<' },
            /*')'*/{ '>', '>', '>', '>', ' ', '>', '>' },
            /*'#'*/{ '<', '<', '<', '<', '<', '>', '=' },
        };

        public char Precede(char op1, char op2)  //优先级比较
        {
            int a, b;
            a = Opid(op1); b = Opid(op2);
            return (Prior[a, b]);
        }

        public float Operation(float a, char op, float b)
        {
            switch (op)
            {
                case '+':
                    return b + a;
                case '-':
                    return b - a;
                case '*':
                    return b * a;
                case '/':
                    return b / a;
                default:
                    return -123456;
            }
        }

        public void Calculate()
        {
            float temp1, temp2, num;

            pos_temp[pos_temp_cnt] = '#';

            while (char_temp_cnt < char_temp_amt)
            {
                if (Pos_Cmp(char_temp[char_temp_cnt]) == false)//字符为 数字
                {
                    while (char_temp[char_temp_cnt] >= '0' && char_temp[char_temp_cnt] <= '9')
                    {
                        data_temp[data_temp_amt++] = char_temp[char_temp_cnt++];
                    }
                    data_temp[data_temp_amt++] = '#';  //每个运算数之后均有一个#字符
                }
                else
                    switch (Precede(pos_temp[pos_temp_cnt], char_temp[char_temp_cnt]))
                    {
                        case '<':
                            pos_temp[++pos_temp_cnt] = char_temp[char_temp_cnt++];
                            break;
                        case '=':
                            pos_temp_cnt--;
                            char_temp_cnt++;
                            break;
                        case '>':
                            data_temp[data_temp_amt++] = pos_temp[pos_temp_cnt--];
                            break;
                    }
            }
            while (pos_temp_cnt != 0)
            {
                data_temp[data_temp_amt++] = pos_temp[pos_temp_cnt--];
            }

            while (data_temp_cnt < data_temp_amt)
            {
                switch (data_temp[data_temp_cnt])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        temp1 = sum_temp[--sum_temp_cnt];
                        temp2 = sum_temp[--sum_temp_cnt];
                        sum_temp[sum_temp_cnt++] = Operation(temp1, data_temp[data_temp_cnt], temp2);
                        break;
                    default:
                        num = 0;
                        while (data_temp[data_temp_cnt] >= '0' && data_temp[data_temp_cnt] <= '9')
                        {
                            num = 10 * num + data_temp[data_temp_cnt] - '0';
                            data_temp_cnt++;
                        }
                        sum_temp[sum_temp_cnt++] = num;

                        break;
                }
                data_temp_cnt++;
            }
            textBox1.Text = textBox1.Text + "=\r\n" + sum_temp[sum_temp_cnt - 1].ToString();
        }
        private void Num_1_Click(object sender, EventArgs e)
        {
            addnum('1');
        }
        private void Num_2_Click(object sender, EventArgs e)
        {
            addnum('2');
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            addnum('3');
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            addnum('4');
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            addnum('5');
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            addnum('6');
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            addnum('7');
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            addnum('8');
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            addnum('9');
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            addnum('0');
        }

        private void Ope_lbracket_Click(object sender, EventArgs e)
        {
            addnum('(');
        }

        private void Ope_rbracket_Click(object sender, EventArgs e)
        {
            addnum(')');
        }

        private void Num_dec_Click(object sender, EventArgs e)
        {
            //if (pos == 0)
            //{
            //    if (temp1_string.IndexOf(".") >= 0)  //只能添加一个小数点
            //        MessageBox.Show("已经添加了小数点！", "提示");
            //    else
            //    {
            //        temp1_string = temp1_string + ".";
            //        textBox1.Text = textBox1.Text + ".";
            //    }
            //}
            //if (pos != 0)
            //{
            //    if (temp2_string.IndexOf(".") >= 0)  //只能添加一个小数点
            //        MessageBox.Show("已经添加了小数点！", "提示");
            //    else
            //    {
            //        temp2_string = temp2_string + ".";
            //        textBox1.Text = textBox1.Text + ".";
            //    }
            //}                    
        }

        private void Ope_add_Click(object sender, EventArgs e)
        {
            addnum('+');
        }

        private void Ope_sub_Click(object sender, EventArgs e)
        {
            addnum('-');
        }

        private void Ope_mul_Click(object sender, EventArgs e)
        {
            addnum('*');
        }

        private void Ope_div_Click(object sender, EventArgs e)
        {
            addnum('/');
        }

        private void Ope_equal_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Ope_dle_Click(object sender, EventArgs e)
        {
            UInt16 temp_n;
            try
            {
                char_temp[--char_temp_amt] = '\0';
            }
            catch (Exception)
            {
                char_temp[++char_temp_amt] = '\0';
            }

            textBox1.Text = "";//显示屏清空

            for (temp_n = 0; temp_n <= char_temp_amt; temp_n++)
            {
                textBox1.Text += char_temp[temp_n];
            }
        }

        private void Ope_ace_Click(object sender, EventArgs e)
        {
            UInt16 temp_n;

            textBox1.Text = "";//显示屏清空

            for (temp_n = 0; temp_n <= data_temp_amt; temp_n++)
            {
                data_temp[temp_n] = '\0';
            }
            data_temp_cnt = 0;
            data_temp_amt = 0;

            for (temp_n = 0; temp_n <= sum_temp_cnt; temp_n++)
            {
                sum_temp[temp_n] = 0;
            }
            sum_temp_cnt = 0;

            pos_temp_cnt = 0;

            for (temp_n = 0; temp_n <= char_temp_amt; temp_n++)
            {
                char_temp[temp_n] = '\0';
            }
            char_temp_cnt = 0;
            char_temp_amt = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = ( float.Parse(textBox2.Text)* float.Parse(textBox3.Text)).ToString();
            textBox7.Text = (float.Parse(textBox4.Text) * float.Parse(textBox3.Text)).ToString();
            textBox8.Text = (float.Parse(textBox6.Text)*float.Parse(textBox5.Text)*0.01).ToString();
            textBox9.Text = (-float.Parse(textBox6.Text) - float.Parse(textBox8.Text) + float.Parse(textBox7.Text)).ToString();
            textBox10.Text = (float.Parse(textBox9.Text) /float.Parse(textBox6.Text)*100).ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}