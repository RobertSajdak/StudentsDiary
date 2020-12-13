using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private string _filePath =
           Path.Combine(Environment.CurrentDirectory, "students.txt");
        private int _studentId;

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            _studentId = id;

            if(id != 0)
            {
                Text = "Edytowanie danych ucznia";
                
                var students = DeserializeFromFile(); //pobranie danych o uczniach z pliku
                var student = students.FirstOrDefault(x => x.Id == id); //pobranie z listy pierwszego ucznia, który ma określone Id, przekazane wcześniej do konstruktora.
                //Jeżeli nie będzie takiego ucznia, zwrócony zostanie "null".

                if(student == null) //obsługa wyjątku, gdy nie ma ucznia o podanym Id
                    throw new Exception("Brak użytkownika o podanym Id.");

                tbId.Text = student.Id.ToString(); //przypisanie danych ucznia do pól na formatce
                tbFirstName.Text = student.FirstName; //do właściwości Text pola tekstowego przypisujemy dane ucznia
                tbLastName.Text = student.LastName;
                tbMath.Text = student.Math;
                tbPhisics.Text = student.Physics;
                tbTechnology.Text = student.Technology;
                tbPolishLang.Text = student.PolishLang;
                tbEnglishLang.Text = student.EnglishLang;
                rtbComments.Text = student.Comments;
            }

            tbFirstName.Select(); //metoda, która aktywuje od razu pole Imię w oknie danych ucznia, po kliknięciu przycisku "Dodaj".
        }
        public void SerializeToFile(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public List<Student> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Student>();

            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (List<Student>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = DeserializeFromFile();

            if (_studentId != 0) //sprawdzamy jakie Id ucznia zostało przekazane przez konstruktor
            {
                students.RemoveAll(x => x.Id == _studentId);
            }
            else
            {
                var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();

                //var studentId = 0;

                //if (studentWithHighestId == null)
                //{
                //    studentId = 1;
                //}
                //else
                //{
                //    studentId = studentWithHighestId.Id + 1;
                //}

                //INNA FORMUŁA POWYŻSZEGO ZAPISU:
                var _studentId = studentWithHighestId == null ?
                    1 : studentWithHighestId.Id + 1;
            }

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

            SerializeToFile(students); //przekazanie całej listy studentów do pliku

            Close(); //wywołanie metody, która zamknie formatkę, w której dodawany był nowy uczeń (obiekt)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditStudent_Load(object sender, EventArgs e)
        {

        }
    }
}