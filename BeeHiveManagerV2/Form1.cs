namespace BeeHiveManager
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 1;

            //doda� 2 warto�� do konstruktora
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" },175); 
            workers[1] = new Worker(new string[] { "Piel�gnacja jaj", "Uczenie pszcz�" },114);
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ��d�ami" },149);
            workers[3] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ��d�ami", "Piel�gnacja jaj", "Uczenie pszcz�", "Wytwarzanie miodu", "Zbieranie nektaru" },155);
            queen = new Queen(workers,275);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("Nie ma robotnic do wykoania '" + workerBeeJob.Text + "'", "Kr�lowa pszcz� m�wi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' b�dzie uko�czone za " + Shifts.Value + " zmiany.", "Kr�lowa pszcz� m�wi...");
        }
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
