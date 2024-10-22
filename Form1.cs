using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Test_Paul_DJ
{
	public partial class Form1 : Form
	{
		double InterestRate, monthlyInterestRate, loanamount, MonthlyPayment, TotalPayment;
		int numberofYears;
		String iMonthlyPayment, iTotalPayment;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblBalance.Visible = false;
			lblDeposit.Visible = false;
			lblLoan.Visible = false;
			lblWithdrawal.Visible = false;
			
			btnLoan.Enabled = false;
			btnDeposit.Enabled = false;
			btnBalance.Enabled = false;
			btnWithdrawal.Enabled = false; 

			btnLoanSystem.Enabled = false;
			btnExit.Enabled = false;
			btnReset.Enabled = false;
			btnReceipt.Enabled = false;
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		private void button11_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "6";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "1";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "2";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "3";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			DialogResult iExit;

			iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			lblPin.Text = "";
			lblBalance.Visible = false;
			lblDeposit.Visible = false;
			lblLoan.Visible = false;
			lblWithdrawal.Visible = false;

			btnLoan.Enabled = false;
			btnDeposit.Enabled = false;
			btnBalance.Enabled = false;
			btnWithdrawal.Enabled = false;

			btnLoanSystem.Enabled = false;
			btnExit.Enabled = false;
			btnReset.Enabled = false;
			btnReceipt.Enabled = false;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "5";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "4";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "7";
		}

		private void button15_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "8";
		}

		private void button17_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "9";
		}

		private void button19_Click(object sender, EventArgs e)
		{
			String pin1 = String.Format(lblPin.Text, lblPin.Text);
			String pin2 = String.Format(lblPin.Text, lblPin.Text);
			String pin3 = String.Format(lblPin.Text, lblPin.Text);
			String pin4 = String.Format(lblPin.Text, lblPin.Text);
			String pin5 = String.Format(lblPin.Text, lblPin.Text);

			if (pin1 == "1234")
			{
				lblBalance.Visible = true;
				lblDeposit.Visible = true;
				lblLoan.Visible = true;
				lblWithdrawal.Visible = true;

				btnLoan.Enabled = true;
				btnDeposit.Enabled = true;
				btnBalance.Enabled = true;
				btnWithdrawal.Enabled = true;

				lblPin.Text = ""; 
			}
			else if (pin1 == "2345")
			{
				lblBalance.Visible = true;
				lblDeposit.Visible = true;
				lblLoan.Visible = true;
				lblWithdrawal.Visible = true;

				btnLoan.Enabled = true;
				btnDeposit.Enabled = true;
				btnBalance.Enabled = true;
				btnWithdrawal.Enabled = true;

				lblPin.Text = "";
			}
			else if (pin1 == "3456")
			{
				lblBalance.Visible = true;
				lblDeposit.Visible = true;
				lblLoan.Visible = true;
				lblWithdrawal.Visible = true;

				btnLoan.Enabled = true;
				btnDeposit.Enabled = true;
				btnBalance.Enabled = true;
				btnWithdrawal.Enabled = true;

				lblPin.Text = "";
			}
			else if (pin1 == "4567")
			{
				lblBalance.Visible = true;
				lblDeposit.Visible = true;
				lblLoan.Visible = true;
				lblWithdrawal.Visible = true;

				btnLoan.Enabled = true;
				btnDeposit.Enabled = true;
				btnBalance.Enabled = true;
				btnWithdrawal.Enabled = true;

				lblPin.Text = "";
			}
			else if (pin1 == "5678")
			{
				lblBalance.Visible = true;
				lblDeposit.Visible = true;
				lblLoan.Visible = true;
				lblWithdrawal.Visible = true;

				btnLoan.Enabled = true;
				btnDeposit.Enabled = true;
				btnBalance.Enabled = true;
				btnWithdrawal.Enabled = true;

				lblPin.Text = "";
			}
			else
			{
				lblPin.Text = "Invalid Pin";
			}
		}

		private void button20_Click(object sender, EventArgs e)
		{

		}

		private void button18_Click(object sender, EventArgs e)
		{

		}

		private void button16_Click(object sender, EventArgs e)
		{
			lblPin.Text = lblPin.Text + "0";
		}

		private void button14_Click(object sender, EventArgs e)
		{

		}

		private void lblDeposit_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			rtfReceipt.AppendText("Loan Management System Calculator" + "\n");
			rtfReceipt.AppendText("---------------------------------------------------" + "\n");
			rtfReceipt.AppendText("Enter amount of Loan" + "\t" + txtAmountofLoan.Text +"\n");
			rtfReceipt.AppendText("Enter Number of Year" + "\t" + txtNumberofYear.Text +"\n");
			rtfReceipt.AppendText("Enter Interest Rate" + "\t" + "\t" + txtInterestRate.Text +"\n");
			rtfReceipt.AppendText("Monthly Payment" + "\t" + "\t" + lblMonthlyPayment.Text +"\n");
			rtfReceipt.AppendText("Total Payment" + "\t" + "\t" + "\t" + lblTotalPayment.Text +"\n");
			rtfReceipt.AppendText("-----------------------------------------------------" + "\n");
			rtfReceipt.AppendText("-----------------Thank You------------------" + "\n");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult iExit;

			iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void lblBalance_Click(object sender, EventArgs e)
		{

		}

		private void lblLoan_Click(object sender, EventArgs e)
		{

		}

		private void groupBox5_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLoanSystem_Click(object sender, EventArgs e)
		{
			InterestRate = Convert.ToDouble(txtInterestRate.Text);
			monthlyInterestRate = InterestRate / 1200;
			numberofYears = Convert.ToInt32(txtNumberofYear.Text);
			loanamount = Convert.ToDouble(txtAmountofLoan.Text);

			MonthlyPayment = loanamount*monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberofYears * 12));
			//------------------------------------------------------------------------------------------------------------------
			iMonthlyPayment = Convert.ToString(MonthlyPayment);
			iMonthlyPayment = String.Format("{0:C}",MonthlyPayment);
			lblMonthlyPayment.Text = (iMonthlyPayment);
			//------------------------------------------------------------------------------------------------------------------
			TotalPayment = MonthlyPayment * numberofYears * 12;
			iTotalPayment = String.Format("{0:C}", TotalPayment);
			lblTotalPayment.Text = (iTotalPayment);

			txtAmountofLoan.Text = String.Format("{0:C}",loanamount);
		}

        private void lblMonthlyPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void btnLoan_Click(object sender, EventArgs e)
		{
			btnLoanSystem.Enabled = true;
			btnExit.Enabled = true;
			btnReset.Enabled = true;
			btnReceipt.Enabled = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtAmountofLoan.Clear();
			txtNumberofYear.Clear();
			txtInterestRate.Clear();
			lblMonthlyPayment.Text = "";
			lblTotalPayment.Text = "";
			rtfReceipt.Clear();

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
