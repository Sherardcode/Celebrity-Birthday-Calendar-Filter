namespace Scheduler;

using System.Collections.Generic;
using System.Windows.Forms;
public partial class Form1 : Form
{
    private DateTime startDate;
    private DateTime endDate;
    private List<Person> people = new List<Person>();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //Celeb list
        people.Add(new Person { Name = "Tom Hanks", Category = "Actor", Birthday = new DateTime(1956, 7, 9) });
        people.Add(new Person { Name = "Denzel Washington", Category = "Actor", Birthday = new DateTime(1954, 12, 28) });
        people.Add(new Person { Name = "Emma Stone", Category = "Actor", Birthday = new DateTime(1988, 11, 6) });
        people.Add(new Person { Name = "Chris Pratt", Category = "Actor", Birthday = new DateTime(1979, 6, 21) });
        people.Add(new Person { Name = "Scarlett Johansson", Category = "Actor", Birthday = new DateTime(1984, 11, 22) });
        people.Add(new Person { Name = "Keanu Reeves", Category = "Actor", Birthday = new DateTime(1964, 9, 2) });
        people.Add(new Person { Name = "Ryan Gosling", Category = "Actor", Birthday = new DateTime(1980, 11, 12) });
        people.Add(new Person { Name = "Morgan Freeman", Category = "Actor", Birthday = new DateTime(1937, 6, 1) });
        people.Add(new Person { Name = "Natalie Portman", Category = "Actor", Birthday = new DateTime(1981, 6, 9) });
        people.Add(new Person { Name = "Matt Damon", Category = "Actor", Birthday = new DateTime(1970, 10, 8) });
        people.Add(new Person { Name = "Robert Downey Jr.", Category = "Actor", Birthday = new DateTime(1965, 4, 4) });
        people.Add(new Person { Name = "Jennifer Lawrence", Category = "Actor", Birthday = new DateTime(1990, 8, 15) });
        people.Add(new Person { Name = "Leonardo DiCaprio", Category = "Actor", Birthday = new DateTime(1974, 11, 11) });
        people.Add(new Person { Name = "Brad Pitt", Category = "Actor", Birthday = new DateTime(1963, 12, 18) });
        people.Add(new Person { Name = "Samuel L. Jackson", Category = "Actor", Birthday = new DateTime(1948, 12, 21) });
        people.Add(new Person { Name = "Anne Hathaway", Category = "Actor", Birthday = new DateTime(1982, 11, 12) });
        people.Add(new Person { Name = "Chris Evans", Category = "Actor", Birthday = new DateTime(1981, 6, 13) });

        people.Add(new Person { Name = "Taylor Swift", Category = "Musician", Birthday = new DateTime(1989, 12, 13) });
        people.Add(new Person { Name = "Ed Sheeran", Category = "Musician", Birthday = new DateTime(1991, 2, 17) });
        people.Add(new Person { Name = "Bruno Mars", Category = "Musician", Birthday = new DateTime(1985, 10, 8) });
        people.Add(new Person { Name = "Adele", Category = "Musician", Birthday = new DateTime(1988, 5, 5) });
        people.Add(new Person { Name = "Beyonce", Category = "Musician", Birthday = new DateTime(1981, 9, 4) });
        people.Add(new Person { Name = "Justin Timberlake", Category = "Musician", Birthday = new DateTime(1981, 1, 31) });
        people.Add(new Person { Name = "The Weeknd", Category = "Musician", Birthday = new DateTime(1990, 2, 16) });
        people.Add(new Person { Name = "Billie Eilish", Category = "Musician", Birthday = new DateTime(2001, 12, 18) });
        people.Add(new Person { Name = "Katy Perry", Category = "Musician", Birthday = new DateTime(1984, 10, 25) });
        people.Add(new Person { Name = "Harry Styles", Category = "Musician", Birthday = new DateTime(1994, 2, 1) });
        people.Add(new Person { Name = "Elton John", Category = "Musician", Birthday = new DateTime(1947, 3, 25) });
        people.Add(new Person { Name = "Stevie Wonder", Category = "Musician", Birthday = new DateTime(1950, 5, 13) });
        people.Add(new Person { Name = "John Legend", Category = "Musician", Birthday = new DateTime(1978, 12, 28) });
        people.Add(new Person { Name = "Shakira", Category = "Musician", Birthday = new DateTime(1977, 2, 2) });
        people.Add(new Person { Name = "Usher", Category = "Musician", Birthday = new DateTime(1978, 10, 14) });
        people.Add(new Person { Name = "Ariana Grande", Category = "Musician", Birthday = new DateTime(1993, 6, 26) });
        people.Add(new Person { Name = "Rihanna", Category = "Musician", Birthday = new DateTime(1988, 2, 20) });
        people.Add(new Person { Name = "Drake", Category = "Musician", Birthday = new DateTime(1986, 10, 24) });
        people.Add(new Person { Name = "Post Malone", Category = "Musician", Birthday = new DateTime(1995, 7, 4) });
        people.Add(new Person { Name = "Luke Combs", Category = "Musician", Birthday = new DateTime(1990, 3, 2) });



        foreach (var person in people)
        {
            dataGridView1.Rows.Add(
                person.Name,
                person.Birthday.ToShortDateString()

                );
        }


    }



    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {


    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {


        if (radioButton1.Checked)
        {
            startDate = new DateTime(
     2000,
     dateTimePicker1.Value.Month,
     dateTimePicker1.Value.Day);

            label1.Text = startDate.ToString("MM/dd");

        }

        if (radioButton2.Checked)
        {
            endDate = new DateTime(
     2000,
     dateTimePicker1.Value.Month,
     dateTimePicker1.Value.Day);
            label2.Text = endDate.ToString("MM/dd");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {


        dataGridView1.Rows.Clear();
        dataGridView2.Rows.Clear();

        int totalAge = 0;
        foreach (var person in people)

        {
            DateTime normalizedBirthday = new DateTime(
            2000,
            person.Birthday.Month,
            person.Birthday.Day);
            if (startDate <= normalizedBirthday && endDate >= normalizedBirthday)
            {
                dataGridView1.Rows.Add(
                    person.Name,
                    person.Birthday.ToShortDateString()
                    );


                int age = DateTime.Now.Year - person.Birthday.Year;
                if (person.Birthday.Date > DateTime.Today.Date)
                {
                    age--;
                }

                totalAge += age;



                dataGridView2.Rows.Add(
                    person.Name,
                    age


                    );

                label5.Text = $"Years combined = {totalAge.ToString()}";
            }
        }
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        dataGridView1.Rows.Clear();

        dataGridView2.Rows.Clear();

        label3.Text = "";

        startDate = DateTime.MinValue;

        endDate = DateTime.MaxValue;

        label5.Text = " ";

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
}

