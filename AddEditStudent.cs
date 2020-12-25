using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private int _studentId;
        private Student _student;
        private List<Group> _groups;
          
        private FileHelper<List<Student>> _fileHelper =
             new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0) //konstruktor klasy
        {
            InitializeComponent();
            InitializeGroups();

            _studentId = id;

            GetStudentData();
            tbFirstName.Select(); //metoda, która aktywuje od razu pole Imię w oknie danych ucznia, po kliknięciu przycisku "Dodaj".
        }

        private void InitializeGroups()
        {
            _groups = new List<Group>();//inicjalizacja listy grup (wszystkich klas uczniów),
            _groups.Add(new Group { Id = 0, Name = "--Brak klasy--" });//dodanie do listy grupy "Brak klasy",
            _groups.Add(new Group { Id = 1, Name = "Klasa 1" });//dodanie do listy 1 klasy,
            _groups.Add(new Group { Id = 2, Name = "Klasa 2" });//dodanie do listy 2 klasy,
            _groups.Add(new Group { Id = 3, Name = "Klasa 3" });//dodanie do listy 3 klasy,

            cboxIdClass.DataSource = _groups;//ustawiamy naszą listę, która ma w sobie informacje o wszystkich grupach jako źródło tego comboboxa, dzięki temu grupy będą już się wyświetlać na formatce
            cboxIdClass.DisplayMember = "Name";//chcemy, by użytkownik widział wartość właściwości Name. Czyli żeby nauczyciel na formatce widział nazwy Klasa 1, Klasa 2, Klasa 3, itd.
            cboxIdClass.ValueMember = "Id";//w kodzie interesuje nas identyfikator, czyli do pliku, a konkretnie do właściwości IdGroup ucznia przypisujemy wartość identyfikatora.
            cboxIdClass.SelectedIndex = 0;//po uruchomieniu formatki chcemy żeby na początek jako domyślna grupa była zaznaczona grupa o Id 0, czyli grupa "Brak klasy".
        }

        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edytowanie danych ucznia";

                var students = _fileHelper.DeserializeFromFile(); //pobranie danych o uczniach z pliku
                _student = students.FirstOrDefault(x => x.Id == _studentId); //pobranie z listy pierwszego ucznia, który ma określone Id, przekazane wcześniej do konstruktora.
                //Jeżeli nie będzie takiego ucznia, zwrócony zostanie "null".

                if (_student == null) //obsługa wyjątku, gdy nie ma ucznia o podanym Id
                    throw new Exception("Brak użytkownika o podanym Id.");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString(); //przypisanie danych ucznia do pól na formatce
            tbFirstName.Text = _student.FirstName; //do właściwości Text pola tekstowego przypisujemy dane ucznia
            tbLastName.Text = _student.LastName;
            tbMath.Text = _student.Math;
            tbPhisics.Text = _student.Physics;
            tbTechnology.Text = _student.Technology;
            tbPolishLang.Text = _student.PolishLang;
            tbEnglishLang.Text = _student.EnglishLang;
            rtbComments.Text = _student.Comments;
            checkBox1.Checked = _student.AdditionalClasses;
            cboxIdClass.SelectedItem = _groups.First(x => x.Id == _student.IdGroup);//do właściwości SelectedItem comboboxa przypisujemy odpowiednią grupę z naszej listy. Czyli za pomocą LINQ szukamy grupy, która ma takie id - jak nasz wybrany (edytowany) uczeń. Używamy do tego First, która znajdzie pierwszą (a właściwie jedyną) grupą o takim id.
        }            

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0) //sprawdzamy jakie Id ucznia zostało przekazane przez konstruktor            
                students.RemoveAll(x => x.Id == _studentId);            
            else            
                AssignIdToNewStudent(students);

            AddNewUserToList(students);
            
            _fileHelper.SerializeToFile(students); //przekazanie całej listy studentów do pliku

            Close(); //wywołanie metody, która zamknie formatkę, w której dodawany był nowy uczeń (obiekt)
        }
       
        private async Task LongProcessAsync()
        {
            await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                });
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student //stworzenie nowego obiektu klasy Student
            {
                Id = _studentId, //inicjalizacja poszczególnych pól dla obiektu
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                EnglishLang = tbEnglishLang.Text,
                Math = tbMath.Text,
                Physics = tbPhisics.Text,
                PolishLang = tbPolishLang.Text,
                Technology = tbTechnology.Text,
                AdditionalClasses = checkBox1.Checked,
                IdGroup = (cboxIdClass.SelectedItem as Group).Id //do właściwosci przypisujemy ID wybranej grupy
            };

            students.Add(student); //dodanie stworzonego obiektu do listy studentów
        }

        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();

            _studentId = studentWithHighestId == null ?
                1 : studentWithHighestId.Id + 1;
        }
            
        private void AddEditStudent_Load(object sender, EventArgs e)
        {

        }

        private void cboxIdClass_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}