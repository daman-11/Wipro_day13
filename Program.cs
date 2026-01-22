/*joins in sql
 * joins are used to combine rows from two or more tables, based on a related column between them.
 * its a fundamental concept in relational databases that allows you to retrieve data from multiple tables in a single query.
 * with joins, you can create complex queries that provide meaningful insights by linking related data together.
 * there are several types of joins in sql, each serving a different purpose like
 * inner join- returns only the rows that have matching values in both tables.
 * left join- returns all rows from the left table and the matched rows from the right table. if there is no match, null values are returned for columns from the right table.
 * right join - returns all rows from the right table and the matched rows from the left table. if there is no match, null values are returned for columns from the left table.
 * full outer join- returns all rows when there is a match in either left or right table. if there is no match, null values are returned for columns from the table without a match.
 * cross join- returns the cartesian product of both tables, combining each row from the first table with every row from the second table.
 * self join - is a regular join but the table is joined with itself. */
Console.WriteLine("SQL queries mostly focused on joins i.e inner, outer and many more");
