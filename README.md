# TM Data Engineer Exam Deliverables

This is the repository for my coding exam at Thinking Machines. The first part includes a brute-force implementation of an algorithm to find coefficients of a given equation which gives the most consecutive number of primes. I used Python to implement the algorithm. The second part consists of cleaning a dataset, loading it into a database, and creating a web service that provides information pertaining to a unique user. I used the pandas and numpy module in Python for the data cleaning process. For the web service, I set up a project using ASP.NET and C#.

## Part 1 - Algorithmic Thinking.py 
This contains the solution for the first problem, and outputs the equation and product of coefficients being asked. 

## Part 2.1 - Soft(ware) Skills.ipynb 
This notebook shows the data cleaning process for the second part. These were the procedures I implemented to clean the data:
- Null values were dropped because there were only 5 NaN values, which are relatively small compared to the original 20,500 rows of data.
- Duplicates were also dropped. The rows with the same values for user, timestamp, and project had their 'hours' aggregated and summed. Duplicates were then also dropped. 
- Erroneous months (in Russian) were converted to its English equivalent, and afterwards, the timestamps were curated to be uniform. 
- Date outliers were removed. 
- Outliers in hours were also taken care of. 

## Part 2.2 - Web Service
The resulting .csv file from the data cleaning process was loaded into Microsoft SQL Server.

A web service using ASP.NET and C# was done, but could only output all users' data because I had difficulties in making the SQL query inside the code work. I tried tweaking the syntax but sometimes they output null and sometimes just an empty space. I wasn't able to verify which part of the code doesn't work with the given SQL query string.
