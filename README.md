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

<img width="1316" height="815" alt="image" src="https://github.com/user-attachments/assets/70d19a25-93de-47d0-9138-6bc264bff778" />



### Filtered Results
<img width="1117" height="547" alt="Screenshot 2026-08-24 161218" src="https://github.com/user-attachments/assets/fb194017-4c83-44b8-9564-1d9e2385cf42" />






### Age Summary

<img width="1313" height="816" alt="Screenshot 2026-08-24 161234" src="https://github.com/user-attachments/assets/5ee80b40-d8c7-45a4-8f63-c82491d3a6f5" />


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
