using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FluentAssertions;
using NUnit.Framework;
using System.Data.Entity;
using FizzWare.NBuilder;

namespace HallgatoFelvetel
{
    [TestFixture]
    public class ViewModelTest
    {
        private ViewModel _viewModel;
        private Mock<ISampleContext> _contextMock;
        private Mock<DbSet<StudentEntity>> _studentDbMock;
        private Mock<DbSet<AppointmentEntity>> _appointmentDbMock;
        private List<StudentEntity> _studentList;
        private List<AppointmentEntity> _appointmentList;

        [SetUp]
        public void Setup()
        {
            _contextMock = new Mock<ISampleContext>();
            _studentDbMock = new Mock<DbSet<StudentEntity>>();
            _appointmentDbMock = new Mock<DbSet<AppointmentEntity>>();
            _contextMock.SetupGet(context => context.StudentEntities)
                .Returns(_studentDbMock.Object);
            _contextMock.SetupGet(context => context.AppointmentEntities)
                .Returns(_appointmentDbMock.Object);
            _studentList = new List<StudentEntity>();
            _studentList = Builder<StudentEntity>.CreateListOfSize(10).Build().ToList();
            _appointmentList = new List<AppointmentEntity>();
            _appointmentList = Builder<AppointmentEntity>.CreateListOfSize(10).Build().ToList();
            _appointmentList.Add(new AppointmentEntity
            {
                Id = 1,
                StudentId = 2,
                StudentName = "Henry Raven",
                StudentCourse = "IT",
                Appointment = DateTime.Parse("2016.09.03. 10:00"),
            });
            _studentDbMock.SetDataSource(_studentList);
            _appointmentDbMock.SetDataSource(_appointmentList);
            _viewModel = new ViewModel(_contextMock.Object);
        }

        [Test]
        public void ValidateDateTime_OnValidDateTime_ShouldReturnTrue()
        {
            //Arrange
            string str = "2016.09.02. 10:00";
            DateTime dateTime = DateTime.Parse(str);
            
            //Act
            bool result = _viewModel.ValidateDateTime(dateTime);

            //Assert
            result.Should().BeTrue();
        }

        [Test]
        public void ValidateDateTime_OnInvalidDateTime_ShouldReturnFalse()
        {
            //Arrange
            string str = "2016.08.02. 07:00";
            DateTime dateTime = DateTime.Parse(str);

            //Act
            bool result = _viewModel.ValidateDateTime(dateTime);

            //Assert
            result.Should().BeFalse();
        }

        [Test]
        public void CheckStudent_OnExistingStudent_ShouldReturnTrue()
        {
            //Arrange
            string name = "Henry Raven";

            //Act
            var result = _viewModel.CheckStudent(name);

            //Assert
            result.Should().BeTrue();
        }

        [Test]
        public void CheckStudent_OnNonExistingStudent_ShouldReturnFalse()
        {
            //Arrange
            string name = "John Smith";

            //Act
            var result = _viewModel.CheckStudent(name);

            //Assert
            result.Should().BeFalse();
        }

        [Test]
        public void CreateAppointment_OnAny_ShouldAddAnAppointmentToDatabase()
        {
            //Arrange
            string name = "Henry Raven";
            DateTime dateTime = DateTime.Parse("2016.09.02. 10:00");

            //Act
            var result = _viewModel.CreateAppointment(name, dateTime);

            //Assert
            _appointmentDbMock.Verify(set => set.Add(It.IsAny<AppointmentEntity>()), Times.Once);
            _contextMock.Verify(set => set.SaveChanges(), Times.Once);
        }

        [Test]
        public void GetStudents_OnAny_ShouldReturnStudentsTable()
        {
            //Arrange
            //Act
            var result = _viewModel.GetStudents();

            //Assert
            result.Should().Equal(_studentList);
        }

        [Test]
        public void GetAppointments_OnAny_ShouldReturnAppointmentsTable()
        {
            //Arrange
            //Act
            var result = _viewModel.GetAppointments();

            //Assert
            result.Should().NotBeNull();
            result.Count.Should().BeLessOrEqualTo(_appointmentList.Count);
            result.Should().BeOfType<List<AppointmentEntity>>();
        }
    }
}
