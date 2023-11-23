using KurtAdamIstilasiOdev.Models;

namespace KurtAdamIstilasiOdev
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "Teke Tek Dövüþ Oyunu";
			btnReset.Enabled = false;
			lblHealth.Width = 300;
			lblEnemyHealth.Width = 300;
			btnAttack.Enabled = false;
		}
		Hero hero;
		EnemyHero enemyHero;

		private void btnChoose_Click(object sender, EventArgs e)
		{
			btnChoose.Enabled = false;
			if (btnEnemyChoose.BackColor == Color.DimGray)
			{
				btnEnemyChoose.BackColor = Color.White;
			}
			else
			{
				btnChoose.BackColor = Color.DimGray;
			}


			hero = new Hero()
			{
				NickName = txtNickName.Text,
				Race = cmbRace.SelectedItem.ToString(),
				Class = cmbClass.SelectedItem.ToString()
			};
		}

		private void btnAttack_Click(object sender, EventArgs e)
		{
			hero.Attack();
			lblHealth.Width = lblHealth.Width - hero.Damage;
			if (lblHealth.Width == 0)
			{
				MessageBox.Show("Savaþý kötüler kazandý!");
				btnAttack.Enabled = false;
				btnReset.Enabled = true;
			}
			enemyHero.Attack();
			lblEnemyHealth.Width = lblEnemyHealth.Width - enemyHero.Damage;
			if (lblEnemyHealth.Width == 0)
			{
				MessageBox.Show("Savaþý iyiler kazandý!");
				btnAttack.Enabled = false;
				btnReset.Enabled = true;
			}
		}

		private void btnEnemyChoose_Click(object sender, EventArgs e)
		{
			btnEnemyChoose.Enabled = false;
			if (btnEnemyChoose.BackColor == Color.DimGray)
			{
				btnEnemyChoose.BackColor = Color.White;
			}
			else
			{
				btnEnemyChoose.BackColor = Color.DimGray;
			}

			btnAttack.Enabled = true;
			enemyHero = new EnemyHero()
			{
				NickName = txtEnemyName.Text,
				Race = cmbEnemyRace.SelectedItem.ToString(),
				Class = cmbEnemyClass.SelectedItem.ToString()
			};
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lblHealth.Width = 300;
			lblEnemyHealth.Width = 300;
			btnChoose.Enabled = true;
			btnEnemyChoose.Enabled = true;
			btnEnemyChoose.BackColor = Color.White;
			btnChoose.BackColor = Color.White;

		}
	}
}