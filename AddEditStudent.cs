using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private int _studentId;
        private Student _student;

        private FileHelper<List<Student>> _fileHelper =
             new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            _studentId = id;

            GetStudentData();
            tbFirstName.Select(); //metoda, która aktywuje od razu pole Imię w oknie danych ucznia, po kliknięciu przycisku "Dodaj".
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
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
    }
}