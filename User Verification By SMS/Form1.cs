using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Verification_By_SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ساعت
        int _hour;
        //دقیقه
        int _minute;
        //ثانیه
        int _second;

        //کد ارسالی
        string _code = string.Empty;

        private void btnGetTheCode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //تولید کد 5 رقمی
            _code = rnd.Next(10000, 99999).ToString();


            //برای ارسال پیامک باید از وب سرویس استفاده کنید ما در این برنامه از وب سرویس پارس گرین استفاده کردیم 
            PARSGREEN.API_SendSMS.SendSMS send = new PARSGREEN.API_SendSMS.SendSMS();
            // تعداد ارسال های موفق 
            int successCount = 0;

            //این آرایه برای این هست که متوجه بشیم پیامک برای نرم افزار ارسال شده است
            string[] returnstr = null;


            // ورودی اول کد(API KEY) داده شده توسط پارس گرین 
            // ورودی دوم شماره(شماره فرستنده مثال 00000000033232897) داده شده توسط پارس گرین
            int retStatus = send.SendGroupSMS("", "", new string[] { txtMobile.Text }, _code, false, string.Empty, ref successCount, ref returnstr);

            lblMobile.Visible = false;
            txtMobile.Visible = false;
            btnGetTheCode.Visible = false;

            lblGetTheCode.Visible = true;
            lblRemainingTime.Visible = true;
            btnLogin.Visible = true;
            lblRemainingTime.Visible = true;
            txtCode.Visible = true;

            _hour = 00;
            // دقیقه مهلت برای وارد کردن کد  2 
            _minute = 02;
            _second = 00;

            lblRemainingTime.ForeColor = Color.Black;

            //فعالسازی تایمر 
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //رویداد تیک تایمر

            if (_minute == 0 && _hour == 0 && _second == 0)
            {
                timer1.Enabled = false;
                lblGetTheCode.Visible = false;
                lblRemainingTime.Visible = false;
                btnLogin.Visible = false;
                lblRemainingTime.Visible = false;
                txtCode.Visible = false;

                lblMobile.Visible = true;
                txtMobile.Visible = true;
                btnGetTheCode.Visible = true;
            }
            else
            {
                if (_second < 1)
                {
                    _second = 59;
                    if (_minute == 0)
                    {
                        _minute = 59;
                        if (_hour != 0)
                            _hour -= 1;
                    }
                    else
                    {
                        _minute -= 1;
                    }
                }
                else
                    _second -= 1;

                lblRemainingTime.Text = _hour <= 9 ? "0" + _hour.ToString() + ":" : _hour.ToString() + ":";
                lblRemainingTime.Text += _minute <= 9 ? "0" + _minute.ToString() + ":" : _minute.ToString() + ":";
                lblRemainingTime.Text += _second <= 9 ? "0" + _second.ToString() : _second.ToString();

                if (_minute == 0 && _hour == 0 && _second < 60)
                    lblRemainingTime.ForeColor = Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //اگر کد وارد شده صحیح باشد
            if (_code == txtCode.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("کد وارد شده صحیح می باشد");
            }
            else
            {
                txtCode.Text = string.Empty;

                MessageBox.Show("کد وارد شده اشتباه است !!!!");
            }
        }
    }
}
