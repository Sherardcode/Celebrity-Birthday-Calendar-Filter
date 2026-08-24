# Celebrity Birthday Calendar Filter

## Overview

This project is a C# Windows Forms application inspired by industrial filtering and reporting systems I worked with during my internship as a Backend Software Engineering Intern at Blast Cleaning Technologies.

The application recreates key filtering workflows using a portfolio-safe dataset of actors and musicians. Users can select a start and end date range, filter records based on birthdays within that range, and generate summary statistics from the filtered results.

## Features

- Date range selection using a custom filtering workflow
- Real-time filtering of records based on user-selected dates
- Interactive DataGridView reporting
- Automatic age calculations
- Combined age reporting for filtered results
- Clear/reset functionality for repeated searches
- Event-driven WinForms user interface

## Technologies Used

- C#
- .NET
- Windows Forms
- DataGridView
- DateTime Handling
- Object-Oriented Programming

## Project Inspiration

This project was inspired by filtering and reporting concepts explored during my internship at Blast Cleaning Technologies.

While the original industrial software operated on production data, this application recreates similar user-driven filtering and reporting workflows using publicly available sample data.

### Main Interface
<img width="1837" height="1063" alt="Screenshot 2026-08-24 154209" src="https://github.com/user-attachments/assets/7b5e919c-ed89-4e41-95a9-ce0973cca582" />




### Filtered Results

<img width="1163" height="550" alt="Screenshot 2026-08-24 154415" src="https://github.com/user-attachments/assets/62af243a-586f-4487-91fc-358bcf6bce94" />


### Age Summary

<img width="1314" height="815" alt="image" src="https://github.com/user-attachments/assets/79b36070-f474-498a-af9a-3a513244c0d3" />


## Example Workflow

1. Select a Start Date
2. Select an End Date
3. Click **Go**
4. View all birthdays within the selected range
5. Review calculated ages
6. View the total combined age of all filtered records
7. Clear the results and perform another search

## Skills Demonstrated

- User Interface Design
- Event-Driven Programming
- Date-Based Filtering
- Data Presentation
- Collection Processing
- Statistical Aggregation
- Desktop Application Development

## Future Enhancements

- CSV Export Functionality
- Additional Filter Categories
- Charts and Visualizations
- External Data Sources
- Birthday Statistics Dashboard


## Sample Code 

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




The code above deal with logic filter records based on the user-selected start and end dates and dynamically updates the results grid.
