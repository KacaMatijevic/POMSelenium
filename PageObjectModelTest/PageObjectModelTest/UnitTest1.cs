using PageObjectModelTest.Page;

namespace PageObjectModelTest
{
    public class Tests
    {
        PracticeForm form;

        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterName("Katarina");
            form.EnterName("Matijevic");
            form.EnterEmail("kacamatijevic@gmail.com");
            form.SelectGender();
            form.EnterPhoneNumber(0000000000);
            form.EnterSubject("Math");
            form.SelectHobbies();
            form.EnterClick();
        }
    }
}