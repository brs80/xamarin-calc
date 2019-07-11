using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnAddition(object sender, EventArgs e)
        {
            try
            {
                var fv = decimal.Parse(en1.Text);
                var sv = decimal.Parse(en2.Text);
                result.Text = $"{fv} + {sv} = {fv + sv}";
            } catch {  }
        }
        // handler for subtraction 
        private void OnSubtraction(object sender, EventArgs e)
        {
            try
            {
                var fv = decimal.Parse(en1.Text);
                var sv = decimal.Parse(en2.Text);
                result.Text = $"{fv} - {sv} = {fv - sv}";
            } catch { }
        }
        // handler for multiplication 
        private void OnMultiplication(object sender, EventArgs e)
        {
            try
            {
                var fv = decimal.Parse(en1.Text);
                var sv = decimal.Parse(en2.Text);
                result.Text = $"{fv} * {sv} = {fv * sv}";
            } catch {  }
        }
        private void OnDivision(object sender, EventArgs e)
        {
            try
            {
                var fv = decimal.Parse(en1.Text);
                var sv = decimal.Parse(en2.Text);
                result.Text = $"{fv} / {sv} = {fv / sv}";
            } catch {  }
        }
        private void OnOne(object sender, EventArgs e)
        {
            en1.Text += "1"; 
        }
        private void OnTwo(object sender, EventArgs e)
        {
            en1.Text += "2";
        }
        private void OnThree(object sender, EventArgs e)
        {
            en1.Text += "3";
        }  
        private void OnFour(object sender, EventArgs e)
        {
            en1.Text += "4";
        }
        private void OnFive(object sender, EventArgs e)
        {
            en1.Text += "5";
        }
        private void OnSix(object sender, EventArgs e)
        {
            en1.Text += "6";
        }
        private void OnSeven(object sender, EventArgs e)
        {
            en1.Text += "7";
        }
        private void OnEight(object sender, EventArgs e)
        {
            en1.Text += "8";
        }
        private void OnNine(object sender, EventArgs e)
        {
            en1.Text += "9";
        }
        private void OnOneb(object sender, EventArgs e)
        {
            en2.Text += "1";
        }
        private void OnTwob(object sender, EventArgs e)
        {
            en2.Text += "2";
        }
        private void OnThreeb(object sender, EventArgs e)
        {
            en2.Text += "3";
        }
        private void OnFourb(object sender, EventArgs e)
        {
            en2.Text += "4";
        }
        private void OnFiveb(object sender, EventArgs e)
        {
            en2.Text += "5";
        }
        private void OnSixb(object sender, EventArgs e)
        {
            en2.Text += "6";
        }
        private void OnSevenb(object sender, EventArgs e)
        {
            en2.Text += "7";
        }
        private void OnEightb(object sender, EventArgs e)
        {
            en2.Text += "8";
        }
        private void OnNineb(object sender, EventArgs e)
        {
            en2.Text += "9";
        }
    }
}
