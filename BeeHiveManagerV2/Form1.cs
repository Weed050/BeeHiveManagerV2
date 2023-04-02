namespace BeeHiveManager
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 1;

            //dodaæ 2 wartoœæ do konstruktora
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" },175); 
            workers[1] = new Worker(new string[] { "Pielêgnacja jaj", "Uczenie pszczó³" },114);
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ¿¹d³ami" },149);
            workers[3] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z ¿¹d³ami", "Pielêgnacja jaj", "Uczenie pszczó³", "Wytwarzanie miodu", "Zbieranie nektaru" },155);
            queen = new Queen(workers,275);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("Nie ma robotnic do wykoania '" + workerBeeJob.Text + "'", "Królowa pszczó³ mówi...");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' bêdzie ukoñczone za " + Shifts.Value + " zmiany.", "Królowa pszczó³ mówi...");
        }
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
